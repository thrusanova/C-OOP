using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles

{   
    public class NissanSkylineR34 : MotorVehicle
    {
        private const decimal price = 45999;
        private const int weight =1850000;
        private const int acceleration = 280;
        private const int topSpeed = 35;

        public NissanSkylineR34() : base(price, weight, acceleration, topSpeed)
        {
        }
    }
}
