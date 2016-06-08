using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list1 = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            bool IsEqual = true;
            while (IsEqual)
            {
                IsEqual = false;
                for (int i = 0; i < list1.Count - 1; i++)
                {
                    if (list1[i] == list1[i + 1])
                    {
                        list1[i] *= 2;
                        list1.RemoveAt(i + 1);
                        IsEqual = true;
                    }
                }
            }
            Console.WriteLine(String.Join(" ",list1));

        }
    }
}
