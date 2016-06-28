using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class InvalidRangeException<T> : ApplicationException
    {
        public T Start { get; set; }

        public T End { get; set; }

        public InvalidRangeException(T start, T end) : base(string.Format("Allowed range is betweeen {0} and {1}", start, end))
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string message, T start, T end) : base(message)
        {
            this.Start = start;
            this.End = end;
        }
    }
}
