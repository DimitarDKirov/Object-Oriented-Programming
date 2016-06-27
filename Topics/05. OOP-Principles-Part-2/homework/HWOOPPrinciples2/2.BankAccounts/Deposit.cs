using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Deposit : Account
    {
        public Deposit(ICustomer customer, double interstRate) : base(customer, interstRate)
        { }

        public void Withdraw(double amount)
        {
            this.Balance -= amount;
        }

        public override double CalculateInterest(uint months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            return base.CalculateInterest(months);
        }
    }
}
