
namespace WildFarm
{
   public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        protected Animal(string animalName, string animalType, double animalWeight)
        {
            this.AnimalName = animalName;
            this.AnimalType = animalType;
            this.Animalweight = animalWeight;

        }

        protected virtual string AnimalName
        {
            get { return this.animalName; }
            set { this.animalName = value; }
        }

        protected virtual string AnimalType
        {
            get { return this.animalType; }
            set { this.animalType = value; }
        }

        protected virtual double Animalweight
        {
            get { return this.animalWeight; }
            set { this.animalWeight = value; }
        }

        protected virtual int FoodEaten
        {
            get { return this.foodEaten; }
            set { this.foodEaten = value; }
        }

        public abstract void MakeSound();
        public abstract void Eat(Food food);

    }
}

