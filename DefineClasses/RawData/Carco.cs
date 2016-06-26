namespace RawData
{
    public class Carco
    {
        private string cargoType;
        private int cargoWeight;
        public Carco(int cargoweight,string cargotype)
        {
            this.cargoWeight = cargoweight;
            this.cargoType = cargotype;
        }
        public int CargoWeiht
        {
            get
            {
                return this.cargoWeight;
            }
            set
            {
                this.cargoWeight = value;
            }
        }
        public  string CsrgoType
        {
            get
            {
                return this.cargoType;
            }
            set
            {
                this.cargoType = value;
            }
        }
    }
}