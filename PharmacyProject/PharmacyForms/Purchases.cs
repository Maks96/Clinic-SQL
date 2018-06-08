using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyForms
{
    public partial class Purchases : Form
    {
        private string id = "";

        public Purchases()
        {
            InitializeComponent();
            loadEmployees();
            loadPurchases();
            loadMedicine();
        }

        private void loadEmployees()
        {
            var employees = Repository.User.getEmployees();

            foreach (var e in employees)
            {
                string text = e.first_name + " / " + e.last_name + " / " + e.pesel + " / " + e.telephone_number + " / " + e.address + " / " + e.city;
                EmployeesBox.Items.Add(text);
            }
        }

        private void loadPurchases()
        {
            var purchases = Repository.User.getPurchases();

            foreach (var p in purchases)
            {
                string text = p.purchase_id + " / " + p.pesel + " / " + p.first_name + " / " + p.last_name + " / " + p.telephone_number + " / " + p.address + " / " + p.city + " / " + p.date;
                PurchaseBox.Items.Add(text);
            }
        }

        private void loadMedicine()
        {
            var medicine = Repository.User.getMedicines();

            foreach (var m in medicine)
            {
                string text = m.name + " / " + m.unit_price.ToString("0.##") + " / " + m.unit_price_change_date + " / " + m.description;
                MedicineBox.Items.Add(text);
            }
        }

        private void loadMedicinePurchase(int id)
        {
            var purchases_medicine = Repository.User.getPurchasedMedicines(id);

            foreach (var pm in purchases_medicine)
            {
                string text = pm.medicine_name + " / " + pm.amount.ToString("0") + " / " + pm.price_sum;
                PurchasesMedicineBox.Items.Add(text);
            }
        }

        private void loadSum(int id)
        {
            var sum = Repository.User.getSum(id);

            ResultLabel.Text = sum.ToString();
        }

        private void PurchaseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PurchasesMedicineBox.Items.Clear();

            String parameter = PurchaseBox.SelectedItem.ToString();
            String[] parameters = parameter.Split('/');
            id = parameters[0].Substring(0, parameters[0].Length - 1);

            loadMedicinePurchase(Int32.Parse(id));

            loadSum(Int32.Parse(id));
        }

        private void InsertPurchase_Click(object sender, EventArgs e)
        {
            String parameter = EmployeesBox.SelectedItem.ToString();
            String[] parameters = parameter.Split('/');
            string pesel = parameters[2].Substring(1, parameters[2].Length - 2);

            var result = Repository.User.insertPurchase(pesel);

            PurchaseBox.Items.Clear();
            loadPurchases();
        }

        private void DeletePurchase_Click(object sender, EventArgs e)
        {
            String parameter = PurchaseBox.SelectedItem.ToString();
            String[] parameters = parameter.Split('/');
            string pesel = parameters[1].Substring(1, parameters[1].Length - 2);
            string date = parameters[7].Substring(1, parameters[7].Length - 1);

            var result = Repository.User.deletePurchase(pesel, date);

            PurchaseBox.Items.Clear();
            loadPurchases();
        }

        private void DeleteMedicineFromPurchase_Click(object sender, EventArgs e)
        {
            String parameter = PurchasesMedicineBox.SelectedItem.ToString();
            String[] parameters = parameter.Split('/');
            string name = parameters[0].Substring(0, parameters[0].Length - 1);
            int amount = Int32.Parse(parameters[1].Substring(1, parameters[1].Length - 2));

            var result = Repository.User.deletePurchaseMedicine(Int32.Parse(id), name, amount);

            PurchasesMedicineBox.Items.Clear();

            loadMedicinePurchase(Int32.Parse(id));

            loadSum(Int32.Parse(id));
        }

        private void InsertMedicineToPurchase_Click(object sender, EventArgs e)
        {
            String parameter = MedicineBox.SelectedItem.ToString();
            String[] parameters = parameter.Split('/');
            string name = parameters[0].Substring(0, parameters[0].Length - 1);
            int amount = Int32.Parse(AmountTextBox.Text);

            var result = Repository.User.insertPurchaseMedicine(Int32.Parse(id), name, amount);

            PurchasesMedicineBox.Items.Clear();

            loadMedicinePurchase(Int32.Parse(id));

            loadSum(Int32.Parse(id));
        }
    }
}
