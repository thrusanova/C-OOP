using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuel, double fuelConsumption,double tankCapacity) : base(fuel, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += 1.6d;
        }

        public override void Drive(double distance)
        {

            if (this.FuelConsumption * distance <= this.Fuel)
            {
                Console.WriteLine($"Truck travelled {distance} km");
                this.Fuel -= this.FuelConsumption * distance;
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
            }
        }

        public override void Refuel(double litres)
        {
            this.Fuel += 0.95 * litres;
        }
    }
}
