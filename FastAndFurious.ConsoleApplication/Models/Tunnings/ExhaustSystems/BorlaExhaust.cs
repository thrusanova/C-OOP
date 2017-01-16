using FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastAndFurious.ConsoleApplication.Common.Enums;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems
{
    public class BorlaExhaust : Exhaust
    {
        private const int weight = 14600;
        private const int acceleration = 12;
        private const int topSpeed = 40;
        private const decimal price = 1299;
        public BorlaExhaust() : base(price, weight, acceleration, topSpeed, TunningGradeType.HighGrade, ExhaustType.CeramicCoated)
        {
        }
    }
}
