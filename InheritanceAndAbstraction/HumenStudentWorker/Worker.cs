using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumenStudentWorker
{
    class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;

        public Worker(int weekSalary, int workHoursPerDay, string firstName, string lastName) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Week salary cannot be negative or zero");
                }
                else
                {
                    this.weekSalary = value;
                }
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Work hours per day cannot be negative or zero");
                }
                else
                {
                    this.workHoursPerDay = value;
                }
            }
        }

        public double MoneyPerHour()
        {
            return (double)this.weekSalary / this.workHoursPerDay;
        }

        public override string ToString()
        {
            return "First name: " + this.FirstName + "\nLast name: " + this.LastName + "\nWeek salary: " + this.WeekSalary + "\nWork hours per week: " + this.WorkHoursPerDay + "\nMoney per hour: " + this.MoneyPerHour().ToString("0.##") + " leva\n";
        }
    }
}
