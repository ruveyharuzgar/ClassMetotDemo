using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            CustomerManager customerManager = new CustomerManager();


            Console.Write("TC no giriniz: ");
            customer.TcNo = Convert.ToDecimal(Console.ReadLine());
            Console.Write("İsminizi giriniz: ");
            customer.FirstName = Convert.ToString(Console.ReadLine());
            Console.Write("Soyadınızı giriniz: ");
            customer.LastName = Convert.ToString(Console.ReadLine());
            Console.Write("Telefon numaranızı giriniz: ");
            customer.PhoneNumber= Convert.ToString(Console.ReadLine());

            customerManager.CustomerAdd(customer);
            customerManager.CustomerDelete(customer);
            customerManager.CustomerList(customer);
            Console.ReadKey();
            
            
        }
    }
}
