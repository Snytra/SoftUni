using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Last_K_Numbers_Sums_Sequence
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] array = new long[n];
            array[0] = 1;
            for (int i = 1; i < n; i++)
            {
                array[i] = SumNums(array,i - k, i - 1);
            }

            Console.WriteLine("Sequence:");
            Console.WriteLine(String.Join(" ",array));

        }

        private static long SumNums(int[] arr,int startIndex, int endIndex)
        {
            long sum = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (i >= 0) sum += arr[i];
                
            }
            return sum;
        }
    }
}