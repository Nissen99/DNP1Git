using System;

namespace MathLib
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int[] ints)
        {
            int counter = 0;

            foreach (int number in ints)
            {
                counter += number;
            }

            return counter;
        }

        public int MaxNumber()
        {
            Console.WriteLine("Write 2 numbers");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }

            return secondNumber;


        }
    }
}