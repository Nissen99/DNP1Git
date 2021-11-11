using System;

namespace Identify_the_Palindromes
{
    public class Palindromes
    {
        public bool IsPalindrome(string contender)
        {
            contender = contender.Replace(" ", "");
            
            if (contender.Length % 2 == 0)
            {
                Console.WriteLine("Not EVEN");
                return false;
            }
            
            int behind = contender.Length-1;
            
            for (int i = 0; i < contender.Length/2; i++)
            {
                if (!contender.Substring(i,1).Equals(contender.Substring(behind,1)))
                {
                    Console.WriteLine("Not correct " + i + "   +    " + behind);
                    return false;
                }
                behind--;
            }

            return true;
        }
    }
}