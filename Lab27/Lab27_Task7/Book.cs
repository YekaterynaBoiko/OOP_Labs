using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task7
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int ThematicSection { get; set; }
        public Book(string title, int thematicSection)
        {
            Title = title;
            ThematicSection = thematicSection;
        }

        public int CompareTo(Book other)
        {
            return ThematicSection.CompareTo(other.ThematicSection);
        }

        public void PrintResult()
        {
            Console.WriteLine($"\nTitle: {Title} " +
                $"\nThematic Section: {ThematicSection}");
        }
    }
}
