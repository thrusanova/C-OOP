using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = null;
            Food food = null;
            string input = Console.ReadLine();
            //string foods = Console.ReadLine();
            while (input != "End")
            {
                string[] line = input.Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                string[] str = Console.ReadLine().Split(' ');
                string type = line[0];
                string name = line[1];
                double weight = double.Parse(line[2]);
                string region = line[3];
                switch (type.ToLower())
                {
                    case "cat":
                        string breed = line[4];
                        animal = new Cat(name, type, weight, region, breed);break;
                    case "mouse":
                        animal = new Mouse(name, type, weight, region); break;
                    case "tiger":
                        animal = new Tiger(name, type, weight, region); break;
                    case "zebra":
                        animal = new Zebra(name, type, weight, region); break;
                }
              
                var vg = str[0];
                int r = int.Parse(str[1]);
                if (vg=="Meat")
                {
                    food = new Meat(r);
                }
                else
                {
                    food = new Vegetable(r);
                }
                animal.MakeSound();
                animal.Eat(food);
                Console.WriteLine(animal);
                input = Console.ReadLine();
                
            }

          
           

        }
    }
}
