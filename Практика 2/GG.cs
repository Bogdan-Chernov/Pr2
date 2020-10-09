using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_2
{
    class GG
    {
        public string name = "Богдан";
        public string firstname = "Чернов";
        public int weight = 67;
        public int height = 176;
        public int years = 17;

        static internal string SetName()
        {
            Console.WriteLine("Введите ваше имя");
            string B = Console.ReadLine();
            Console.WriteLine($"Ваше новое имя - {B}");
            return B;
        }
        static internal string Setfirstname()
        {
            Console.WriteLine("Введите вашу фамилию");
            string C = Console.ReadLine();
            Console.WriteLine($"Ваша новая фамилия - {C}");
            return C;
        }

        static internal int Setweight()
        {
            Console.WriteLine("Введите ваш вес (Кг)");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваш новый вес (Кг) - {A}");
            return A;
        }
        static internal int Setheight()
        {
            Console.WriteLine("Введите ваш рост (См)");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваш новый рост (См) - {A}");
            return A;
        }

        static internal int Setyears()
        {
            Console.WriteLine("Введите ваш возраст");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваш новый возраст - {A}");
            return A;
        }
    }
}
