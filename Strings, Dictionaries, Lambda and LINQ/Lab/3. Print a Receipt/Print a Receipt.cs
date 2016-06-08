using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Print_a_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse);

            decimal total = 0;

            Console.WriteLine(@"/----------------------\");

            foreach (var num in numbers)
            {
                Console.WriteLine("| {0,20:f2} |", num);
                total += num;
            }
            Console.WriteLine(@"|----------------------|");

            Console.WriteLine("| Total: {0,13:f2} |", total);


            Console.WriteLine(@"\----------------------/");

           

        }
    }
}
