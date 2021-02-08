using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.FirstName = "Murat";
            customer1.LastName = "Cengiz";
            customer1.CustomerJob = "Student";

            Customer[] customers = new Customer[] {customer1};

            foreach (var customer in customers)
            {
                Console.WriteLine("Id : "+customer.CustomerId+"\nFirst Name : "+customer.FirstName+"\nLast Name : "+customer.LastName+"\nCustomer Job : "+customer.CustomerJob);
            }
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);

            CustomerManager customerManager1 = new CustomerManager();
            customerManager.Delete(customer1);
        }
    }
}
