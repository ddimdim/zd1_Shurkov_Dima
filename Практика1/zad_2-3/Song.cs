using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    struct Song
    {
        public string Author;
        public string Title;
        public string Filename;
        public Song(string Author, string Title, string Filename)
        {
            this.Author = Author;
            this.Title = Title;
            this.Filename = Filename;
        }
    }
}
