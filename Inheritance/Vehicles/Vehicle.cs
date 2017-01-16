using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
   public abstract class Vehicle
    {
        private double fuel;
        private double fuelConsumption;
        private double tankCapaciry;

        public Vehicle(double fuel,double fuelConsumption,double tankCapacity)
        {
            this.Fuel = fuel;
            this.FuelConsumption = fuelConsumption;
            this.TankCapaciry = tankCapaciry;
        } 
        public double Fuel
        {
            get
            {
                return this.fuel;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }               
                this.fuel = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }

        public double TankCapaciry
        {
            get
            {
                return this.tankCapaciry;
            }
             set
            {
                this.tankCapaciry = value;
            }
        }

        public abstract void Drive(double distance);

        public abstract void Refuel(double litres);

    }
}
