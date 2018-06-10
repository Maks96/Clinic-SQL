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

        public static int insertEmployee(string pesel, string first_name, string last_name, string address, string telephone_number, string city)
        {
            return Base.Insert<int>("AddEmployee", new { pesel, first_name, last_name, address, telephone_number, city });
        }

        public static int deleteEmployee(string pesel)
        {
            return Base.Delete<int>("DeleteEmployee", new { pesel });
        }

        public static int insertMedicine(string name, string description, decimal unit_price)
        {
            return Base.Insert<int>("AddMedicine", new { name, description, unit_price });
        }

        public static int deleteMedicine(string medicine_name)
        {
            return Base.Delete<int>("DeleteMedicine", new { medicine_name });
        }
    }
}
