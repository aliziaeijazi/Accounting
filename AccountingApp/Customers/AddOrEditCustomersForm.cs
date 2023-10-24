using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace AccountingApp.Customers
{
    public partial class AddOrEditCustomersForm : Form
    {
        public int customerId = 0;
        UnitOfWork db = new UnitOfWork();
        public AddOrEditCustomersForm()
        {
            InitializeComponent();
        }

        private void selectPhotoBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                CustomerPhoto.ImageLocation = openFile.FileName;
            }

        }

        private void insertOrEditCustomerBtn_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(CustomerPhoto.ImageLocation);
                string path = Application.StartupPath + "/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                CustomerPhoto.Image.Save(path + imageName);
                DataLayer.Customers customer = new DataLayer.Customers()
                {
                    Name = customerNameInput.Text,
                    Family = customerFamilyInput.Text,
                    PhoneNumber = customerPhoneNumberInput.Text,
                    Email = customerEmailInput.Text,
                    Address = customerAddressInput.Text,
                    CustomerImage = imageName
                };
                if (customerId == 0)
                {
                    db.CustomerRepository.InsertCustomer(customer);

                }
                else
                {
                    customer.CustomerID = customerId;
                    db.CustomerRepository.UpdateCustomer(customer);
                }
                db.save();
                DialogResult = DialogResult.OK;
            }
        }

        private void AddOrEditCustomersForm_Load(object sender, EventArgs e)
        {
            if (customerId != 0)
            {
                this.Text = "ویرایش شخص";
                insertOrEditCustomerBtn.Text = "ویرایش اطلاعات";
                DataLayer.Customers customer = db.CustomerRepository.GetCustomerById(customerId);
                customerNameInput.Text = customer.Name;
                customerFamilyInput.Text = customer.Family;
                customerPhoneNumberInput.Text = customer.PhoneNumber;
                customerEmailInput.Text = customer.Email;
                customerAddressInput.Text = customer.Address;
                CustomerPhoto.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
            }
        }
    }
}
