//Problem 8.* Events
//    Read in MSDN about the keyword event in C# and how to publish events.
//    Re-implement the above using .NET events and following the best practices.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static int repeats;
        static void Main(string[] args)
        {
            Timer timer = new Timer(5);
            timer.TimeOut += TimeOutHandler;
            repeats = 10;
            timer.Start();

            timer.Stop();
        }

        static void TimeOutHandler(object sender, TimeOutEventArgs args)
        {
            Console.WriteLine("Time out of {0}s reached at {1:HH:mm:ss}", args.TimeInterval, args.TimeReached);
            repeats--;
            var timer = sender as Timer;
            if (timer != null && repeats <= 0)
            {
                timer.Stop();
            }
        }
    }
}
