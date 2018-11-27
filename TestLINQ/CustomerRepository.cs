using System;
using System.Collections.Generic;
using System.Linq;

namespace TestLINQ
{
    public class CustomerRepository
    {

        public Customer Find(List<Customer> customers, int customerId)
        {
            Customer customer = null;

            foreach(var c in customers)
            {
                if(c.CustomerId == customerId)
                {
                    customer = c;
                    break;
                }
            }
            return customer;
        }

        public Customer FindWithDeclarativeQuery(List<Customer> customers, int customerId)
        {
            var query = from c in customers
                        where c.CustomerId == customerId
                        select c;

            return query.First();
        }

        public List<Customer> Retrieve()
        {
            var customerList = new List<Customer> {
                new Customer()
                {
                    CustomerId = 1,
                    FirstName = "John",
                    LastName = "Lundgren",
                    CustomerTypeId = null,
                    EmailAddress = "totick@hotmail.com"
                },
                new Customer()
                {
                    CustomerId = 2,
                    FirstName = "Gosia",
                    LastName = "Tkaczyk",
                    CustomerTypeId = 10,
                    EmailAddress = "gostka37@gmail.com"
                },
                new Customer()
                {
                    CustomerId = 3,
                    FirstName = "Kròlik",
                    LastName = "Conejo",
                    CustomerTypeId = 20,
                    EmailAddress = "krolik@hotmail.com"
                }

            };
            return customerList;
        }
    }
}
