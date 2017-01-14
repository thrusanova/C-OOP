using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
   public class Worker:Human
    {
        private decimal salary;
        private double workingHours;

        public Worker(string firstName,string lastName,decimal salary,double workingHoursPerDay):
            base(firstName, lastName)
        {
            this.Salary = salary;
            this.WorkingHours = workingHoursPerDay;
        }

        public decimal Salary
        {
            get {
                return this.salary;
            }
                private set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.salary = value;
            }
        }
        public double WorkingHours
        {
            get
            {
                return this.workingHours;
            }
            private set
            {
                if (value<1 || value>12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workingHours = value;
            }
        }

        public double calculateSalary()
        {
            var resl = (this.salary / 5);
          var res=(double)resl  / this.workingHours;
            return res;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstNamme}");
            sb.AppendLine($"Last Name: {this.LastNamme}");
            sb.AppendLine($"Week Salary: {this.salary:F2}");
            sb.AppendLine($"Hours per day: {this.workingHours:F2}");
            sb.AppendLine($"Salary per hour: {this.calculateSalary():F2}");
            return sb.ToString();
        }
    }
}
