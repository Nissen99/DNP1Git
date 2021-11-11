using System;

namespace Kth_Largest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            LargestNumber largestNumber = new LargestNumber();
            int[] ints = new[] {1, 2, 3, 4, 5, 6, 72,12, 1, 2,3, 4};
            Console.WriteLine(largestNumber.GetWithLoops(ints, 6));

        }
    }
}