using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Bus : Vehicle
    {
      
        public Bus(double fuel, double fuelConsumption,double tankCapacity) : base(fuel, fuelConsumption,tankCapacity)
        {
            this.FuelConsumption += 1.4;
        }

        public override void Drive(double distance)
        {
            if (this.FuelConsumption * distance <= this.Fuel)
            {
                Console.WriteLine($"Bus travelled {distance} km");
                this.Fuel -= this.FuelConsumption * distance;
            }
            else
            {
                Console.WriteLine($"Bus needs refueling");
            }
        }

        public override void Refuel(double litres)
        {
            if (base.Fuel+litres>base.TankCapaciry)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else
            {
                base.Fuel += litres;
            }
        }
        public void ConditionOf()
        {
            this.FuelConsumption -= 1.4d;
        }
    }
}
