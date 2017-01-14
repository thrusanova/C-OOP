
namespace SampleExam
{
   public class Couple:Person
    {
        private decimal tvCost;
        private decimal fridgeCost;
        private decimal salaryFather;
        private decimal salaryMother;
        public Couple(decimal salaryMother, decimal salaryFather, int rooms,decimal roomElectricity, decimal tvCost, decimal fridgeCost) : base(salaryMother,rooms, roomElectricity)
        {
            this.TvCost = tvCost;
            this.FridgeCost = fridgeCost;
            this.SalaryFather = salaryFather;
            this.SalaryMother = salaryMother;
        }
        public decimal TvCost
        {
            get
            {
                return this.tvCost;
            }
            private set
            {
                this.tvCost = value;
            }
        }

        public decimal FridgeCost
        {
            get
            {
                return this.fridgeCost;
            }
            private set
            {
                this.fridgeCost = value;
            }
        }

        public decimal SalaryFather { get; private set; }
        public decimal SalaryMother { get; private set; }
    }
}
