
using System;
using System.Text;

namespace WildFarm
{
    public abstract class Mammal : Animal
    {
        public string region;
        protected Mammal(string animalName, string animalType, double animalWeight, string region)
           : base(animalName, animalType, animalWeight)
        {
            this.Region = region;
        }
        protected string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                Console.WriteLine($"{this.AnimalType}s are not eating that type of food!");
            }
            else
            {
                base.FoodEaten += food.quantity;
            }

        }

        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.Animalweight}, {this.region}, {this.FoodEaten}]";
        }
    }
}
