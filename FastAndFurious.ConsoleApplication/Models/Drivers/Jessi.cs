using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;
using FastAndFurious.ConsoleApplication.Common.Enums;

namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class Jessi : Driver
    {
        public const string JessiDriver = "Jessi";
        public Jessi() : base(JessiDriver, GenderType.Female)
        {
        }
    }
}
