namespace Largest_Product_Series
{
    public class NumberScanner
    {
        public string HighestProduct(string Numbers, int height)
        {
            for (int i = 3; i < Numbers.Length; i++)
            {
                int first = int.Parse(Numbers.Substring(i - 3, 1));
                int second = int.Parse(Numbers.Substring(i - 2, 1 ));
                int third = int.Parse(Numbers.Substring(i - 1, 1 ));
                int fouth = int.Parse(Numbers.Substring(i , 1));

                int sum = first * second * third * fouth;

                if (sum == height)
                {
                    return $"{first}{second}{third}{fouth} " + sum;
                }
            }

            return "Nothing found";
        }
    }
}