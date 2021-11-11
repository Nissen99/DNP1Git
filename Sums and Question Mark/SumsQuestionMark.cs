using System;

namespace Sums_and_Question_Mark
{
    public class SumsQuestionMark
    {
        public string GenerateRandomString()
        {
            Random random = new Random();
            string everything = "abcdefghijklmnopqrstuvxyz123456789?";
            string randomString = "";

            for (int i = 0; i < 20; i++)
            {
                int randomInt = random.Next(0, everything.Length);
                randomString += everything.Substring(randomInt, 1);
            }

            return randomString;
        }

        public string FindSum(string randomString)
        {

            string _return = "";
            int sum = 0;
            int adder;
            for (int i = 0; i < randomString.Length; i++)
            {
                string current = randomString.Substring(i,1);
                Console.WriteLine(current + " CHAR");

                if (int.TryParse(current, out adder))
                {
                    sum += adder;
                    Console.WriteLine(sum + " SUM");
                } else if (current.Equals("?"))
                {
                    _return += sum + ", ";
                    Console.WriteLine( _return + " QUESTION MARK");
                    sum = 0;
                }
               
                
            }
            _return += sum + ", ";


            return _return;
        }
    }
}