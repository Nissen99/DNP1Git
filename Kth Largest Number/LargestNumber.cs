using System;

namespace Kth_Largest_Number
{
    public class LargestNumber
    {
         public int GetKthLargestNumber(int[] ints, int k)
        {
            CheckIfKBig(ints, k);
            int biggestInt = -1;
            int[] largestInts = new int[k];
            
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > largestInts[k-1])
                {
                    for (int j = 0; j < largestInts.Length-1; j++)
                    {
                        if (j == 0)
                        {
                            biggestInt = largestInts[j];
                        }
                        largestInts[j] = largestInts[j+1];
                    }
                    largestInts[k - 1] = ints[i];
                }
            }
            return biggestInt;
        }

        private static void CheckIfKBig(int[] ints, int k)
        {
            if (k > ints.Length)
            {
                throw new ArgumentException("k cannot be larger than lenght of list");
            }
        }


        public int GetWithLoops(int[] ints, int k)
        {
            CheckIfKBig(ints, k);

            int bigNumber = 0;
            int[] largestInts = new int[k - 1];
            
            
            for (int i = 0; i < ints.Length; i++)
            {
                if (bigNumber < ints[i])
                {
                    for (int h = 1; h < largestInts.Length+1; h++)
                    {
                        
                        if (ints[i] > largestInts[largestInts.Length - h])
                        {
                            for (int j = 0; j < largestInts.Length - 1; j++)
                            {
                                if (j == 0)
                                {
                                    bigNumber = largestInts[j];
                                }

                                largestInts[j] = largestInts[j + 1];
                            }

                            largestInts[largestInts.Length - h] = ints[i];
                        }
                    }
                }
                
            }

            return bigNumber;

        }
        
        
        public int GetWithSort(int[] ints, int k)
        {
            CheckIfKBig(ints, k);


            Array.Sort(ints);
            Array.Reverse(ints);
            return ints[k-1];
        }
    }
}