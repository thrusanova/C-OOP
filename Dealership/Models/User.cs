
namespace Dealership.Models
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using Common.Enums;
    using Common;
    using System.Text;
    public class User : IUser
    {
        private string firstName;
        private string lastName;
        private string password;
        public string username;
        public User(string username, string firstName,string lastName, string password,Role role)
        {
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.Role = role;
            this.Vehicles = new List<IVehicle>();
            this.ValidateUsers();
        }

        private void ValidateUsers()
        {
            Validator.ValidateNull(this.username, string.Format(Constants.PropertyCannotBeNull, "Username"));
            Validator.ValidateSymbols(this.username,Constants.UsernamePattern, string.Format(Constants.InvalidSymbols, "Username"));
            Validator.ValidateIntRange(this.username.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Username", Constants.MinNameLength, Constants.MaxNameLength));
            Validator.ValidateNull(this.firstName, string.Format(Constants.PropertyCannotBeNull, "First name"));
            Validator.ValidateIntRange(this.firstName.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Firstname", Constants.MinNameLength, Constants.MaxNameLength));
            Validator.ValidateNull(this.lastName, string.Format(Constants.PropertyCannotBeNull, "Last name"));
            Validator.ValidateIntRange(this.lastName.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Lastname", Constants.MinNameLength, Constants.MaxNameLength));
            Validator.ValidateNull(this.password, string.Format(Constants.PropertyCannotBeNull, "Password"));
            Validator.ValidateSymbols(this.password, Constants.PasswordPattern, string.Format(Constants.InvalidSymbols, "Password"));
            Validator.ValidateIntRange(this.password.Length, Constants.MinPasswordLength, Constants.MaxPasswordLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Password", Constants.MinPasswordLength, Constants.MaxPasswordLength));
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
        }

        public Role Role { get; private set; }

        public string Username
        {
            get
            {
                return this.username;
            }
        }

        public IList<IVehicle> Vehicles { get; private set; }
      
        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            Validator.ValidateNull(commentToAdd,string.Format(Constants.CommentCannotBeNull));
            Validator.ValidateNull(vehicleToAddComment, string.Format(Constants.VehicleCannotBeNull));
            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            Validator.ValidateNull(vehicle, string.Format(Constants.VehicleCannotBeNull));
            if (this.Role==Role.Normal && this.Vehicles.Count>=5)
            {
                throw new ArgumentException(string.Format(Constants.NotAnVipUserVehiclesAdd, Constants.MaxVehiclesToAdd));
            }
            if (this.Role==Role.Admin)
            {
                throw new ArgumentException(string.Format(Constants.AdminCannotAddVehicles));
            }
            this.Vehicles.Add(vehicle);
            
        }

        public string PrintVehicles()
        {
            var sb = new StringBuilder();
            int count = 1;
            sb.AppendLine(string.Format("--USER {0}--",this.username));
            if (this.Vehicles.Count<=0)
            {
                sb.AppendLine("--NO COMMENTS--");
            }
            else
            {
                foreach (var v in this.Vehicles)
                {
                    sb.AppendLine(string.Format("{0}. {1}",count,v.ToString()));
                    count++;
                }
            }
            return sb.ToString().Trim();
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            Validator.ValidateNull(commentToRemove, string.Format(Constants.CommentCannotBeNull));
            Validator.ValidateNull(vehicleToRemoveComment, string.Format(Constants.VehicleCannotBeNull));
            if (this.Username!=commentToRemove.Author)
            {
                throw new ArgumentException(Constants.YouAreNotTheAuthor);
            }
            vehicleToRemoveComment.Comments.Remove(commentToRemove);
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            Validator.ValidateNull(vehicle, string.Format(Constants.VehicleCannotBeNull));
            Vehicles.Remove(vehicle);
        }

        public override string ToString()
        {
            return string.Format(Constants.UserToString, this.Username, this.FirstName, this.LastName, this.Role);
        }
    }
}
