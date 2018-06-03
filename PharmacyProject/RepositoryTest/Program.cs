using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.User.getEmployees();

            var medicines = Repository.User.getMedicines();

            var purchases = Repository.User.getPurchases();

            var purchasedmedicine = Repository.User.getPurchasedMedicines(2);

            var xxx = Repository.User.deletePurchase("234", "2018-06-03 12:13:21.000");
        }
    }
}
