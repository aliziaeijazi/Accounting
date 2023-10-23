using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.services
{
    public class CustomerRepository : ICustomerRepository
    {
        Accounting_DBEntities db = new Accounting_DBEntities();
        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }
        public Customers GetCustomerById(int customerId)
        {
            return db.Customers.Find(customerId);
        }
        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State=EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                Customers customer = GetCustomerById(customerId);
                return DeleteCustomer(customer);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void save()
        {
            db.SaveChanges();
        }

    }
}
