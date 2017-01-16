using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCallories
{
  public class Topping
    {
        private const int CALORIE_PER_GRAM = 2;
        private string toppingType;
        private double weight;

        public Topping(string toppingType, double weight)
        {
            this.ToppingType = toppingType;
            this.Weight = weight;
        }

        public string ToppingType
        {
            get
            {
                return this.toppingType;
            }
            set
            {
                string st = value;
                if (value.ToLower()!= "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce") 
                {
                    throw new ArgumentException($"Cannot place {st} on top of your pizza.");
                }
                this.toppingType = value;
            }
        }
        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.toppingType} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        public double CalcCalories(Topping topping)
        {
            double res = 2 * this.weight;
            switch (this.toppingType)
            {
                case"meat":res *= 1.2;break;
                case "veggies":res *= 0.8;break;
                case "cheese":res *= 1.1;break;
                case "sauce": res *= 0.9; break;
            }
            return res;
        }
    }
}
