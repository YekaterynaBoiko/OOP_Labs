using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task9
{
    public class StreamingService
    {
        public string Name { get; set; }
        public int ViewerRating { get; set; } // прописатии що воно від 0 до 10
        public int Duration { get; set; }
        public int ReleaseDate { get; set; }

        public StreamingService(string name, int viewerRating, int duration, int releaseDate)
        {
            Name = name;
            ViewerRating = viewerRating;
            Duration = duration;
            ReleaseDate = releaseDate;
        }

        public override string ToString()
        {
            return $"\nName: {Name} " +
                $"\nView Rating: {ViewerRating}" +
                $"\nDuration: {Duration}" +
                $"\nRelease Date: {ReleaseDate}";
        }
    }
}
