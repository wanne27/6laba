using System;
using System.Collections.Generic;
using System.Text;

namespace _6laba
{
    class Bench : Item
    {
        public Bench(string name, int cost, int lenght, int width, int area)
        : base(name, cost, lenght, width, area)
        {

        }

        public override string ToString()
        {

            Console.WriteLine("Данные об объекте : ");

            Console.WriteLine($"Стоимость : {cost}");

            Console.WriteLine($"Длина : {length}");

            Console.WriteLine($"Ширина : {width}");

            Console.WriteLine($"Имя :  {name}");


            return $" {name} {length} {width} {cost}";
        }
    }
}
