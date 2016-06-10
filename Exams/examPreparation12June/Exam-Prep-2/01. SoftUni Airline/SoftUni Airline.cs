using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftUni_Airline
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalprofit = 0;
            for (int i = 0; i < n; i++)
            {
                int adultCount = int.Parse(Console.ReadLine());
                decimal adultPrice = decimal.Parse(Console.ReadLine());
                int youthCount = int.Parse(Console.ReadLine());
                decimal youthPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
                int fuelComsumptionPerHour = int.Parse(Console.ReadLine());
                int flightDuration = int.Parse(Console.ReadLine());
                decimal incomeProfit = (adultCount * adultPrice) + (youthCount * youthPrice);
                decimal expence = fuelComsumptionPerHour * fuelPricePerHour * flightDuration;
                totalprofit = incomeProfit - expence;

                if (incomeProfit >= expence)
                {
                    Console.WriteLine($"You are ahead with {incomeProfit - expence:F3}$.");
                }
                else if (expence > incomeProfit)
                {
                    Console.WriteLine($"We've got to sell more tickets!We've lost {incomeProfit - expence:F3}$.");
                }

            }
            Console.WriteLine($"Overall profit -> {totalprofit:F3}$.");
            Console.WriteLine($"Average profit -> {totalprofit / n:F3}$.");
        }
       
    }
}
