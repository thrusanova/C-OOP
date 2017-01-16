using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Tiger : Felime
    {
        public Tiger(string animalName, string animalType, double animalWeight, string region) 
            : base(animalName, animalType, animalWeight, region)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }
        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                Console.WriteLine($"{this.AnimalType}s are not eating that type of food!");
            }
            else
            {
                base.FoodEaten += food.quantity;
            }

        }
    }
}
