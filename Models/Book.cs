using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Models
{
    public class Book
    {
        private static int _no;
        public int No { get; set; }

        public Book()
        {
            _no++;
            No = _no;
        }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public Genre Genre { get; set; }
        public double Price { get; set; }
    }
}
