using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
            //    по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            //        Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            //Бураев

            Console.Write("Введите координаты точки x1: ");
            Double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты точки y1: ");
            Double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты точки x2: ");
            Double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты точки y2: ");
            Double y2 = Convert.ToDouble(Console.ReadLine());

            Double r = (Math.Sqrt(Math.Pow(x2 - x1, 2)) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:f2}", r);
            Console.ReadKey();
        }
    }
}
