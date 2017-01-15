using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//car’s Model, fuel amount, fuel cost for 1 kilometer and distance traveled
namespace SpeedRacing
{
    public class Car
    {
        public string model;
        public double fuelAmount;
        public double fuelCost;
        public int stdistance;

        public Car(string model, double fuelAmount, double fuelCost)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelCost = fuelCost;
            this.stdistance = 0;
        }
        public void Drive(int distance)
        {
            if (distance * fuelCost<=fuelAmount)
            {
               stdistance += distance;
                fuelAmount -= distance * fuelCost;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
        public class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                var list = new List<Car>();
                for (int i = 0; i < n; i++)
                {
                    string[] input = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    string model = input[0];
                    double fuelQuatity = double.Parse(input[1]);
                    double fuelPerKm = double.Parse(input[2]);
                    list.Add(new Car(model, fuelQuatity, fuelPerKm));
                }
                string lines = Console.ReadLine();
                while (lines != "End")
                {
                    string[] str = lines.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    // Ferrari - 488Spider 50 0.47
                    string model = str[1];
                    int distance = int.Parse(str[2]);
                    foreach (var car in list)
                     {
                    if (car.model==model)
                    {
                        car.Drive(distance);
                    } 
                    }
                lines = Console.ReadLine();
                }
            foreach (var car in list)
            {
                Console.WriteLine($"{car.model} {car.fuelAmount:F2} {car.stdistance}");
            }

            }
        }

    }

