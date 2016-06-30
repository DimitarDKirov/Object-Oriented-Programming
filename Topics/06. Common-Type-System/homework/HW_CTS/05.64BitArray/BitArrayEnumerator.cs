using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray
{
    class BitArrayEnumerator : IEnumerator<int>
    {
        private ulong bitArray;
        private int currentIndex;

        public BitArrayEnumerator(ulong bitArray)
        {
            this.bitArray = bitArray;
            this.currentIndex = -1;
        }

        public int Current
        {
            get
            {
                var result = this.bitArray & (1ul << this.currentIndex);
                return (int)(result >> this.currentIndex);
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return this.Current;
            }
        }

        public void Dispose()
        { }

        public bool MoveNext()
        {
            if (this.currentIndex >= 63)
                return false;

            this.currentIndex++;
            return true;
        }

        public void Reset()
        {
            this.currentIndex = -1;
        }
    }
}
