
namespace Dealership.Models
{
    using System.Text;
    using Common.Enums;
    using Contracts;
    using Common;
    public class Truck : Vehicle,IVehicle,ITruck
    {
        private int weightCapacity; 

        public Truck(string make, string model, decimal price,int weightCapacity) : base(make, model, price, VehicleType.Truck)
        {
            this.WeightCapacity = weightCapacity;
            ValidateCapacity();
        }

        public int WeightCapacity
        {
            get
            {
                return this.weightCapacity;
            }
            private set
            {
                this.weightCapacity = value;
            }
        }


        private void ValidateCapacity()
        {
            Validator.ValidateIntRange(this.weightCapacity, Constants.MinCapacity, Constants.MaxCapacity, string.Format(Constants.NumberMustBeBetweenMinAndMax, "Weight capacity",Constants.MinCapacity,Constants.MaxCapacity));
        }
        public override string ToString()

        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append(string.Format("  Weight capacity: {0}", this.WeightCapacity));
            return sb.ToString();
        }

    }
}
