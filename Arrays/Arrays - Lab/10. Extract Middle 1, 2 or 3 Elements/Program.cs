using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int middleNumbers = arr.Length / 2;
            if (arr.Length == 1)
            {
                Console.WriteLine("{ " + arr[0] + " }");
            }
            else if (arr.Length % 2 == 0)
            {
                Console.WriteLine("{ " + arr[middleNumbers - 1] + ", " + arr[middleNumbers] + " }");
            }
            else
            {
                Console.WriteLine("{ " + arr[middleNumbers - 1] + ", " + arr[middleNumbers] + ", " + arr[middleNumbers + 1] + " }");
            }
        }
    }
}
