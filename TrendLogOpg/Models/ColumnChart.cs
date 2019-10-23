using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrendLogOpg.Models
{
    public class ColumnChart
    {
        public string January { get; set; }
        public string Febuary { get; set; }
        public string March { get; set; }
        public int April { get; set; }
        public int May { get; set; }
        public int June { get; set; }
        public int July { get; set; }

        public ColumnChart(string january, string febuary, string march, int april, int may, int june, int july)
        {
            January = january;
            Febuary = febuary;
            March = march;
            April = april;
            May = may;
            June = june;
            July = july;
        }

    }
}
