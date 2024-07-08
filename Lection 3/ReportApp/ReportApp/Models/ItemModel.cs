using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportApp.Models
{
    public class ItemModel
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
        public string Notes { get; set; }
    }
}
