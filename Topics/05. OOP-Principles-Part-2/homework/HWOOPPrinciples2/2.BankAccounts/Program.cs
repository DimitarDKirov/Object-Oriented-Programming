//Problem 2. Bank accounts

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
            Console.WriteLine("Loan for person, interest for 6 months: " + loanPerson.CalculateInterest(6));
            Deposit depositPerson = new Deposit(person, 2);
            depositPerson.Deposit(2500);
            depositPerson.Withdraw(1600);
            Console.WriteLine("Deposit ballance after deposit of 2500 and withdraw of 1600");
            Console.WriteLine(depositPerson);
            Console.WriteLine("Deposit for person, interest in 6 months " + depositPerson.CalculateInterest(6));
            Mortgage mortgagePerson = new Mortgage(person, 3);
            mortgagePerson.Deposit(1000);
            Console.WriteLine("Mortgage for person, interest for 7 months " + mortgagePerson.CalculateInterest(7));
            Console.WriteLine();

            ICustomer company = new Company() { Name = "Corporation" };
            Deposit depositCompany = new Deposit(company, 5);
            depositCompany.Deposit(100);
            Console.WriteLine("Deposit for company, interest for 6 months " + depositCompany.CalculateInterest(6));
            Loan loanCOmpany = new Loan(company, 4);
            loanCOmpany.Deposit(1000);
            Console.WriteLine("Loan for company, interest for 6 months {0:c}", loanCOmpany.CalculateInterest(6));
            Mortgage mortgageCompany = new Mortgage(company, 10);
            mortgageCompany.Deposit(1000);
            Console.WriteLine("Mortgage for company, interest for 6 months: {0:c}", mortgageCompany.CalculateInterest(6));
        }

    }
}
