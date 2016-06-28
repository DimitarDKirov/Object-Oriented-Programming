//Problem 3. Range Exceptions

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;
            Console.WriteLine("Input number in range {0} - {1} to test InvalidRangeException<DateTime> or out of this range to test InvalidRangeException<int>", min, max);
            int number = int.Parse(Console.ReadLine());
            if (number < min || number > max) throw new InvalidRangeException<int>(min, max);

            DateTime minDate = new DateTime(1980, 1, 1);
            DateTime maxDate = new DateTime(2013, 12, 31);
            var testedDate = DateTime.Now;
            if (testedDate < minDate || testedDate > maxDate)
                throw new InvalidRangeException<DateTime>(
                    string.Format("Allowed date is betweeen {0} and {1}", minDate.ToShortDateString(), maxDate.ToShortDateString()),
                    minDate,
                    maxDate);
        }
    }
}
