﻿using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider { 
    // TODO implement custom interface, which extends the above,
    // to avoid casting when this class is used. 
    private List<User> users;

    // private User currentUser; TODO cache user, instead of reading every time.
    private readonly IJSRuntime _jSRuntime;

    // private readonly IJSInProcessRuntime _jSInProcessRuntime;

    // hardcoded list of users
    public CustomAuthenticationStateProvider(IJSRuntime jSRuntime) {
        _jSRuntime = jSRuntime;

        // _jSInProcessRuntime = jSRuntime as IJSInProcessRuntime;

        users = new List<User>();
        users.Add(new User {
            Username = "Troels",
            Password = "Troels1",
            Roles = new[] {"Pirate", "Ninja"}
        });

        users.Add(new User {
            Username = "Jakob",
            Password = "Jakob1",
            Roles = new[] {"Pirate"}
        });

        users.Add(new User {
            Username = "Kasper",
            Password = "Kasper1",
            Roles = new string[] { }
        });
    }

    // this gets called at first load
    public override async Task<AuthenticationState> GetAuthenticationStateAsync() {
        Console.WriteLine("Retrieving user info");

        // Console.WriteLine("There is a current user " + (currentUser != null));

        var identity = new ClaimsIdentity();

        // check if session storage has the value. ie if the user has been logged in before.
        var serialisedData = await _jSRuntime.InvokeAsync<string>("sessionStorage.getItem", "currentUser");
        if (serialisedData != null) {
            User user = JsonSerializer.Deserialize<User>(serialisedData, options);

            if (user != null) {
                identity = SetupClaimsForUser(user);
            }
        }

        var claimsPrincipal = new ClaimsPrincipal(identity);
        return await Task.FromResult(new AuthenticationState(claimsPrincipal));
    }

    private ClaimsIdentity SetupClaimsForUser(User user) {
        ClaimsIdentity identity;
        List<Claim> claims = new List<Claim>();
        claims.Add(new Claim(ClaimTypes.Name, user.Username));
        claims.Add(new Claim(ClaimTypes.Role, user.Username));

        foreach (string role in user.Roles) {
            claims.Add(new Claim("Role", role));
        }

        identity = new ClaimsIdentity(claims, "apiauth_type");
        return identity;
    }

    // function will tell the app that user is authenticated and save the state in the session store if authenticated through the _comm.
    public void ValidateLogin(string username, string password) {
        Console.WriteLine("Validating log in");

        if (string.IsNullOrEmpty(username)) throw new Exception("Enter username");

        if (string.IsNullOrEmpty(password)) throw new Exception("Enter password");

        try {
            var user = users.Find(u => u.Username.Equals(username) && u.Password.Equals(password));
            if (user != null) {
                Console.WriteLine("Found user");
            }

            var identity = new ClaimsIdentity();
            if (user != null) {
                identity = SetupClaimsForUser(user);
            }

            // store in session storage
            //currentUser = user;

            string serialisedData = JsonSerializer.Serialize(user, options);

            _jSRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", serialisedData);

            // tell the application that user state has been changed
            NotifyAuthenticationStateChanged(
                Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
        } catch (Exception e) {
            Console.WriteLine(e);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal())));
        }
    }

    private JsonSerializerOptions options =
        new JsonSerializerOptions {
            DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
            IgnoreNullValues = true,
            IgnoreReadOnlyProperties = true,
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            ReadCommentHandling = JsonCommentHandling.Skip,
            WriteIndented = false
        };

    public void Logout() {
        Console.WriteLine("Logging out");

        // remove the user from the session store.
        // currentUser = null;

        // clear the identity to mark as logged out
        var user = new ClaimsPrincipal(new ClaimsIdentity());

        // tell the application that user-state has been changed
        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
    }
}