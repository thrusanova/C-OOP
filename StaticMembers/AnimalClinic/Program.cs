using System;
using System.Collections.Generic;

namespace AnimalClinic
{
    public class Animal
    {
        private string name;
        private string breed;

        public Animal(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }

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

    }

    public class AnimalClinic
    {
        public static int patienId;
        public static int healedAnimalsCount;
        public static int rehabilitedAnimalsCount;
        public static List<Animal> healdAnimal;
        public static List<Animal> rehabilitatedAnimals;

        public AnimalClinic()
        {
            healdAnimal = new List<Animal>();
            rehabilitatedAnimals = new List<Animal>();
        }
        public void healedAnimal(Animal animal)
        {
            patienId++;
            healedAnimalsCount++;
            healdAnimal.Add(animal);
            Console.WriteLine($"Patient {patienId}: [{animal.Name} ({animal.Breed})] has been healed!");
        }

        public void rehabAnimal(Animal animal)
        {
            patienId++;
            rehabilitedAnimalsCount++;
            rehabilitatedAnimals.Add(animal);
            Console.WriteLine($"Patient {patienId}: [{animal.Name} ({animal.Breed})] has been rehabilitated!");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var clinic = new AnimalClinic();
            while (line != "End")
            {
                string[] input = line.Split(' ');
                string name = input[0];
                string breed = input[1];
                var animal = new Animal(name, breed);
                string condition = input[2];
                if (condition == "heal")
                {
                    clinic.healedAnimal(animal); 
                }
                else
                {
                    clinic.rehabAnimal(animal);
                }
                line = Console.ReadLine();
            }
            Console.WriteLine($"Total healed animals: {AnimalClinic.healedAnimalsCount}");
            Console.WriteLine($"Total rehabilitated animals: {AnimalClinic.rehabilitedAnimalsCount}");
            string word = Console.ReadLine();
            if (word=="heal")
            {
                foreach (var animal in AnimalClinic.healdAnimal)
                {
                    Console.WriteLine($"{animal.Name} {animal.Breed}");
                }
            }
            else
            {
                foreach (var animal in AnimalClinic.rehabilitatedAnimals)
                {
                    Console.WriteLine($"{animal.Name} {animal.Breed}");
                }
            }
        }
    }
}