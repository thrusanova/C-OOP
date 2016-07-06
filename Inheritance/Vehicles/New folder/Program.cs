using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputCar = Console.ReadLine().Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            double fuelCar = double.Parse(inputCar[1]);
            double litresCar = double.Parse(inputCar[2]);
            double tankCar = double.Parse(inputCar[3]);
            var car = new Car(fuelCar, litresCar,tankCar);
       
            string[] inputTruck = Console.ReadLine().Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            double fuelTruck = double.Parse(inputTruck[1]);
            double litresTruck = double.Parse(inputTruck[2]);
            double tankTruck = double.Parse(inputTruck[3]);
            var truck = new Truck(fuelTruck, litresTruck,tankTruck);

            string[] inputBus = Console.ReadLine().Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            double fuelBus = double.Parse(inputBus[1]);
            double litresBus = double.Parse(inputBus[2]);
            double tankBus = double.Parse(inputBus[3]);
            var bus = new Bus(fuelBus, litresBus, tankBus);
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                string machine = input[1];
                double distance = double.Parse(input[2]);
                if (command=="Drive")
                {
                    if (machine=="Car")
                    {
                        car.Drive(distance);
                    }
                    else if(machine=="Truck")
                    {
                        truck.Drive(distance);
                    }
                    else
                    {
                        bus.Drive(distance);
                    }
                }
                else if(command=="Refuel")
                {
                    if (machine=="Car")
                    {
                        car.Refuel(distance);
                    }
                    else if(machine=="Truck")
                    {
                        truck.Refuel(distance);
                    }
                    else
                    {
                        bus.Refuel(distance);
                    }
                }
                else
                {
                    bus.ConditionOf();
                    bus.Drive(distance);
                }
            }
            Console.WriteLine($"Car: {car.Fuel:F2}");
            Console.WriteLine($"Truck: {truck.Fuel:F2}");
            Console.WriteLine($"Bus: {bus.Fuel:F2}");
        }
    }
}
