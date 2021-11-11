using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace S3Ex1
{
    public class PersonPersistence
    {
        public void StoreObject(List<Person> persons)
        {

            string jsonFormatted = JsonSerializer.Serialize(persons, new JsonSerializerOptions {WriteIndented = true});

            using StreamWriter sw = new StreamWriter("MyLines.txt");
            
            sw.WriteLine(jsonFormatted);
        }

        public void getBackPpl()
        {
            using StreamReader sr = new StreamReader("C:\\Users\\Mikkel\\RiderProjects\\DNP1\\S3Ex1\\bin\\Debug\\net5.0\\MyLines.txt");
            string peple = "";
            while (!sr.EndOfStream)
            {
                peple += sr.ReadLine();

            }

            Console.WriteLine(peple);
        }
    }
}