using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;
using FastAndFurious.ConsoleApplication.Common.Enums;

namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class Mia : Driver
    {
        public const string MiaDriver = "Jessi";
        public Mia() : base(MiaDriver, GenderType.Female)
        {
        }
    }
}
