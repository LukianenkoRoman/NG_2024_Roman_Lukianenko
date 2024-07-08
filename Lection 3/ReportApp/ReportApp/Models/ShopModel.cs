using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportApp.Models
{
    public class ShopModel
    {
        public string PointOfPurchase { get; set; }
        public List<ShopItem> Items { get; set; }
        public string Seller { get; set; }
    }
}
