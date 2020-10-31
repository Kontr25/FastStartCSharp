using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Написать метод подсчета количества цифр числа.
            //Бураев

            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while(a != 0) {
                a = a / 10;
                i++;
            }
            Console.Write($"Количество цифр в числе = {i}");
            Console.ReadLine();
        }
    }
}
