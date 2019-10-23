using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace TrendLogOpg.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public int Earning { get; set; }
        public string Profession { get; set; }
        public string ImagePath { get; set; }
    }


}
