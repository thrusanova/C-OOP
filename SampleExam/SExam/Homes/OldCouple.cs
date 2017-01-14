using SampleExam;
using SExam.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SExam.Homes
{
  public class OldCouple:Home
    {
        public const int NUMBERS_OF_ROOMS = 3;
        public const int ELECTRICITY_COST = 15;
        public OldCouple(decimal maleSalary, decimal femaleSalary, decimal tv, decimal fridge, decimal stove) : base(NUMBERS_OF_ROOMS, ELECTRICITY_COST)
        {
            this.people.Add(new Person(maleSalary));
            this.people.Add(new Person(femaleSalary));
            this.devices.Add(new Device(tv));
            this.devices.Add(new Device(fridge));
            this.devices.Add(new Device(stove));
        }

        public OldCouple()
        {
        }
    }
}
