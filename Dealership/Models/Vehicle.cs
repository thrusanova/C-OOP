namespace Dealership
{
    using Contracts;
    using System.Text;
    using Common.Enums;
    using System.Collections.Generic;
    using Common;
    using System;

    public abstract class Vehicle : IVehicle
    {
        private string make;

        private string model;

        private int wheelcount;

        private decimal price;

        public Vehicle(string make, string model, decimal price, VehicleType type)
        {
            this.make = make;
            this.model = model;
            this.wheelcount = (int)type;
            this.price = price;
            this.Comments = new List<IComment>();
            ValidateFields();
        }

        private void ValidateFields()
        {
            Validator.ValidateNull(this.make, string.Format(Constants.PropertyCannotBeNull, "Make"));
            Validator.ValidateIntRange(this.make.Length, Constants.MinMakeLength, Constants.MaxMakeLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Make", Constants.MinMakeLength, Constants.MaxMakeLength));
            Validator.ValidateNull(this.model, string.Format(Constants.PropertyCannotBeNull, "Model"));
            Validator.ValidateIntRange(this.model.Length, Constants.MinModelLength, Constants.MaxModelLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Model", Constants.MinModelLength, Constants.MaxModelLength));
            Validator.ValidateIntRange(this.wheelcount, Constants.MinWheels, Constants.MaxWheels, string.Format(Constants.NumberMustBeBetweenMinAndMax, "Wheels", Constants.MinWheels, Constants.MaxWheels));
            Validator.ValidateDecimalRange(this.price, Constants.MinPrice, Constants.MaxPrice, string.Format(Constants.NumberMustBeBetweenMinAndMax, "Price", Constants.MinPrice, Constants.MaxPrice));
        }

        public string Model
        {
            get
            {
                return this.model;
            }
       
        }

        public string Make
        {
            get
            {
                return this.make;
            }
         
        }

        public int Wheels
        {
            get
            {
                return this.wheelcount;
            }
         
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
           
        }

        public VehicleType Type { get; private set; }

        public IList<IComment> Comments { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("{0}:", this.GetType().Name));
            sb.AppendLine(string.Format("  Make: {0}", this.Make));
            sb.AppendLine(string.Format("  Model: {0}", this.Model));
            sb.AppendLine(string.Format("  Wheels: {0}", this.Wheels));
            sb.Append(string.Format("  Price: ${0}", this.Price));
            return sb.ToString();
        }
    }
}
