using InterfaceAbstractDemo.Abstract;
using System;
using InterfaceAbstractDemo.Concrete;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new CustomerCheckManager());
            customerManager.Save(new Customer() { FirstName = "Ümit", LastName = "Şahin", DateOfBirth = new DateTime(1991, 10, 30),NationaltyId="12345678900" });

        }
    }
}
