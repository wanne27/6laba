using System;
using System.Collections.Generic;
using System.Text;

namespace _6laba
{
    class Mate : Item
    {
        
        public Mate()
        {
            name = "";
            cost = 0;
            length = 0;
            width = 0;
            area = 0;
        }
        public Mate (string name, int cost, int lenght,int width,int area)
        : base(name,cost,lenght,width,area)
        {

        }
        public override string ToString()
        {

            Console.WriteLine("Данные об объекте : ");



            Console.WriteLine($"Длина : {length}");


            Console.WriteLine($"Ширина : {width}");

            Console.WriteLine($"Площадь : {area}");

            Console.WriteLine($"Стоимость :  {cost}");

            Console.WriteLine($"Имя :  {name}");

            return $" {name} {length} {width} {area} {cost}";
        }
    }
}
