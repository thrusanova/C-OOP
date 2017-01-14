
using System.Collections.Generic;

namespace SampleExam
{
    public class Child : Person
    {
        public const decimal roomCost = 30;
        public const int rooms = 2;
        private decimal foodCost;
        private List<decimal> toysCost;
        public Child(decimal foodCost, List<decimal> toysCost) : base(0,rooms, roomCost)
        {
            this.FoodCost = foodCost;
            this.ToysCost = new List<decimal>();
        }

        public decimal FoodCost { get; private set; }
        public List<decimal> ToysCost { get; private set; }
    }
}
