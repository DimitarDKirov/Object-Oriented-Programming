using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(5);
            timer.TimeOut += TimeOutHandler;
            timer.Start();
            timer.Stop();

        }

        static void TimeOutHandler(object sender, TimeOutEventArgs args)
        {
            Console.WriteLine("Time out of {0}s reached at {1:HH:mm:ss}", args.TimeInterval, args.TimeReached);
        }
    }
}
