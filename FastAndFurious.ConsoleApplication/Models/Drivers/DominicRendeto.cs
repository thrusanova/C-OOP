using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;

namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class DominicRendeto : Driver,IDriver
    {
        private const string DominicRendetoDriver = "Dominic Rendeto";

        public DominicRendeto() : base(DominicRendetoDriver, GenderType.Male)
        {

        }
    }
}
