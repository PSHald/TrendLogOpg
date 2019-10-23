using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrendLogOpg.Models
{
    public class DataPoint
    {
        public int PointID { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Value { get; set; }
    }
}
