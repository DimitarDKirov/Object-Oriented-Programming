using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Address : ICloneable
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string AddressDetails { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", this.Country, this.City, this.AddressDetails);
        }

        public object Clone()
        {
            return new Address()
            {
                Country = this.Country,
                City = this.City,
                AddressDetails = this.AddressDetails
            };
        }
    }
}
