using System;

namespace S1_E1
{
    public class Numbers
    {
        public void EvenNumbers()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        
        
        public void UnevenNumbers()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void PrintNumbersBetweeen(int divider, int max)
        {
            for (int i = 0; i < max; i++)
            {
                if (i % divider == 0)
                {
                    Console.WriteLine(i);
                }    
            }
            
                
            
        }
    }
}