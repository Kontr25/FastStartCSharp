using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Ввести вес и рост человека. 
            //Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
            //где m — масса тела в килограммах, h — рост в метрах.
            //Бураев

            Console.Write("Введите ваш вес: ");
            Double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ваш рост: ");
            Double h = Convert.ToDouble(Console.ReadLine());

            Double imt = (m / (h * h));
            Console.WriteLine($"ИМТ = {imt}");
            Console.ReadLine();


        }
    }
}
