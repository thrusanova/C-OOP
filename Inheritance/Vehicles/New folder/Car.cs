using System;

namespace Vehicles
{
  public class Car:Vehicle
    {

        public Car(double fuel,double fuelConsumption,double tankCapacity) :base(fuel,fuelConsumption, tankCapacity)
        {
            this.FuelConsumption+=0.9d;
            this.TankCapaciry = tankCapacity;
           

        }
        public override void Drive(double distance)
        {
            if (this.FuelConsumption*distance<=this.Fuel)
            {
                Console.WriteLine($"Car travelled {distance} km");
                this.Fuel -= this.FuelConsumption * distance;
            }
            else
            {
                Console.WriteLine($"Car needs refueling");
            }
            
        }

        public override void Refuel(double litres)
        {
            if (this.Fuel + litres > this.TankCapaciry)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else
            {
                base.Fuel += litres;
            }
        }
    }
}
