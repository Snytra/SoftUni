using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string commands = "";
            List<string> list = new List<string>();

            while (commands!= "end")
            {
                commands = Console.ReadLine();
                if (commands == "end")
                {

                }
                else
                {
                    list.Add(commands);
                }
            }

        }
    }
}
