using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] sum = new int[k];

            Array.Reverse(sum);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int l = 0; l < arr.Length * 2 *k; l++)
                {
                    
                }
            }
            Console.WriteLine(String.Join(" ",sum));
        }
    }
}
