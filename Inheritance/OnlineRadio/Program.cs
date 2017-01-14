using System;
using System.Collections.Generic;
using System.Linq;
using OnlineRadio.Exceptions;

namespace OnlineRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var songs = new List<Song>();
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(';');
                try {
                    
                    string artist = input[0];
                    string title = input[1];
                    int[] duration = input[2]
                          .Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse).ToArray();
                    int m = duration[0];
                    int s = duration[1];
                    var durr = new Duration(m, s);
                    var song = new Song(artist, title, durr);
                    songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch(InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message); ;
                }
                catch (FormatException)
                {
                    Console.WriteLine(InvalidSongLengthException.Message);
                }
                }
            long dur = 0;
            foreach (var s in songs)
            {
                s.Duration.WholeTime();
                dur+= s.Duration.AllDuration;
            }
            Console.WriteLine($"Songs added: {songs.Count}");
            long finalMinutes = dur / 60;
            long finalSeconds = dur % 60;
            long finalHours = dur / 3600;
            finalMinutes %= 60;

            Console.WriteLine("Playlist length: {0}h {1}m {2}s",
finalHours, finalMinutes, finalSeconds);
        }
    }
}
