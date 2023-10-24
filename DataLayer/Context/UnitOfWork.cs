using DataLayer.Repositories;
using DataLayer.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();
        private ICustomerRepository _customerRepository;

        public ICustomerRepository CustomerRepository {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);
                }
                return _customerRepository;
            } 
        }

        public void save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            
        }
    }
}
