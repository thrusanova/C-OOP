using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCallories
{
    public class Dough
    {
        private const int CALORIE_PER_GRAM = 2;
        private string flourType;
        private string bakingTecniques;
        private double weight;

        public Dough(string flourType, string bakingTechiques, double weight)
        {
            this.FlourType = flourType;
            this.BakingTecniques = bakingTechiques;
            this.Weight = weight;
        }

        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            set

            {
                if (value.ToLower() != "wholegrain" && value.ToLower() != "white")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }

        public string BakingTecniques
        {
            get
            {
                return this.bakingTecniques;
            }

            set
            {
                if (value.ToLower()!= "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTecniques = value;
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
                if (value<1 || value>200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }
      
        public double CalcCalories(Dough dough)
        {
            double result = 2 * weight;
            switch (this.flourType)
            {
                case "wholegrain":result *= 1.0;break;
                case "white": result *= 1.5; break;
            }
            switch (this.bakingTecniques)
            {
                case "crispy": result *= 0.9;break;
                case "chewy": result *= 1.1; break;
                case "homemade": result *= 1.0; break;
            }
            return result;
        }
    }
}
