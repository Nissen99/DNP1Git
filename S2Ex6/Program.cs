using System;
using System.Threading;

namespace S2Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            
            BirdWatcher watcher = new BirdWatcher();
            bird.Action += watcher.react;


            while (true)
            {
                bird.Action.Invoke(bird.run());
                
                Thread.Sleep(1000);

            }
        }
    }
}