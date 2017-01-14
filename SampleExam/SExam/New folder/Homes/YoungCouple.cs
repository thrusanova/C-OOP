using SampleExam;
using SExam.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SExam.Homes
{
    public class YoungCouple : Home
    {
        public  const int NUMBERS_OF_ROOMS = 2;
        public const int ELECTRICITY_COST = 20;
        public YoungCouple(decimal maleSalary,decimal femaleSalary,decimal tv,decimal fridge,decimal laptop) : base(NUMBERS_OF_ROOMS, ELECTRICITY_COST)
        {
            this.people.Add(new Person(maleSalary));
            this.people.Add(new Person(femaleSalary));
            this.devices.Add(new Device(tv));
            this.devices.Add(new Device(fridge));
            this.devices.Add(new Device(laptop));
            this.devices.Add(new Device(laptop));
        }

        public YoungCouple()
        {
        }
    }
}
