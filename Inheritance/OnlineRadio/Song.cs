using OnlineRadio.Exceptions;

namespace OnlineRadio
{
    public class Song
    {
        private string name;
        private string artist;
        
        public Song(string artist, string name,Duration duration)
        {
            this.Artist = artist;
            this.Name = name;
            this.Duration = duration;
        }
        public string Artist
        {
            get
            {
                return this.artist;
            }
            set
            {
                if (value.Length<3 || value.Length>20 || value==null)
                {
                    throw new InvalidArtistNameException();
                }
                this.artist = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 3 || value.Length > 20 || value == null)
                {
                    throw new InvalidSongNameException();
                }
                    this.name = value; 
            }
        }
        public Duration Duration { get; private set; }
    }
}
