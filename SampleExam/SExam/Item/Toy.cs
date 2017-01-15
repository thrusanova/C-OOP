using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SExam.Item
{
  public class Toy
    {
        private decimal toyCost;
        public Toy(decimal toyCost)
        {
            this.ToyCost = toyCost;
        }
        public decimal ToyCost

        {
            get
            {
                return this.toyCost;
            }
                 private set
            {
                this.toyCost = value;
            }
        }

    }
}
