using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository
{
    public class User
    {
        public static IEnumerable<Employees> getEmployees()
        {
            return Repository.Base.Read<Employees>("getEmployees");
        }

        public static IEnumerable<Medicines> getMedicines()
        {
            return Repository.Base.Read<Medicines>("getMedicines");
        }

        public static IEnumerable<Purchases> getPurchases()
        {
            return Repository.Base.Read<Purchases>("getPurchases");
        }

        public static IEnumerable<PurchasedMedicines> getPurchasedMedicines(int id)
        {
            return Repository.Base.ReadById<PurchasedMedicines>("getPurchasedMedicines", new { purchase_id = id });
        }
    }
}
