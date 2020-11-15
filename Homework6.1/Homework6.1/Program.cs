using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6._1
{
    // Описываем делегат. В делегате описывается сигнатура методов, на
    // которые он сможет ссылаться в дальнейшем (хранить в себе)
    public delegate double Fun(double x, double a);
    class Program
    {
        // Создаем метод, который принимает делегат
        // То есть на практике, этот метод сможет принимать любой метод
        // с такой же сигнатурой как у делегата
        public static void Table(Fun F, double x, double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= a)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x, double a)
        {
            return a * x * x;
        }
        public static double Sinus(double x, double a)
        {
            return a * Math.Sin(x);
        }
        static void Main()
        {
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции a*x^2:");
            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(delegate (double x, double a) { return a * x * x; }, 0, 4);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            Console.WriteLine("Таблица функции a*sin(x):");
            Table(delegate (double x, double a) { return a * Math.Sin(x); }, 0, 4);
            Console.ReadLine();
        }

    }
}
