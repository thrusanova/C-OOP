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
    public class ViperGenieIntercooler : Intercooler, IIntercooler, ITunningPart, IWeightable
    {
        private const int weight = 5300;
        private const int acceleration = 0;
        private const int topSpeed = 25;
        private const decimal price = 289;

        public ViperGenieIntercooler()
            : base(
                  price,
                  weight,
                  acceleration,
                  topSpeed,
                  TunningGradeType.MidGrade,
                  IntercoolerType.ChargeAirIntercooler)
        {
        }
    }
}
