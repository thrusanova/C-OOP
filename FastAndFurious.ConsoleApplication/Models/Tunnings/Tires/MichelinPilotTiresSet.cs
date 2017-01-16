using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Tires.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Tires
{
    public class MichelinPilotTiresSet : TiresSet, ITunningPart, ITireSet, IAccelerateable, ITopSpeed, IWeightable, IValuable 
    {
        private const int weight = 6500;
        private const int acceleration = 7;
        private const int topSpeed = 1;
        private const decimal price = 1399;

        public MichelinPilotTiresSet() : base(price, weight, acceleration, topSpeed, TunningGradeType.HighGrade, TireType.PerformanceTire)
        {
        }
    }
}
