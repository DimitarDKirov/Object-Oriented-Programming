using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class TimeOutEventArgs:EventArgs
    {
        public TimeOutEventArgs(int interval, DateTime time)
        {
            this.TimeInterval = interval;
            this.TimeReached = time;
        }

        public int TimeInterval { get; set; }
        public DateTime TimeReached { get; set; }
    }
}
