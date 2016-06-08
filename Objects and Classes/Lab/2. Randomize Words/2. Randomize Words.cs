using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            int count = list.Count;
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                int index = random.Next(0, list.Count);
                Console.WriteLine(list[index]);
                
                
                    
            }
        }
    }
}
