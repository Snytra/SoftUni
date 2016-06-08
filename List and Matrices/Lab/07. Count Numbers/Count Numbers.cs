using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            list.Sort();

            int counter = 0;

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i-1])
                {
                    counter++;
                    if (list[i] != list[i - 1])
                    {
                        Console.WriteLine(list[i] + "->" + counter);
                        counter = 0;
                    }
                }
                

            }
            Console.WriteLine(String.Join(" ",list));
            
        }
    }
}
