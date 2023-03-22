using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : Document
    {
        public Dvd(string title, string author, string year, string category) : base(title, author, year, category) { }
        public int ? dvdLength { get; set; }
    }
}
