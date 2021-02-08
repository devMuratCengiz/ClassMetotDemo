using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)  
        {
            Console.WriteLine(customer.CustomerId+" Id numarali kullanici "+
                customer.FirstName+" "+customer.LastName + " sisteme eklenmistir.");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerId + " Id numaralı kullanici " + customer.FirstName + " " + customer.LastName + " sistemden silinmistir.");
        }
    }
}
