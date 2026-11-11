using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MK6_LiveCoding; // 1 Hour: from 18:00 - 19:00

public abstract class MusicComposition : IComparable<MusicComposition>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public TimeSpan Duration { get; set; }
    public abstract string Genre { get; }
    protected MusicComposition(string title, string author, TimeSpan duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
    }
    
    public int CompareTo(MusicComposition other)
    {
        return Genre.CompareTo(other.Genre);
    }
    public string ToString()
    {
        return $"\nНазва: {Title} " +
            $"\nАвтор: {Author}" +
            $"\nЖанр: {Genre}" +
            $"\nТривалість: {Duration}";
    }
}
