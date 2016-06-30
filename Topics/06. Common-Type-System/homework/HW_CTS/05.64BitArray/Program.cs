//Problem 5. 64 Bit array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64 bitArray1 = new BitArray64();
            Console.WriteLine(bitArray1);
            bitArray1[1] = 1;
            bitArray1[62] = 1;
            Console.WriteLine(bitArray1);
            BitArray64 bitArray2 = new BitArray64();
            bitArray2[1] = 1;
            bitArray2[62] = 1;
            Console.WriteLine(bitArray1 == bitArray2);
            Console.WriteLine(bitArray1.GetHashCode());
            for (int i = 1; i <= 63; i += 2)
            {
                bitArray1[i] = 1;
                bitArray1[i - 1] = 0;
            }
            Console.WriteLine(bitArray1);
            int index = 0;
            foreach (var bit in bitArray1)
            {
                Console.WriteLine("array[{0}] -> {1}", index, bit);
                index++;
            }
        }
    }
}
