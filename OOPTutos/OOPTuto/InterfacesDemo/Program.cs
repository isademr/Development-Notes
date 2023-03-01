using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
     class Program
    {
        static void Main(string[] args)
        {

            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }


            IEat[] eats = new IEat[2];
            {
                new Worker();
                new Manager();
            }

            foreach(var eat in eats)
            {
                eat.Eat();
            }

        }
    }
    interface IWorker
    {
        void Work();
    }
    //SOLID, Interface Segregation
    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("GetSalary");
        }

        public void Work()
        {
            Console.WriteLine("Work");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("GetSalary");
        }

        public void Work()
        {
            Console.WriteLine("Work");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Work");
        }
    }
}
