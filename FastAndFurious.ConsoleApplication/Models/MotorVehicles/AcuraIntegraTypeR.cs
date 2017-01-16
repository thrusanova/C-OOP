using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ($24999,1700000,200,15)
namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    public class AcuraIntegraTypeR : MotorVehicle
    {
        private const decimal price = 24999;
        private const int weight = 1700000;
        private const int acceleration = 200;
        private const int topSpeed = 15;

        public AcuraIntegraTypeR() : base(price, weight, acceleration, topSpeed)
        {
        }
    }
}
