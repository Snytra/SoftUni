using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;
            for (int a = 0; a < arr.Length - 1; a++)
            {
                for (int b = a + 1; b < arr.Length; b++)
                {
                    int c = arr[a];
                    int d = arr[b];
                    int sum = c + d;
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine($"{c} + {d} == {sum}");
                        count++;
                    }
                
                }
                
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }

        }
    }
}
