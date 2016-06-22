using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    class Timer
    {
        private int timeInterval;
        private bool isActive;

        public event EventHandler<TimeOutEventArgs> TimeOut;

        public Timer(int timeSec)
        {
            this.timeInterval = timeSec;
        }

        public void Start()
        {
            this.isActive = true;
            while (this.isActive)
            {
                Thread.Sleep(this.timeInterval * 1000);
                this.OnTimeOut();
            }
        }

        public void Stop()
        {
            this.isActive = false;
        }

        protected virtual void OnTimeOut()
        {
            if (this.TimeOut != null)
            {
                TimeOutEventArgs args = new TimeOutEventArgs(this.timeInterval, DateTime.Now);
                this.TimeOut(this, args);
            }
        }

    }
}
