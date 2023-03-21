using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Document
    {
        public int code { get; } = new Random().Next(1000, 9999);
        public int shelf { get; } = new Random().Next(1, 30);
        public string title { get; set; }
        public string author { get; set; }
        public string year { get; set; }
        public string category { get; set; }

        public Document(string title, string author, string year, string category)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.category = category;
        }
    }
}