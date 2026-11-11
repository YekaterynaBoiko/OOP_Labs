using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;


namespace Lab38_40_Task3
{
    public class XmlBookParser : IBookParser
    {

        public List<Book> Parse(string path)
        {
            XDocument document = XDocument.Load(path);

            List<Book> books = document.Root
                .Elements("book")
                .Select(element => new Book(
                    (string)element.Element("title"),
                    (string)element.Element("author"),
                    (int)element.Element("year")))
                .ToList();

            return books;
        }
    }
}