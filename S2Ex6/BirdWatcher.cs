using System;

namespace S2Ex6
{
    public class BirdWatcher
    {
        public void react(string birdBehavior)
        {
            switch (birdBehavior)
            {
                case "Bird flaps wings":
                    Console.WriteLine("uhhh look at the bird flap");
                    break;
                case "Bird sings":
                    Console.WriteLine("How beautiful");
                    break;
                case "Bird does mating dance":
                    Console.WriteLine("Ulala");
                    break;
                
            }
        }
    }
}