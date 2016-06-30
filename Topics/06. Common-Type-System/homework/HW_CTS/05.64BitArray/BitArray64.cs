using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray
{
    class BitArray64 : IEnumerable<int>
    {
        private ulong bitArray;

        public BitArray64()
        {
            this.bitArray = 0;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new BitArrayEnumerator(this.bitArray);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            var anotherArray = obj as BitArray64;
            return this.bitArray == anotherArray.bitArray;
        }

        public override int GetHashCode()
        {
            return (int)(this.bitArray % int.MaxValue);
        }

        public static bool operator ==(BitArray64 array1, BitArray64 array2)
        {
            return array1.Equals(array2);
        }

        public static bool operator !=(BitArray64 array1, BitArray64 array2)
        {
            return !array1.Equals(array2);
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                    throw new IndexOutOfRangeException("Index must be betweeen 0 and 63");
                var result = (this.bitArray & (1ul << index)) >> index;
                return (int)result;
            }
            set
            {
                if (index < 0 || index > 63)
                    throw new IndexOutOfRangeException("Index must be betweeen 0 and 63");
                if (value < 0 || value > 1)
                    throw new ArgumentOutOfRangeException("Value of the bit to set must be 0 or 1");

                if (value == 0)
                {
                    this.bitArray = this.bitArray & ~(1ul << index);
                }
                if (value == 1)
                    this.bitArray = this.bitArray | (1ul << index);
            }
        }

        public override string ToString()
        {
            return Convert.ToString((long)this.bitArray, 2).PadLeft(64, '0');
        }
    }
}
