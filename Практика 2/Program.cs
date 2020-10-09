using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_2
{
    class Program
    {
        static void Main(string[] args)
        {
            GG Us = new GG();
            Console.WriteLine("Ваши текущие параметры:");
            Console.WriteLine();
            Console.WriteLine($"Имя - {Us.name}");
            Console.WriteLine($"Фамилия - {Us.firstname}");
            Console.WriteLine($"Возраст - {Us.years}");
            Console.WriteLine($"Вес (Кг) - {Us.weight}");
            Console.WriteLine($"Рост (См) - {Us.height}");

            Console.WriteLine();//Имя
            GG.SetName();
            Console.WriteLine();//Фамилия
            GG.Setfirstname();
            Console.WriteLine();//Вес
            GG.Setweight();
            Console.WriteLine();//Рост
            GG.Setheight();
            Console.WriteLine();//Лет
            GG.Setyears();


        }
    }
}
