using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;
using FastAndFurious.ConsoleApplication.Common.Enums;

namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class Vince : Driver
    {
        public const string VinceDriver = "Jessi";
        public Vince() : base(VinceDriver, GenderType.Male)
        {
        }
    }
}
