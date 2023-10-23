
using DataLayer;
using DataLayer.Repositories;
using DataLayer.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository customerRepository = new CustomerRepository();

            Customers customer = new Customers()
            {
                Name="محمدرضا",
                Family="ضیایی جزی",
                PhoneNumber="09133282279",
                Email="MohammadRezaZiaei@gmail.com",
                Address="اصفهان،گز برخوار",
                CustomerImage="NoPhoto"
            };
            customerRepository.InsertCustomer(customer);
            customerRepository.save();
        }
    }
}
