using SampleExam;
using SExam.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SExam.Homes
{
    class YoungCoupleWithChildren : Home
    {
        public const int NUMBERS_OF_ROOMS = 2;
        public const int ELECTRICITY_COST = 30;
 
        public YoungCoupleWithChildren(decimal maleSalary, decimal femaleSalary, decimal tv, decimal fridge, decimal laptop,List<Child>childrens) : base(NUMBERS_OF_ROOMS, ELECTRICITY_COST)
        {
            this.people.Add(new Person(maleSalary));
            this.people.Add(new Person(femaleSalary));
            this.devices.Add(new Device(tv));
            this.devices.Add(new Device(fridge));
            this.devices.Add(new Device(laptop));
            this.devices.Add(new Device(laptop));
            foreach (var child in childrens)
            {
                this.children.Add(child);
            }
       
        }

      
    }
}
