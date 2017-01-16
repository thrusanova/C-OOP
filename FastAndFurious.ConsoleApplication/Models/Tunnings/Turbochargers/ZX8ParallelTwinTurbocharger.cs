using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers
{
    public class ZX8ParallelTwinTurbocharger : Turbocharger, ITurbocharger, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        private const int weigth = 3500;
        private const int acceleration = 15;
        private const int topSpeed = 60;
        private const decimal price = 799;

        public ZX8ParallelTwinTurbocharger()
            : base(
                  price,
                  weigth,
                  acceleration,
                  topSpeed,
                  TunningGradeType.HighGrade,
                  TurbochargerType.TwinTurbo)
        {
        }
    }
}