
using DataLayer;
using DataLayer.Repositories;
using DataLayer.services;
using DataLayer.Context;
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
            UnitOfWork db = new UnitOfWork();
            List<Customers> list = db.CustomerRepository.GetAllCustomers();

            db.Dispose();
        }
    }
}
