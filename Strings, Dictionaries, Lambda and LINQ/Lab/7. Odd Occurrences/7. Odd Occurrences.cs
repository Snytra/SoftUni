using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = Console.ReadLine().Split(' ').ToList();
            var counts = new SortedDictionary<string,int>();

            foreach (var word in list1)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }
            var result = new List<string>();
            foreach (var item in counts)
            {
                
            }
                
           
        }
    }
}
