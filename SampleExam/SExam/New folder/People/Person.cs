using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExam
{
   public class Person
    {
        private decimal salary;
        public Person(decimal salary)
        {
            this.Salary = salary;
        }
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            private set
            {
                this.salary = value;
            }
        }
    }
}

