using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Print_String_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string Letters = Console.ReadLine();

            for (int i = 0; i < Letters.Length; i++)
            {
                Console.WriteLine("str[{0}] -> '{1}'" ,i,Letters[i]);                     
            }
        }
    }
}
