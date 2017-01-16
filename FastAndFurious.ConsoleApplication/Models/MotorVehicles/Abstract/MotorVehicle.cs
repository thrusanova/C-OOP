using System;
using System.Collections.Generic;
using System.Linq;
using FastAndFurious.ConsoleApplication.Common.Constants;
using FastAndFurious.ConsoleApplication.Common.Exceptions;
using FastAndFurious.ConsoleApplication.Common.Utils;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Common;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract
{
    public abstract class MotorVehicle : IdentifiableObject, IMotorVehicle, IWeightable, IValuable,IIdentifiable
    {
        private decimal price;
        private int weight;
        private int acceleration;
        private int topSpeed;
        private ICollection<ITunningPart> tunningParts;

        public MotorVehicle(decimal price,int weight,int acceleration,int topSpeed):base()
        {
            this.price = price;
            this.weight = weight;
            this.acceleration=acceleration;
            this.topSpeed = topSpeed;
            this.tunningParts = new List<ITunningPart>();
        }

        public decimal Price
        {
            get
            {
                return this.price + this.TunningParts.Sum(x => x.Price);
            }
        }
        public int Weight
        {
            get
            {
                return this.weight + this.TunningParts.Sum(x => x.Weight);
            }
        }
        public int Acceleration
        {
            get
            {
                return this.acceleration + this.TunningParts.Sum(x => x.Acceleration);
            }
        }
        public int TopSpeed
        {
            get
            {
                return this.topSpeed + this.TunningParts.Sum(x => x.TopSpeed);
            }
        }
        public IEnumerable<ITunningPart> TunningParts
        {
            get
            {
                return this.tunningParts;
            }
        }


        public void AddTunning(ITunningPart part)
        {
            this.tunningParts.Add(part);
        }
        public TimeSpan Race(int trackLengthInMeters)
        {
            // Oohh boy, you shouldn't have missed the PHYSICS class in high school.
            throw new NotImplementedException();
        }
        public bool RemoveTunning(ITunningPart part)
        {
           return this.tunningParts.Remove(part);
        }
    }
}
