
namespace CarSalesman
{
   public class Engine
    {
        private string model;
        private int power;
        private string displacement;
        private string efficientcy;

        public Engine(string model,int power,string displacement,string efficiency)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficientcy = efficiency;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
            }
        }
        public string Displacement
        {
            get
            {
                return this.displacement;
            }
            set
            {
                this.displacement = value;
            }
        }
        public string Efficiency
        {
            get
            {
                return this.efficientcy;
            }
            set
            {
                this.efficientcy = value;
            }
        }
    }
}
