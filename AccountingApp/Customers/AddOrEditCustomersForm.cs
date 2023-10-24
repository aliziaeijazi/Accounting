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
                DataLayer.Customers newCustomer = new DataLayer.Customers()
                {
                    Name = customerNameInput.Text,
                    Family = customerFamilyInput.Text,
                    PhoneNumber = customerPhoneNumberInput.Text,
                    Email = customerEmailInput.Text,
                    Address = customerAddressInput.Text,
                    CustomerImage = imageName
                };
                db.CustomerRepository.InsertCustomer(newCustomer);
                db.save();
                DialogResult = DialogResult.OK;
            }
        }


    }
}
