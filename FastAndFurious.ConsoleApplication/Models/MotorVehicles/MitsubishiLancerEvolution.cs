using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    public class MitsubishiLancerEvolution : MotorVehicle
    {
        private const decimal price = 56999;
        private const int weight = 1780000;
        private const int acceleration = 300;
        private const int topSpeed = 20;

        public MitsubishiLancerEvolution() : base(price, weight, acceleration, topSpeed)
        {
        }
    }
}
