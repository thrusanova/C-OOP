namespace SampleExam
{
    public class OldCouple : Couple
    {
        private decimal stoveCost;
        public OldCouple(decimal salaryFather, decimal salaryMother, int rooms, decimal roomElectricity, decimal tvCost, decimal fridgeCost, decimal stoveCost, decimal salary) : base(salaryFather,salaryMother,rooms, roomElectricity, tvCost, fridgeCost)
        {
            this.StoveCost = stoveCost;
        }
        public decimal StoveCost { get; private set; }
    }
}
