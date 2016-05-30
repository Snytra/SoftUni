using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            Console.WriteLine(String.Join(" ",)
        }
        static void CompareChar(char [] arr,char[] arr2)
        {
            int min = Math.Min(arr.Length, arr2.Length);
            List<char> az = new List<char>();
            for (int i = 0; i < min; i++)
            {
                     if (arr[i] > arr2 [i])
                 {
                        
                    }
                }
            }
            
            
            
        }
    }
}
