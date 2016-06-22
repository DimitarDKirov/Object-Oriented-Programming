//Problem 7. Timer
//    Using delegates write a class Timer that can execute certain method at each t seconds.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 5;      //time interval
            Timer timer = new Timer(t);
            TimeOut timeOut = OnTimeout;
            Console.WriteLine("Timer started! Press CTRL+C to cancel the program");
            timer.Start(timeOut);
        }

        static void OnTimeout()
        {
            Console.WriteLine("Time out at {0}", DateTime.Now.ToLongTimeString());
        }
    }
}
