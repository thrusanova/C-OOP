using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    public class NissanGTR : MotorVehicle
    {
        private const decimal price = 125000;
        private const int weight = 185000;
        private const int acceleration = 300;
        private const int topSpeed = 45;

        public NissanGTR() : base(price, weight, acceleration, topSpeed)
        {
        }
    }
}
