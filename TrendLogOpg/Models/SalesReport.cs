using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TrendLogOpg.Models
{
    public class SalesReport
    {
        public int SalesReportID { get; set; }
        public DataSet dataSet { get; set; }
       
    }
}
