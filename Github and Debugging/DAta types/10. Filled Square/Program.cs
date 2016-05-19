using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Printheader(n);

            for (int i = 0; i < n-2 ; i++)
            {
                middlerow(n);
            }
            Printheader(n);
        }
        static void middlerow(int n)
        {
            Console.Write("-");
            for (int i = 0; i < n-1; i++)
            {
                Console.Write(@"\/");
             }
            Console.WriteLine("-");
        }
        static void Printheader(int n)
        {
            for (int i = 0; i < n*2; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
