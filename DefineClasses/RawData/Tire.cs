namespace RawData
{
    public class Tire
    {
        private int tyreAge;
        private double typePressure;

        public Tire(int tyreAge,double typePressure)
        {
            this.tyreAge = tyreAge;
            this.typePressure = typePressure;
        }
        public int TyreAge
        {
            get
            {
                return this.tyreAge;
            }
            set
            {
                this.tyreAge = value;
            }
        }
        public double TypePressure
        {
            get
            {
                return this.typePressure;
            }
            set
            {
                this.typePressure = value;
            }
        }
    }
}