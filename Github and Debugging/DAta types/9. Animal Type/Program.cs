﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string animalType = Console.ReadLine();

            switch (animalType)
            {
                case "dog": Console.WriteLine("mammal");break;
                case "crocodile": Console.WriteLine("reptile");break;
                case "snake": Console.WriteLine("reptile");break;
                case "tortoise": Console.WriteLine("reptile");break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
