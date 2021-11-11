using System;

namespace AbbaMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //ssadas
            AbbaMaker maker = new AbbaMaker();
            Console.WriteLine(maker.MakeAbba("Hello", "Yikers"));
            Console.WriteLine("--------------- ----------------");
            Console.WriteLine(maker.MakeWeird("<<>>", "Hello"));
            Console.WriteLine("--------------- ----------------");
            Console.WriteLine(maker.FirstAndLast("chocolate", 1));
            Console.WriteLine("--------------- ----------------");
            int[] ints = new[] {6, 2, 3, 4, 2, 37, 1, 8, 9};
            Console.WriteLine(maker.BiggestDiff(ints));
            Console.WriteLine("--------------- ----------------1");
            int[] numbers = new[] {1, 2, 2, 3, 4, 4};
            Console.WriteLine(maker.NumberOfClumbs(numbers));
            Console.WriteLine("--------------- ----------------2");
            int[] numbers2 = new[] {1, 1, 2, 1, 1};
            Console.WriteLine(maker.NumberOfClumbs(numbers2));
            Console.WriteLine("--------------- ----------------3");
            int[] numbers3 = new[] {1, 1, 1, 1, 1};
            Console.WriteLine(maker.NumberOfClumbs(numbers3));


        }
    }
}