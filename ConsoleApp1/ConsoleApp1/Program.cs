using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1}={2}", i, n, (i * n));
            }

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
