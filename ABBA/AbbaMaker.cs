namespace ABBA
{
    public class AbbaMaker
    {
        public string MakeAbba(string first, string second)
        {
            return $"{first}{second}{second}{first}";
        }


        public string MakeWeird(string outer, string inner)
        {
            string outersplit1 = outer.Substring(0,2);
            string outersplit2 = outer.Substring(2,2);
            return $"{outersplit1}{inner}{outersplit2}";
        }

        public string FirstAndLast(string text, int index)
        {
            string firstPart = text.Substring(0, index);
            string secondPart = text.Substring(text.Length - index, index);
            return firstPart + secondPart;
        }

        public int BiggestDiff(int[] ints)
        {
            int max = ints[0];
            int min = ints[0];
            
            foreach (int i in ints)
            {
                if (i > max)
                {
                    max = i;
                } else if (i < min)
                {
                    min = i;
                }
            }
            return max - min;
        }

        public int NumberOfClumbs(int[] numbers)
        {
            int counter = 0;
            int previ = 0;
            int prevprei = 0;
            
            foreach (int i in numbers)
            {
                if (i == previ && i != prevprei)
                {
                    counter++;
                }

                prevprei = previ;
                previ = i;

            }

            return counter;
        }
    }
}