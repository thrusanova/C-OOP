using FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastAndFurious.ConsoleApplication.Common.Enums;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems
{

    public class RemusExhaust : Exhaust
    {

        private const int weight = 11500;
        private const int acceleration = 8;
        private const int topSpeed = 32;
        private const decimal price = 679;

        public RemusExhaust() : base(price, weight, acceleration, topSpeed, TunningGradeType.MidGrade, ExhaustType.StainlessSteel)
        {
        }
    }
}
