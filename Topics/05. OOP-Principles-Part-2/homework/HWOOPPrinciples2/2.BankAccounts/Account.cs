using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    abstract class Account
    {
        public Account(ICustomer customer, double interstRate)
        {
            this.Customer = customer;
            this.InterestRate = interstRate;
            this.Balance = 0;
        }

        public ICustomer Customer { get; set; }

        public double Balance { get; protected set; }

        public double InterestRate { get; set; }

        public void Deposit(double amount)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException("Amount ot  deposit can not be negative");
            this.Balance += amount;
        }

        public virtual double CalculateInterest(uint months)
        {
            return this.InterestRate * months*this.Balance;
        }

        public override string ToString()
        {
            return string.Format("{0} has ballance {1:c}", this.Customer.Name, this.Balance);
        }
    }
}
