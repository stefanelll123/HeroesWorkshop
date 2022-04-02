using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HeroesWorkshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new Customer[10];
            var customer1 = new Customer("Ionel", "Ionescu");
            var customer2 = new Customer("Popescu", "Alexandra");

            customers[0] = customer1;
            customers[1] = customer2;

            foreach (var customer in customers)
            {
                if (customer != null)
                {
                    Console.WriteLine(customer);
                }
            }

            var repository = new Repository<Customer>();
            repository.Add(customer1);
            repository.Add(customer2);
            Console.WriteLine(repository.Get().PrintCustomersNice());
            Console.WriteLine(repository.GetById(customer1.Id));
            repository.Delete(customer1.Id);
            Console.WriteLine(repository.Get().PrintCustomersNice());


            var array = new Customer[] { customer1, customer2 };
            var collection = new Collection<Customer>() { customer1, customer2 };
            var list = new List<Customer>() { customer1, customer2 };
        }
    }
}
