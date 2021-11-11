using System;

namespace S1_E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            numbers.EvenNumbers();
            numbers.UnevenNumbers();
            numbers.PrintNumbersBetweeen(9,99);

        }
    }
}