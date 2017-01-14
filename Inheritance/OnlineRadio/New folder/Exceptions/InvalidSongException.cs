using System;

namespace OnlineRadio.Exceptions
{
   public class InvalidSongException:Exception
    {
        private new const string Message = "Invalid song.";
        public InvalidSongException() : base(Message)
        {
        }

        public InvalidSongException(string m) : base(m)
        {
        }
    }
}
