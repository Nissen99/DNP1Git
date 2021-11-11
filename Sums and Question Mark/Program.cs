using System;

namespace Sums_and_Question_Mark
{
    class Program
    {
        static void Main(string[] args)
        {
            SumsQuestionMark sumsQuestionMark = new SumsQuestionMark();
            string random = sumsQuestionMark.GenerateRandomString();
            Console.WriteLine(random);
            Console.WriteLine(sumsQuestionMark.FindSum(random));
        }
    }
}