using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;
using FastAndFurious.ConsoleApplication.Common.Enums;
namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class LetiSpaghetti : Driver
    {
        private const string LetiSpaghettiDriver = "Leti Spaghetti";

        public LetiSpaghetti() : base(LetiSpaghettiDriver, GenderType.Female)
        {
        }
    }
}
