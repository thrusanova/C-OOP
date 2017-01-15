
namespace Dealership.Models
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using Common.Enums;
    using System.Text;
    using Common;
    public class Car :Vehicle, IVehicle,ICar
    {
        private int seats;

        public Car(string make, string model, decimal price,int seats) : base(make,model,price,VehicleType.Car)
        { 
            this.seats = seats;
            ValidateSeats();
        }

        public int Seats { get; private set; }

        private void ValidateSeats()
        {
            Validator.ValidateIntRange(this.seats, Constants.MinSeats, Constants.MaxSeats, string.Format(Constants.NumberMustBeBetweenMinAndMax, "Seats",Constants.MinSeats,Constants.MaxSeats));
        }
        public override string ToString()

        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append(string.Format("  Seats: {0}", this.seats));
            return sb.ToString();
        }


    }
}
