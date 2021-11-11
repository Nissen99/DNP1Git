using System;

namespace MathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(1,2));
            int[] ints = new[] {1, 2, 3, 4, 5, 6, 7};
            Console.WriteLine(calculator.Add(ints));

            Console.WriteLine(calculator.MaxNumber());


        }
    }
}