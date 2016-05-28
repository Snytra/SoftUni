using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           
            var max = Math.Max(arr.Length, arr2.Length);
            int[] sum = new int[max];

            for (int i = 0; i < max; i++)
            {  
                for (int l = 0; l < max; l++)
                {
                    sum[i] = arr[i % arr.Length] + arr2[i % arr2.Length];
                }
                
            }
            Console.WriteLine(String.Join(" ", sum));

        }
    }
}
