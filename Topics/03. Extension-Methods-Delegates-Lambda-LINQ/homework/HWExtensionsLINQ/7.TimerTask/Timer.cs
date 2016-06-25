using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerTask
{
    public delegate void TimeOut();
    class Timer
    {
        private int timeInterval;

        public Timer(int time)
        {
            this.timeInterval = time;
        }

        public void Start(TimeOut method)
        {
            while (true)
            {
                Thread.Sleep(timeInterval * 1000);
                method();
            }
        }
    }
}
