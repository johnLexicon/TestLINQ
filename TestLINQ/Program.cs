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

            // Find customer
            Customer customer = repo.Find(customers, 2);
            Console.WriteLine(customer.FirstName);

            Customer customer2 = repo.FindWithQuerySyntax(customers, 1);
            Console.WriteLine(customer2.FirstName);

            Customer customer3 = repo.FindWithMethodSyntax(customers, 3);
            if(customer3 is null)
            {
                Console.WriteLine("No customer with that id");
            }
            else
            {
                Console.WriteLine(customer3.FirstName);
            }

            Console.ReadKey();
        }
    }
}
