using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.ID = 1;
            customer1.customerName = "Ümit";
            customer1.customerSurname = "Şahin";

            Customer customer2 = new Customer();
            customer2.ID = 2;
            customer2.customerName = "Onur";
            customer2.customerSurname = "Coşkun";

            Customer customer3 = new Customer();
            customer3.ID = 3;
            customer3.customerName = "Abdullah Halit";
            customer3.customerSurname = "Korucuoğlu";

            Customer customer4 = new Customer();
            customer4.ID = 4;
            customer4.customerName = "Devrim Mehmet";
            customer4.customerSurname = "Pattabanoğlu";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);


    
            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Add(customer4);

            customerManager.Listing(customers);

        }
    }
}