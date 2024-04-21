using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_КаталогКниг.Models
{
    class Book
    {
        private string _author;
        private string _name;
        private string _year;
        private string _publishingHouse;
        private string _annotation;

        public string Author { get => _author; set => _author = value; }
        public string Name { get => _name; set => _name = value; }
        public string Year { get => _year; set => _year = value; }
        public string PublishingHouse { get => _publishingHouse; set => _publishingHouse = value; }
        public string Annotation { get => _annotation; set => _annotation = value; }

        public Book(string author, string name, string year, string publishingHouse, string annotation)
        {
            Author = author;
            Name = name;
            Year = year;
            PublishingHouse = publishingHouse;
            Annotation = annotation;
        }

        public override string ToString()
        {
            return String.Format(Author + "|" + Name + "|" + Year + "|" + PublishingHouse + "|" + Annotation + "|");
        }
    }
}
