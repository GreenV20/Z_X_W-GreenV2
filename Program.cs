using System;

namespace treugolnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый угол");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй угол");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третий угол");
            int c = int.Parse(Console.ReadLine());
            int result = a + b + c;
            if (result == 180) 
            {
                Console.WriteLine("Такой треугольник есть!!");
            }
            else
            {
                Console.WriteLine("Такого треугольника нету");
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
