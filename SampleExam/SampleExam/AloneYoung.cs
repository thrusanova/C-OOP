
namespace SampleExam
{
    public class AloneYoung : Person
    {
        public decimal laptopCost;
        public AloneYoung(decimal salary,int rooms, decimal roomElecticity, decimal laptopCost) : base(salary,rooms, roomElecticity)
        {
            this.LaptopCost = laptopCost;
        }
        public decimal LaptopCost { get; private set; }
    }
}
