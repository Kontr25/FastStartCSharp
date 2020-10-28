using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу обмена значениями двух переменных:
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.
            //Бураев

            Console.Write("Введите значение для переменной а: ");
            String a = Console.ReadLine();
            Console.Write("Введите значение для переменной b: ");
            String b = Console.ReadLine();
            string c = b;
            b = a;
            a = c;
            Console.WriteLine($"После обмена значений переменная a приняла значение: {a} ,a переменная b значение: {b}");
            Console.ReadLine();

        }
    }
}
