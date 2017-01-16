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
    public class VortexR35SequentialTurbocharger : Turbocharger, ITurbocharger
    {
        private const int weight = 3900;
        private const int acceleration = 10;
        private const int topSpeed = 85;
        private const decimal price = 699;

        public VortexR35SequentialTurbocharger()
            : base(
                  price,
                  weight,
                  acceleration,
                  topSpeed,
                  TunningGradeType.HighGrade,
                  TurbochargerType.SequentialTurbo)
        {
        }
    }
}
