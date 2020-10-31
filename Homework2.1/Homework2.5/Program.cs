using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._5
{
    class Program
    {

        static void  rec (double I, double m, double h)
        {
            //5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы 
            //и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            //Бураев

            if (I < 21.6){
                double m2 = 21.6 * (h * h);
                double difference = m2 - m;
                difference = Math.Round(difference, 2);
                Console.Write("Вам желательно набрать как минимум: " + difference + " кг");
            }else if(I > 24.9)
            {
                double m2 = 24.9 * (h * h);
                double difference = m - m2;
                difference = Math.Round(difference, 2);
                Console.Write("Вам желательно сбросить как минимум: " + difference + " кг");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите вашу массу: ");
            double m = Convert.ToDouble (Console.ReadLine());
            Console.Write("Введите ваш рост в метрах (например 1,85): ");
            double h = Convert.ToDouble (Console.ReadLine());
            double I = m / (h * h);
            I = Math.Round(I, 2);
            Console.WriteLine($"Ваш ИМТ равен: {I}");
            if(I < 18)
            {
                Console.WriteLine("У вас выраженный дефицит массы тела.");
                rec(I,m,h);
            }else if(I >= 18 && I <= 21.5){
                Console.WriteLine("У вас недостаточная (дефицит) масса тела.");
                rec(I, m, h);
            }
            else if(I >= 21.6 && I <= 24.9)
            {
                Console.WriteLine("Ваш индекс массы тела в норме.");
            }else if(I >= 25 && I <= 29.5)
            {
                Console.WriteLine("У вас избыточная масса тела (предожирение)");
                rec(I, m, h);
            }
            else if(I >= 29.6 && I <= 31.9)
            {
                Console.WriteLine("У вас ожирение первой степени");
                rec(I, m, h);
            }
            else if(I >= 32 && I <= 37)
            {
                Console.WriteLine("У вас ожирение второй степени");
                rec(I, m, h);
            }
            else
            {
                Console.WriteLine("У вас ожирение третьей степени");
                rec(I, m, h);
            }
            Console.ReadLine();

        }
    }
}
