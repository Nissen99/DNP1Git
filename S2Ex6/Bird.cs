using System;

namespace S2Ex6
{
    public class Bird
    {
        public Action<string> Action { get; set; }
        public string run()
        {
            Random random = new Random();
            int rNumber =random.Next(1, 4);

            switch (rNumber)
            {
                case 1:
                    return "Bird flaps wings";
                case 2:
                    return "Bird sings";
                case 3:
                    return "Bird does mating dance";
                default:
                    return "yikers";
            }
        }
    }
}