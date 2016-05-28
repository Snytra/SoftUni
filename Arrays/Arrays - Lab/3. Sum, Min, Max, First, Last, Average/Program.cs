using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum__Min__Max__First__Last__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(array.Sum());
            Console.WriteLine(array.Min());
            Console.WriteLine(array.Max());
            Console.WriteLine(array.First());
            Console.WriteLine(array.Last());
            Console.WriteLine(array.Average());


        }
    
    }
}
