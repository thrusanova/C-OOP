
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
  public class Car
    {
        private int speed;
        private double fuel;
        private double fuelPerKm;
        public double distance;

        public Car (int speed,double fuel,double fuelPerKm)
        {
            this.speed = speed;
            this.fuel = fuel;
            this.fuelPerKm = fuelPerKm;
            this.distance = 0;
        }

        public int Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                this.speed = value;
            }
        }

        public double Fuel
        {
            get
            {
                return this.fuel;
            }
            set
            {
                this.fuel = value;
            }
        }
        public double FuelKm
        {
            get
            {
                return this.fuelPerKm;
            }
            set
            {
                this.fuelPerKm = value;
            }
        }
        public void TotalDistance(double dist)
        {
            double kmPerLt = this.speed / this.fuelPerKm;
            double kmforMove = kmPerLt * this.fuel;
            if (kmforMove>=dist)
            {
                this.distance += dist;
                this.fuel -= dist / kmPerLt;
            }
            else
            {
                this.distance += kmforMove;
                this.fuel = 0;
            }
        }
        public double getTravelTime()
        {
            double hoursAndMinutes = (this.distance / this.speed) * 60;
            return hoursAndMinutes;
        }
     public int Hours()
        {
            int hours = (int)this.getTravelTime()/60;

            return hours;
        }
        

         public int Minutes()
        {
        int minutes = (int)this.getTravelTime() % 60;
            return minutes;
    }

        public void Refuel(double moreFuel)
        {
            this.fuel= (this.Fuel + moreFuel);
        }

    }
}
