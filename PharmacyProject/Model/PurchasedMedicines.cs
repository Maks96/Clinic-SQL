using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PurchasedMedicines
    {
        public decimal amount { get; set; }
        public decimal price_sum { get; set; }
        public string medicine_description { get; set; }
        public string medicine_name { get; set; }
    }
}
