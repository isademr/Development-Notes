using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer
            {
                City = "Istanbul",
                Id = 2,
                FirstName = "İsa",
                LastName = "Demir"
            };

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Derin",
                LastName = "Nadir"
            };
            Console.WriteLine(customer2.FirstName);
            
            Console.ReadLine();

        }
    }

}
