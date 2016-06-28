using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    class Toothpaste : Product, IToothpaste
    {
        private const int MinIngredientName = 4;
        private const int MaxIngredientName = 12;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, gender, price)
        {
            this.ValidateIngredients(ingredients);
            this.Ingredients = string.Join(", ", ingredients);
        }

        public string Ingredients { get; private set; }

        private void ValidateIngredients(IList<string> ingredients)
        {
            foreach (var ingredient in ingredients)
            {
                Validator.CheckIfStringLengthIsValid(ingredient, MaxIngredientName, MinIngredientName, string.Format(GlobalErrorMessages.InvalidStringLength, "Each ingredient", MinIngredientName, MaxIngredientName));
            }
        }

        public override string Print()
        {
            StringBuilder builder = new StringBuilder(base.Print());
            builder.AppendFormat("  * Ingredients: {0}", this.Ingredients);
            return builder.ToString();
        }
    }
}
