using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Tires.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Tires
{
    public class FalkenAzenisTiresSet : TiresSet, ITunningPart, ITireSet, IAccelerateable, ITopSpeed, IWeightable, IValuable 
    {
        private const int weight = 7800;
        private const int acceleration = 3;
        private const int topSpeed = 0;
        private const decimal price = 359;

        public FalkenAzenisTiresSet() : base(price, weight, acceleration, topSpeed, TunningGradeType.LowGrade, TireType.OffRoadTire)
        {
        }
    }
}
