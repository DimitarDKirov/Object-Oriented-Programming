using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Loan : Account
    {
        public Loan(ICustomer customer, double interestRate) : base(customer, interestRate)
        { }

        public override double CalculateInterest(uint months)
        {
            if (this.Customer is Person)
            {
                if (months <= 3)
                    return 0;
                return base.CalculateInterest(months - 3);
            }
            //company
            if (months <= 2)
                return 0;
            return base.CalculateInterest(months - 2);
        }
    }
}
