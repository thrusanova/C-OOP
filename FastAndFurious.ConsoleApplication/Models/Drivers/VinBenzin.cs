using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;
using FastAndFurious.ConsoleApplication.Common.Enums;

namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class VinBenzin : Driver
    {
        public const string VinBenzinDriver = "Vin Benzin";
        public VinBenzin() : base(VinBenzinDriver, GenderType.Male)
        {
        }
    }
}
