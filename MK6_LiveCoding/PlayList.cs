using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MK6_LiveCoding
{
    public class PlayList
    {
        public string Name { get; set; }
        private List<MusicComposition> _compositions = new();
        public PlayList(string name)
        {
            Name = name;
        }
        public void AddComposition(MusicComposition musicComposition) // додавання
        {
            _compositions.Add(musicComposition);
        }
        public TimeSpan GetTotalDuration() // підрахунок тривалості
        {
            TimeSpan total = TimeSpan.Zero;
            foreach (MusicComposition musicComposition in _compositions)
            {
                total += musicComposition.Duration;
            }
            return total;
        }
        public void SortByGenre() // сортування за жанром
        {
            _compositions.Sort();
        }

        public List<MusicComposition> FindByGenres(string genres) // пошук за жанром
        {
            List<MusicComposition> result = new List<MusicComposition>();

            foreach (MusicComposition composition in _compositions)
            {
                if (composition.Genre == composition.Genre)
                    result.Add(composition);
            }
            return result;
        }
        public override string ToString()
        {
            string result = $"\n\nПлейлист: {Name}";
            result += $"Тривалість плейлиста: {GetTotalDuration}";
            return result;
        }
    }
}
