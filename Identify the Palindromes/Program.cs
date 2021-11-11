using System;

namespace Identify_the_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindromes palindromes = new Palindromes();
            Console.WriteLine(palindromes.IsPalindrome("mr owl ate my metal worm"));
           
        }
    }
}