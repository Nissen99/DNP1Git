using System;
using System.Threading;

namespace S2Ex4
{
    public class WaitingRoom
    {
        public Action<int> NumberChange { get; set; }
        private int curentNumber;
        private int ticketCount;

        public WaitingRoom()
        {
            curentNumber = 0;
            ticketCount = 0;
            
        }

        public void RunWaitingRoom()
        {
            while (curentNumber < ticketCount)
            {
                Console.WriteLine("Diing!");

                NumberChange.Invoke(++curentNumber);
                Thread.Sleep(1000);
            }
        }

        public int DrawNumber()
        {
            return ++ticketCount;
        }
    }
}