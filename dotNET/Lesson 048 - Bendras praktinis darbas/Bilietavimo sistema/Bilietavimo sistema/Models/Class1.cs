using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilietavimo_sistema.Models
{
    internal class Report
    {
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public decimal total { get; set; }
    }
}
