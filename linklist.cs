using System;
using System.Collections.Generic;
using System.Text;

namespace _6laba
{
    class Gym 
    {
        private static Item[] itemArr;
        private int maxIndex;
        public int size = 0;
        public Item this[int index]
        {
            get
            {


                if (index > maxIndex)
                {
                    throw new GymException("Элемента с таким индексом не существует", index, maxIndex);

                }
                return itemArr[index];
                
            }
            set
            {
                size++;
                if (index > maxIndex)
                    throw new GymException("Превышен максимальный индекс массива", index, maxIndex);
                else
                    itemArr[index] = value;

            }
        }
        public Gym(int maxIndex)
        {
            this.maxIndex = maxIndex - 1;
            itemArr = new Item[maxIndex];
        }
        public static void show()
        {
            foreach (Item it in itemArr)
                it.GetVehicleInf();
        }
    }
}
