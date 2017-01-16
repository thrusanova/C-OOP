using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Tires.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Tires
{
    public class YokohamaAdvanTiresSet : TiresSet, ITunningPart, ITireSet, IAccelerateable, ITopSpeed, IWeightable, IValuable 
    {
        private const int weight = 6600;
        private const int acceleration = 5;
        private const int topSpeed = 1;
        private const decimal price = 589;

        public YokohamaAdvanTiresSet() : base(price, weight, acceleration, topSpeed, TunningGradeType.MidGrade, TireType.AllTerrainTire)
        {
        }
    }
}
