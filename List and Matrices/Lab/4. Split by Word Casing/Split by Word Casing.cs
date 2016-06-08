using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arry = new char[] { ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' ' };
            List<string> list = Console.ReadLine()
                .Split(arry,StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();
            int countUpper = 0;
            int countLower = 0;


            foreach (var item in list)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (char.IsUpper(item[i]))
                    {
                        countUpper++;
                    }
                    else if (char.IsLower(item[i]))
                    {
                        countLower++;
                    }

                }
                if (countLower == item.Length)
                {
                    lowerCase.Add(item);
                }
                else if (countUpper == item.Length)
                {
                    upperCase.Add(item);
                }
                else
                {
                    mixedCase.Add(item);
                }
                countLower = 0;
                countUpper = 0;
            }
            Console.Write("Lower case: ");
            Console.WriteLine(String.Join(", ", lowerCase));
            Console.Write("Mixed case: ");
            Console.WriteLine(String.Join(", ", mixedCase));
            Console.Write("Upper case: ");
            Console.WriteLine(String.Join(", ", upperCase));
            
        }
    }
}
