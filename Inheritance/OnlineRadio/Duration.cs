using OnlineRadio.Exceptions;
namespace OnlineRadio
{
    public class Duration
    {
        private int minutes;
        private int seconds;
        public Duration(int minutes,int seconds)
        {
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
        public int Minutes
        {
            get
            {
                return this.minutes;
            }
            set
            {
                if (value<0 || value>14)
                {
                    throw new InvalidSongMinutesException();
                }
                this.minutes = value;
            }
        }
        public int Seconds
        {
            get
            {
                return this.seconds;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }
                this.seconds = value;
            }
        }
        public long AllDuration { get; private set; }

        public void WholeTime()
        {
            this.AllDuration = this.minutes * 60 + this.seconds;
        }

    }
}