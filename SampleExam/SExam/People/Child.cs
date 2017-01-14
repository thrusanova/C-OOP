
using SExam.Item;
using System.Collections.Generic;

namespace SampleExam
{
    public class Child 
    {
        private decimal foodCost;
        private List<Toy> toys;
        public Child()
        {
        }
        public Child(decimal foodCost)
        {
            this.FoodCost = foodCost;
            this.toys = new List<Toy>();
        }
        public decimal FoodCost { get;private set; }

        public void addToys(Toy toy)
        {
            this.toys.Add(toy);
        }
        public decimal calculateToyPrice()
        {
            decimal toyPrice = 0;
            foreach (var cost in toys)
            {
                toyPrice += cost.ToyCost;
            }
            return toyPrice;
        }
    }
}
