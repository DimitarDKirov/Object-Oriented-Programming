using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Mortgage : Account
    {
        public Mortgage(ICustomer customer, double interstRate) : base(customer, interstRate)
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
            uint halfInterestPeriod, fullInterestPeriod;
            if (months > 12)
            {
                halfInterestPeriod = 12;
                fullInterestPeriod = months - 12;
            }
            else
            {
                halfInterestPeriod = months;
                fullInterestPeriod = 0;
            }
            return base.CalculateInterest(fullInterestPeriod) + base.CalculateInterest(halfInterestPeriod) / 2;
        }
    }
}
