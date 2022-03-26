using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            System.Console.WriteLine($"{customer.customerName} {customer.customerSurname} eklendi");
        } 

         public void Delete(Customer customer)
        {
            System.Console.WriteLine($"{customer.customerName} {customer.customerSurname} silindş");
        } 

         public void Listing(List<Customer> customers)
        {
           foreach (var customer in customers)
           {
               System.Console.WriteLine(customer.customerName);
           }
        } 

    }
}