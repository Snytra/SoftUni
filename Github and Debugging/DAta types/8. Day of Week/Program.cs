using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("Monday");
            }
            if (n == 2)
            {
                Console.WriteLine("Tuesday");
            }
            if (n == 3)
            {
                Console.WriteLine("Wednesday");
            }
            if (n == 4)
            {
                Console.WriteLine("Thursday");
            }
            if (n == 5)
            {
                Console.WriteLine("Friday");
            }
            if (n == 6)
            {
                Console.WriteLine("Saturday");
            }
            if (n == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}
