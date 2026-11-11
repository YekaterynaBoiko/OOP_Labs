using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab32_Task2
{
    public class Playlist
    {
        private class Song
        {
            public string Title { get; }
            public int DurationInSeconds { get; }

            public Song(string title, int duration)
            {
                Title = title;
                DurationInSeconds = duration;
            }
        }

        private readonly List<Song> _songs = [];
        public void AddSong(string title, int duration)
        {
            _songs.Add(new Song(title, duration));
        }
        public int SongCount => _songs.Count;
        public int GetTotalDurationSong()
        {
            int total = 0;
            foreach (var song in _songs)
                total += song.DurationInSeconds;

            return total;
        }
    }
}
