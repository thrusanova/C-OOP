using System;

namespace Cart
{
    public class Car
    {
        private int speed;
        private double fuel;
        private double fuelPerKm;
        public double distance;

        public Car(int speed, double fuel, double fuelPerKm)
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
            if (kmforMove >= dist)
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
            int hours = (int)this.getTravelTime() / 60;

            return hours;
        }


        public int Minutes()
        {
            int minutes = (int)this.getTravelTime() % 60;
            return minutes;
        }

        public void Refuel(double moreFuel)
        {
            this.fuel = (this.Fuel + moreFuel);
        }

    }
    class Program
    {
        static void Main(string[] args)
      
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int speed = int.Parse(input[0]);
            double fuel = double.Parse(input[1]);
            double fuelKm= double.Parse(input[2]);

            var car = new Car(speed, fuel, fuelKm);
            string line = Console.ReadLine();
            while (line!="END")
            {
                string[] command = line.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                //  double distance = double.Parse(km[1]);
                switch (command.Length)
                {
                    case 1:string word = command[0];
                        switch (word)
                        {
                            case "Distance": Console.WriteLine($"Total distance: {car.distance:F1} kilometers");break;
                            case "Time": Console.WriteLine($"Total time: {car.Hours()} hours and {car.Minutes()} minutes");break;
                            case "Fuel": Console.WriteLine($"Fuel left: {car.Fuel:F1} liters");break;
                        }
                        break;
                    case 2:string resourse = command[0];
                        double amount = double.Parse(command[1]);
                        switch (resourse)
                        {
                            case "Travel":car.TotalDistance(amount);break;
                            case "Refuel":car.Refuel(amount);break;
                        }
                        break;
                }
                line = Console.ReadLine();
            }
          
        }
    }
}
