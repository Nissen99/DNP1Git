using System;
using System.Collections.Generic;
using System.Text.Json;

namespace S3Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] list = new Person[3];

            Person mikkel = new Person()
            {
                Sex = 'M', LastName = "Nissen", Age = 21, Height = 6.3, FirstName = "Mikkel"
            };
            
            Person solman = new Person()
            {
                Sex = 'M', LastName = "Jali", Age = 67, FirstName = "Mikkel", IsMarried = true
            };
            
            Person matman = new Person()
            {
                Sex = 'F', Hobbies = new []{"having sex with bitches", "yoloing"}, Age = 21, Height = 6.3, FirstName = "mat"
            };

            list[0] = mikkel;
            list[1] = solman;
            list[2] = matman;
            
            string jsNotFormatted = JsonSerializer.Serialize(list);
            string jsonFormatted = JsonSerializer.Serialize(list, new JsonSerializerOptions {WriteIndented = true});

            Console.WriteLine(jsNotFormatted);
            Console.WriteLine("------------______---------");
            Console.WriteLine(jsonFormatted);

            PersonPersistence pp = new PersonPersistence();

            List<Person> persons = new List<Person>();

            persons.Add(mikkel);
            persons.Add(solman);
            persons.Add(matman);
            
            pp.StoreObject(persons);

            Console.WriteLine("-------------------------------------------------------");
            pp.getBackPpl();





        }
    }
}