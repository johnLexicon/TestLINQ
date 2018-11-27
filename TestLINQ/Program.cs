using System;
using System.Collections.Generic;

namespace TestLINQ
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            var repo = new CustomerRepository();
            List<Customer> customers = repo.Retrieve();

            Customer customer = repo.Find(customers, 2);
            Console.WriteLine(customer.FirstName);

            Customer customer2 = repo.FindWithDeclarativeQuery(customers, 1);
            Console.WriteLine(customer2.FirstName);
        }
    }
}
