using SampleExam;
using SExam.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SExam.Homes
{
 public class AloneYoung:Home
    {
        public const int NUMBERS_OF_ROOMS = 1;
        public const int ELECTRICITY_COST = 10;
        public AloneYoung(decimal salary, decimal laptop) : base(NUMBERS_OF_ROOMS, ELECTRICITY_COST)
        {
            this.people.Add(new Person(salary));
            this.devices.Add(new Device(laptop));
        }

        public AloneYoung()
        {
        }
    }
}
