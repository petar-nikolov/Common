using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.BL.Exceptions;

namespace CMS.BL
{
    public class CustomerRepository
    {
        public List<Customer> Customers { get; set; }

        public void ValidateCustomer()
        {
        }

        public bool IsCustomerExisting(Customer customer)
        {
            if (!Customers.Contains(customer))
            {
                throw new CustomerUnavailableException();
            }

            return true;
        }
    }
}