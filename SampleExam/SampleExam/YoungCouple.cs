
namespace SampleExam
{
    public class YoungCouple : Couple
    {
        public const decimal roomCost = 20;
        public const int rooms = 2;
        private decimal laptopCost;
        public YoungCouple(decimal salaryFather, decimal salaryMother, decimal tvCost, decimal fridgeCost,decimal laptopCost) : base(salaryFather,salaryMother,rooms, roomCost, tvCost, fridgeCost)
        {
            this.LaptopCost = laptopCost;
            
        }
        public decimal LaptopCost { get; private set; }
        public override decimal Consumption()
        {
            return base.Consumption();
            
        }
        public override int Population()
        {
            return 1 + base.Population();
        }
    }
}
