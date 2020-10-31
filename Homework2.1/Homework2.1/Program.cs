using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Написать метод подсчета количества цифр числа.
            // Бураев
            int a, b, c;
            Console.Write("Введите первое  число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе  число: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье  число: ");
            c = Convert.ToInt32(Console.ReadLine());
            if(a < b && a < c)
            {
                Console.Write($"Минимальное число: {a}");
            }
            else
            {
                if(c < b)
                {
                    Console.Write($"Минимальное число: {c}");
                }
                else
                {
                    Console.Write($"Минимальное число: {b}");
                }
            }
            Console.ReadLine();

        }
    }
}
