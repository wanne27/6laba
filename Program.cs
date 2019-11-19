using System;
using System.Diagnostics;

namespace _6laba
{
   
    struct SomeStruct
    {
        public string name;
        public int age;
        public void DisplayNameandAge()
        {
            Console.WriteLine($"Name: {name}, age: {age}");
        }
        public SomeStruct(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    enum pr
    {
        ONE=1, TWO,THREE
    }

    class Program
    {

      
        
        static void Main(string[] args)
        {
                Gym gym = new Gym(4);
            try
            {
               
                 gym[0] = new Mate("one", -1, 25, 15, 224);
                 gym[1] = new Mate("two", 4000, 13, 2, 2424);
               // gym[2] = new Mate("free", 3000, 3, 2, -3);
                gym[3] = new Mate("four", 1000, 100, 92, 1);
                //gym[19] = new Mate();
                


            }
            catch(ItemException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine($"Некорректное значение: {ex.Value}");
                Console.WriteLine($"Некорректное значение в классе: {ex.ErrorClass}");

            }
           
            catch (GymException ex)
            {
                Console.WriteLine($"Ошибка: { ex.Message}");
                Console.WriteLine($"Некорректное значение в классе: { ex.ErrorClass}");
                Console.WriteLine($"Значение: { ex.CountException}");
            }
           finally
            {
                Console.WriteLine("Finally block");
            }
            try
            {


                //int[] arr = new int[5];
                //arr[6] = 7;

                //int p = 10;
                //p = p / 0;

                Object str = "abcd";
                int a = (int)str;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);

            }
            //catch (InvalidCastException e)
           // {
           //     Console.WriteLine("Недопустимое приведение типов");
            //}

            catch (System.IndexOutOfRangeException e)

            {
                Console.WriteLine(e.Message);

            }
            catch
            {
                Console.WriteLine("Произошла ошибка");
            }

            // int[] aa = null;
            //Debug.Assert(!(aa == null), "Values array cannot be null");
            Console.ReadLine();



        }
    }
}
