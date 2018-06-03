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

        public static int insertPurchase(string pesel)
        {
            return Base.Insert<int>("AddPurchase", new { pesel = pesel });
        }

        public static int deletePurchase(string pesel, string date)
        {
            return Base.Delete<int>("DeletePurchase", new { pesel = pesel , date = date});
        }

        public static decimal getSum(int id)
        {
            var result = Repository.Base.ReadById<decimal>("getSum", new { id = id });

            return result.FirstOrDefault();
        }

        public static int deletePurchaseMedicine(int id, string name, decimal amount)
        {
            return Base.Delete<int>("DeleteMedicineFromPurchase", new { id = id, name = name, amount = amount });
        }

        public static int insertPurchaseMedicine(int id, string name, decimal amount)
        {
            return Base.Insert<int>("AddMedicineToPurchase", new { id = id, name = name, amount = amount });
        }
    }
}
