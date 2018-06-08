namespace PharmacyForms
{
    partial class Purchases
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeesBox = new System.Windows.Forms.ListBox();
            this.PurchaseBox = new System.Windows.Forms.ListBox();
            this.PurchasesMedicineBox = new System.Windows.Forms.ListBox();
            this.MedicineBox = new System.Windows.Forms.ListBox();
            this.InsertPurchase = new System.Windows.Forms.Button();
            this.DeletePurchase = new System.Windows.Forms.Button();
            this.SumLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.DeleteMedicineFromPurchase = new System.Windows.Forms.Button();
            this.InsertMedicineToPurchase = new System.Windows.Forms.Button();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EmployeesBox
            // 
            this.EmployeesBox.FormattingEnabled = true;
            this.EmployeesBox.ItemHeight = 16;
            this.EmployeesBox.Location = new System.Drawing.Point(12, 12);
            this.EmployeesBox.Name = "EmployeesBox";
            this.EmployeesBox.Size = new System.Drawing.Size(408, 84);
            this.EmployeesBox.TabIndex = 0;
            // 
            // PurchaseBox
            // 
            this.PurchaseBox.FormattingEnabled = true;
            this.PurchaseBox.ItemHeight = 16;
            this.PurchaseBox.Location = new System.Drawing.Point(12, 130);
            this.PurchaseBox.Name = "PurchaseBox";
            this.PurchaseBox.Size = new System.Drawing.Size(604, 84);
            this.PurchaseBox.TabIndex = 1;
            this.PurchaseBox.SelectedIndexChanged += new System.EventHandler(this.PurchaseBox_SelectedIndexChanged);
            // 
            // PurchasesMedicineBox
            // 
            this.PurchasesMedicineBox.FormattingEnabled = true;
            this.PurchasesMedicineBox.ItemHeight = 16;
            this.PurchasesMedicineBox.Location = new System.Drawing.Point(12, 243);
            this.PurchasesMedicineBox.Name = "PurchasesMedicineBox";
            this.PurchasesMedicineBox.Size = new System.Drawing.Size(229, 84);
            this.PurchasesMedicineBox.TabIndex = 2;
            // 
            // MedicineBox
            // 
            this.MedicineBox.FormattingEnabled = true;
            this.MedicineBox.ItemHeight = 16;
            this.MedicineBox.Location = new System.Drawing.Point(12, 352);
            this.MedicineBox.Name = "MedicineBox";
            this.MedicineBox.Size = new System.Drawing.Size(324, 84);
            this.MedicineBox.TabIndex = 3;
            // 
            // InsertPurchase
            // 
            this.InsertPurchase.Location = new System.Drawing.Point(453, 36);
            this.InsertPurchase.Name = "InsertPurchase";
            this.InsertPurchase.Size = new System.Drawing.Size(126, 36);
            this.InsertPurchase.TabIndex = 4;
            this.InsertPurchase.Text = "Insert Purchase";
            this.InsertPurchase.UseVisualStyleBackColor = true;
            this.InsertPurchase.Click += new System.EventHandler(this.InsertPurchase_Click);
            // 
            // DeletePurchase
            // 
            this.DeletePurchase.Location = new System.Drawing.Point(649, 149);
            this.DeletePurchase.Name = "DeletePurchase";
            this.DeletePurchase.Size = new System.Drawing.Size(126, 36);
            this.DeletePurchase.TabIndex = 5;
            this.DeletePurchase.Text = "Delete Purchase";
            this.DeletePurchase.UseVisualStyleBackColor = true;
            this.DeletePurchase.Click += new System.EventHandler(this.DeletePurchase_Click);
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(273, 274);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(56, 17);
            this.SumLabel.TabIndex = 6;
            this.SumLabel.Text = "Result: ";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(345, 274);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(28, 17);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "0,0";
            // 
            // DeleteMedicineFromPurchase
            // 
            this.DeleteMedicineFromPurchase.Location = new System.Drawing.Point(453, 264);
            this.DeleteMedicineFromPurchase.Name = "DeleteMedicineFromPurchase";
            this.DeleteMedicineFromPurchase.Size = new System.Drawing.Size(226, 36);
            this.DeleteMedicineFromPurchase.TabIndex = 8;
            this.DeleteMedicineFromPurchase.Text = "Delete Medicines from Purchase";
            this.DeleteMedicineFromPurchase.UseVisualStyleBackColor = true;
            this.DeleteMedicineFromPurchase.Click += new System.EventHandler(this.DeleteMedicineFromPurchase_Click);
            // 
            // InsertMedicineToPurchase
            // 
            this.InsertMedicineToPurchase.Location = new System.Drawing.Point(549, 373);
            this.InsertMedicineToPurchase.Name = "InsertMedicineToPurchase";
            this.InsertMedicineToPurchase.Size = new System.Drawing.Size(226, 36);
            this.InsertMedicineToPurchase.TabIndex = 9;
            this.InsertMedicineToPurchase.Text = "Insert Medicine To Purchase";
            this.InsertMedicineToPurchase.UseVisualStyleBackColor = true;
            this.InsertMedicineToPurchase.Click += new System.EventHandler(this.InsertMedicineToPurchase_Click);
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(381, 380);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 22);
            this.AmountTextBox.TabIndex = 10;
            // 
            // Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 465);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.InsertMedicineToPurchase);
            this.Controls.Add(this.DeleteMedicineFromPurchase);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.DeletePurchase);
            this.Controls.Add(this.InsertPurchase);
            this.Controls.Add(this.MedicineBox);
            this.Controls.Add(this.PurchasesMedicineBox);
            this.Controls.Add(this.PurchaseBox);
            this.Controls.Add(this.EmployeesBox);
            this.Name = "Purchases";
            this.Text = "Purchases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeesBox;
        private System.Windows.Forms.ListBox PurchaseBox;
        private System.Windows.Forms.ListBox PurchasesMedicineBox;
        private System.Windows.Forms.ListBox MedicineBox;
        private System.Windows.Forms.Button InsertPurchase;
        private System.Windows.Forms.Button DeletePurchase;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button DeleteMedicineFromPurchase;
        private System.Windows.Forms.Button InsertMedicineToPurchase;
        private System.Windows.Forms.TextBox AmountTextBox;
    }
}