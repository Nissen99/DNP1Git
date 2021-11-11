using System;

namespace S2Ex4
{
    public class Patient
    {
        private int numberInQueue;
        public WaitingRoom WaitingRoom;

        public Patient(WaitingRoom waitingRoom)
        {
            this.WaitingRoom = waitingRoom;
            numberInQueue = this.WaitingRoom.DrawNumber();
        }

        public void ReactToNumber(int ticketNumber)
        {
            if (ticketNumber == numberInQueue)
            {
                Console.WriteLine("Patient: " + numberInQueue + " Go to doctor");
                WaitingRoom.NumberChange -= ReactToNumber;
            }
            else
            {
                Console.WriteLine("Patient: " + numberInQueue + " Play with Phone");
            }
            
            
        } 
    }
}