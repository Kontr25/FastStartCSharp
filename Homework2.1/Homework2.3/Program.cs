using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. С клавиатуры вводятся числа, пока не будет введен 0.Подсчитать сумму всех нечетных положительных чисел.
            //Бураев

            int summ = 0;
            while (true){
                Console.Write("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    break;
                }
                else
                {
                   if(a % 2 != 0 && a > 0)
                    {
                        summ = summ + a;
                    }
                }

            }
            Console.Write($"Сумма всех введенных нечетных положительных чисел = {summ}");
            Console.ReadLine();
        }
    }
}
