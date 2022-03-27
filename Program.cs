using System;

namespace Цыклы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество повторов сообщения");
            int numberIterations =  Convert.ToInt32( Console.ReadLine());

           for(int i=0;i<numberIterations;i++)
            {
            Console.WriteLine("Hello World!");
            }
        }
    }
}
