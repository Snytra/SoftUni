using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list1 = Console.ReadLine().Split('|').Reverse().ToList();
            

            List<int> result = new List<int>();

            foreach (var list in list1)
            {
                List<int> currentList = list.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                result.AddRange(currentList);
            }
            Console.WriteLine(String.Join(" ",result));
        }
    }
}
