using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrendLogOpg.Models
{
    public class DataViewModel
    {
        public ColumnChart Column { get; set; }
        public LineChart Line { get; set; }
        public List<Author> Authors { get; set; }
        public SalesReport Sales { get; set; }
    }
}
