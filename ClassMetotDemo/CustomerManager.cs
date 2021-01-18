using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
       
       public void CustomerAdd(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName);
            Console.WriteLine("-----Müşteri Eklendi-----");
        }

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName);
            Console.WriteLine("-----Müşteri Silindi-----");
        }

        public void CustomerList(Customer customer)
        {
            string[] Customer = new [] {(Convert.ToString(customer.TcNo)),(customer.FirstName),(customer.LastName),(customer.PhoneNumber)};
            Console.WriteLine("Müşteriler:");
            foreach (var i in Customer)
            {
                Console.Write(i+" ");
                
            }
            Console.ReadLine();
        }

    }
}
