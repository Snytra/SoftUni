using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int theDay = int.Parse(Console.ReadLine());

            if (theDay >= 1 && theDay <= 7)
            {
                Console.WriteLine(daysOfWeek[theDay - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
