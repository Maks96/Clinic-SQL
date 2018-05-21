using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Purchases
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string telephone_number { get; set; }
        public string city { get; set; }
        public int purchase_id { get; set; }
        public DateTime date { get; set; }
        public decimal price_overall { get; set; }
    }
}
