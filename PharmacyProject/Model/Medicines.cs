using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Medicines
    {
        public int medicineid { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal unit_price { get; set; }
        public DateTime unit_price_change_date { get; set; }
    }
}
