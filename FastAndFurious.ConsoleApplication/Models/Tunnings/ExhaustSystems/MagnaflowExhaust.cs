
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems
{
    public class MagnaflowExhaust : Exhaust
    {

        private const int weight = 12800;
        private const int acceleration = 5;
        private const int topSpeed = 25;
        private const decimal price = 379;

        public MagnaflowExhaust() : base(price, weight, acceleration, topSpeed, TunningGradeType.LowGrade, ExhaustType.NickelChromePlated)
        {
        }
    }
}
