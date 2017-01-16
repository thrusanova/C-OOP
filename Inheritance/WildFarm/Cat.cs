using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Cat : Felime
    {
        private string breed;
        public Cat(string animalName, string animalType, double animalWeight,string region,string breed)
            : base(animalName,animalType,animalWeight,region)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get
            {
                return this.breed;
            }
            set
            {
                this.breed = value;
            }
        }
        public override void Eat(Food food)
        {
            base.FoodEaten += food.quantity;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }
        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.Breed}, {this.Animalweight}, {this.region}, {this.FoodEaten}]";
        }
    }
}
