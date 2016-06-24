using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Worker : Human
    {
        public Worker(string firstName, string lastName, double weekSalary) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = 8;
        }

        public double WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        public double MoneyPerHour()
        {
            return this.WeekSalary / (5 * this.WorkHoursPerDay);
        }
    }
}
