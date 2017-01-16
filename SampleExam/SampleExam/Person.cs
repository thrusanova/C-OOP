
namespace SampleExam
{
   public abstract class Person
    {
        private int rooms;
        private decimal roomElectricity;
        private decimal salary;
        private decimal costs;
        public Person(decimal salary,int rooms,decimal roomElecticity)
        {
            this.Salary = salary;
            this.Rooms = rooms;
            this.RoomElecticity = roomElectricity;
           
        }

        public int Rooms
        {
            get
            {
                return this.rooms;
            }
            set
            {
                this.rooms = value;
            }
        }
        public decimal RoomElecticity
        {
            get
            {
                return this.roomElectricity;
            }
            set
            {
                this.roomElectricity = value;
            }
        }
        public decimal Salary { get; private set; }

        public virtual decimal Consumption()
        {
            return this.RoomElecticity * rooms;
        } 
        public virtual int Population()
        {
            return 1;
        }
    }
}
