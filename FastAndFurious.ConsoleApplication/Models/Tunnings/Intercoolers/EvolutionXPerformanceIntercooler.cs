using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Intercoolers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Intercoolers
{
    public class EvolutionXPerformanceIntercooler : Intercooler, IIntercooler, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private const int weight = 4500;
        private const int acceleration = -5;
        private const int topSpeed = 40;
        private const decimal price = 499;

        public EvolutionXPerformanceIntercooler()
            : base(
                  price,
                  weight,
                  acceleration,
                  topSpeed,
                  TunningGradeType.HighGrade,
                  IntercoolerType.AirToLiquidIntercooler)
        {
        }
    }
}
