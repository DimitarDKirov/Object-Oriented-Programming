using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    public abstract class Product : IProduct
    {
        private const int MinNameLength = 3;
        private const int MaxNameLength = 10;
        private const int MinBrandNameLength = 2;
        private const int MaxBrandNameLength = 10;

        private string name;
        private string brand;

        public Product(string name, string brand, GenderType gender, decimal price)
        {
            this.Name = name;
            this.Brand = brand;
            this.Gender = gender;
            this.Price = price;
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, MaxBrandNameLength, MinBrandNameLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Product brand", MinBrandNameLength, MaxBrandNameLength));
                this.brand = value;
            }
        }


        public GenderType Gender { get; private set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, MaxNameLength, MinNameLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Product name", MinNameLength, MaxNameLength));
                this.name = value;
            }
        }


        public virtual decimal Price { get; private set; }

        public virtual string Print()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("- {0} - {1}:", this.Brand, this.Name);
            builder.AppendLine();
            builder.AppendLine("  * Price: $" + this.Price);
            builder.AppendLine("  * For gender: " + this.Gender);
            return builder.ToString();
        }
    }
}
