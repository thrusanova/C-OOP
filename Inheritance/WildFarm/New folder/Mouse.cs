using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, string region)
            : base(animalName, animalType, animalWeight, region)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                Console.WriteLine($"{this.AnimalType}s are not eating that type of food!");
            }
            else
            {
                Console.WriteLine("A cheese was just eaten!");
                base.FoodEaten += food.quantity;
            }

        }
        public override void MakeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }
    }
}
