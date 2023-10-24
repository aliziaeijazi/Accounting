using AccountingApp.Customers;
using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp
{
    public partial class CusotmersForm : Form
    {
        public CusotmersForm()
        {
            InitializeComponent();
        }

        private void CusotmersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accounting_DBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.accounting_DBDataSet.Customers);
            LoadDataGridCustomers();
        }
        private void LoadDataGridCustomers()
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                DataGridCustomer.DataSource = db.CustomerRepository.GetAllCustomers();
            }
        }

        private void refrshCustomerBtn_Click(object sender, EventArgs e)
        {
            LoadDataGridCustomers();
            searchCustomerInput.Text = "";
        }

        private void searchCustomerInput_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                DataGridCustomer.DataSource = db.CustomerRepository.GetCustomersByFilter(searchCustomerInput.Text);
            }
        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            if (DataGridCustomer.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = DataGridCustomer.CurrentRow.Cells[2].Value.ToString();
                    string family = DataGridCustomer.CurrentRow.Cells[3].Value.ToString();
                    string fullName = $"{name} {family}";
                    DialogResult confirmation = RtlMessageBox.Show($"آیا از حذف {fullName} مطمئن هستید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        int cusotmerId = int.Parse(DataGridCustomer.CurrentRow.Cells[0].Value.ToString());
                        db.CustomerRepository.DeleteCustomer(cusotmerId);
                        db.save();
                        LoadDataGridCustomers();
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک شخص را انتخاب نمایید.");
            }
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            AddOrEditCustomersForm addOrEditCustomerForm = new AddOrEditCustomersForm();
            DialogResult insertStatus =  addOrEditCustomerForm.ShowDialog();
            if (insertStatus == DialogResult.OK)
            {
                LoadDataGridCustomers();
            }
        }
    }
}
