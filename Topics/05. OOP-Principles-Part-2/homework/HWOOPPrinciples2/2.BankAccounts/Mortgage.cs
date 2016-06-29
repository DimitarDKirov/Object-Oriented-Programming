using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Mortgage : Account
    {
        public Mortgage(ICustomer customer, double interestRate) : base(customer, interestRate)
        { }

        public override double CalculateInterest(uint months)
        {
            if (this.Customer is Person)
            {
                if (months <= 6)
                    return 0;
                return base.CalculateInterest(months - 6);
            }
            //company
            if (months > 12)
            {
                return base.CalculateInterest(months - 12) + this.Balance * 12 * this.InterestRate / 2;
            }

            return this.Balance * (1 + months * this.InterestRate / 200);
        }
    }
}
