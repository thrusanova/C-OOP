using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExam
{
    public class YoungCoupleWithChildren : Couple
    {
      
        private decimal toyCost;
        private List<Child> children;
        public YoungCoupleWithChildren(decimal salaryFather, decimal salaryMother, decimal tvCost, decimal fridgeCost, decimal salary,decimal toyCost,List<Child> children) : base(salaryFather,salaryMother, rooms, roomCost, tvCost, fridgeCost)
        {
            this.ToyCost = toyCost;
            this.children = new List<Child>();
            
        }

        public decimal ToyCost { get; private set; }

        public void AddChildren(Child child)
        {
            children.Add(child);
        }
        public override int Population()
        {
            return base.Population() + children.Count;
        }
        public override decimal Consumption()
        {
            return base.Consumption();
        }
    }
}
