using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCallories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private double allCalories;
        private  List<Topping> toppings;
        private int numbers;

        public Pizza(string name, int numbers)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
            this.NumberOfToppings = numbers; 

        }
       
        public Dough Dough { get; set; }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int NumberOfToppings
        {
            get
            {
                return this.numbers;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                this.numbers = value;
            }
        }

     

        public void addTopping(Topping topping)
        {
            try
            {
                this.toppings.Add(topping);
            }
            catch(System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public double AllCalories
        {
            get
            {
                return this.allCalories;
            }
            set
            {
                this.allCalories = value;
            }
        }

      

        public void addDough(Dough dough)
        {
            this.dough = dough;
        }

        public double totalCalories()
        {
            var res = 0.0;
            foreach (var top in toppings)
            {
                this.allCalories += top.CalcCalories(top);      
            }
            return this.allCalories + this.Dough.CalcCalories(dough);
        }
    }
}
