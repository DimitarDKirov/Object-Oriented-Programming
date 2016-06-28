using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Shampoo : Product, IShampoo, IProduct
    {
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, gender, price)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public uint Milliliters { get; private set; }

        public UsageType Usage { get; private set; }

        public override decimal Price
        {
            get
            {
                return base.Price * this.Milliliters;
            }
        }

        public override string Print()
        {
            StringBuilder builder = new StringBuilder(base.Print());
            builder.AppendFormat("  * Quantity: {0} ml", this.Milliliters);
            builder.AppendLine();
            builder.AppendFormat("  * Usage: {0}", this.Usage);

            return builder.ToString();
        }
    }
}
