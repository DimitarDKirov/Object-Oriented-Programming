using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer person = new Person() { Name = "Ivan Pertov" };
            Loan loanPerson = new Loan(person, 3.5);
            loanPerson.Deposit(1000);
            Console.WriteLine("Loan ballance after deposit of 1000");
            Console.WriteLine(loanPerson);
            Console.WriteLine("Loan for person interest for 6 months: "+loanPerson.CalculateInterest(6));
        }

    }
}
