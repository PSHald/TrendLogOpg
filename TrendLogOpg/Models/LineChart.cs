using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrendLogOpg.Models
{
    public class LineChart
    {
        public string GeneratedLeads { get; set; }
        public string SubmittedTickers { get; set; }
        public string ServerAllocation { get; set; }
        public string OtherValue { get; set; }

        public LineChart(string GL, string ST, string SA, string OV)
        {
            GeneratedLeads = GL;
            SubmittedTickers = ST;
            ServerAllocation = SA;
            OtherValue = OV;
        }
    }
}
