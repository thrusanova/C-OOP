
namespace SExam.Item
{
   public class Device
    {
        private decimal deviceCost;

        public Device(decimal deviceCost)
        {
            this.DeviceCost = deviceCost;
        }

        public decimal DeviceCost
        {
            get
            {
                return this.deviceCost;
            }
            private set
            {
                this.deviceCost = value;
            }
        }
    }
}
