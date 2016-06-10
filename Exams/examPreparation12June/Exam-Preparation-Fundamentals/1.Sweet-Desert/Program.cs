using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sweet_Desert
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            double priceOfBananas = double.Parse(Console.ReadLine());
            double priceOfEggs = double.Parse(Console.ReadLine());
            double priceOfBerriesKilo = double.Parse(Console.ReadLine());

            var portions = Math.Ceiling(numberOfGuests / 6d);

            double money = portions *
                (2 * priceOfBananas) +
                portions * (4 * priceOfEggs) +
                portions * (0.2 * priceOfBerriesKilo);

            if (money <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {money:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {money - cash:F2}lv more.");
            }
               









        }
    }
}
