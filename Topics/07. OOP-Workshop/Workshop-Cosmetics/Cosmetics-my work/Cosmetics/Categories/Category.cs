using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Categories
{
    public class Category : ICategory
    {
        private const int MinNameLength = 2;
        private const int MaxNameLength = 15;

        private const string ProductRemovalErrorMessage = "Product {0} does not exist in category {1}!";

        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckIfStringLengthIsValid(value, MaxNameLength, MinNameLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", MinNameLength, MaxNameLength));
                this.name = value;
            }
        }

        private ICollection<IProduct> products;
        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Product"));
            this.products.Add(cosmetics);
        }

        public string Print()
        {
            var sortedproducts = this.products
                .OrderBy(p => p.Brand)
                .ThenByDescending(p => p.Price)
                .ToList();
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("{0} category - {1} {2} in total", this.Name, this.products.Count, this.products.Count != 1 ? "products" : "product");
            //for (int i = 0; i < sortedproducts.Count; i++)
            //{
            //    builder.Append(sortedproducts[i].Print());
            //    if (i < sortedproducts.Count - 1) builder.AppendLine();
            //}
            foreach (var product in sortedproducts)
            {
                builder.AppendLine();
                builder.Append(product.Print());
            }
            return builder.ToString();
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!this.products.Contains(cosmetics))
                throw new ArgumentException(string.Format(ProductRemovalErrorMessage, cosmetics.Name, this.Name));

            this.products.Remove(cosmetics);
        }
    }
}
