
namespace Dealership.Models
{
    using System.Text;
    using Common.Enums;
    using Contracts;
    using Common;

    public class Motorcycle : Vehicle,IVehicle,IMotorcycle
    {
        private string category;
        public Motorcycle(string make, string model, decimal price,string category) : base(make, model, price, VehicleType.Motorcycle)
        {    
            this.category = category;
            ValidateCategory();
        }
        private void ValidateCategory()
        {
            Validator.ValidateNull(this.category, string.Format(Constants.PropertyCannotBeNull, "Category"));
            Validator.ValidateIntRange(this.category.Length, Constants.MinCategoryLength, Constants.MaxCategoryLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Category",Constants.MinCategoryLength,Constants.MaxCategoryLength));
        }

        public string Category { get; private set; }

        public override string ToString()
       
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append(string.Format("  Category: {0}", this.category));
            return sb.ToString();
        }

    }
}
