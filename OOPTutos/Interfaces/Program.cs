using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
     class Program
     {
        static void Main(string[] args)
        {
            //IntarfacesIntro();


            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Delete();
            }
           
            
            
            
            Console.ReadLine();
        }

        private static void Demo()

        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void IntarfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Isa",
                LastName = "Demir",
                Adress = "Istanbul"
            };

            //manager.Add(new Customer { Id = 1, FirstName = "İsa", LastName = "Demir", Adress = "Istanbul" });


            Student student = new Student
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Kundilli",
                Departmant = "Computer Sciences"
            };
            manager.Add(customer);
            manager.Add(student);
        }
    }
     interface IPerson
     {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        public string Adress { get; set; }

    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
        
    }
   
    
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);

            Console.WriteLine(person.LastName);
        }
   
    }




}
