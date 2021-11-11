using System;

namespace S2Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitingRoom waitingRoom = new WaitingRoom();

            Patient Solman = new Patient(waitingRoom);
            Patient Solman2 = new Patient(waitingRoom);
            Patient Solman3 = new Patient(waitingRoom);
            // Patient Solman4 = new Patient(waitingRoom);
            // Patient Solman5 = new Patient(waitingRoom);

            waitingRoom.NumberChange += Solman.ReactToNumber;
            waitingRoom.NumberChange += Solman2.ReactToNumber;
            waitingRoom.NumberChange += Solman3.ReactToNumber;
            // waitingRoom.NumberChange += Solman4.ReactToNumber;
            // waitingRoom.NumberChange += Solman5.ReactToNumber;
            
            
            
            waitingRoom.RunWaitingRoom();



        }
    }
}