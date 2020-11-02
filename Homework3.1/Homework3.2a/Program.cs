using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3._2a
{
    class Program
    {
        static void check(string a, int c)
        {
            bool results = int.TryParse(a, out c);
            if (results)
            {

            }
            else
            {
                Console.WriteLine("Вы ввели некоректные данные!");
            }
        }
        static void Main()
        {
            String a = "";
            int d = 0;
            string b = "";
            while (a != "0")
            {
                a = Console.ReadLine();
                int c;
                int.TryParse(a, out c);
                check(a, c);
                if ( c % 2 != 0)
                {
                    d = d + c;
                    Convert.ToString(c);
                    b = b + c + " , ";
                }
                
            }
            Console.WriteLine("Нечетные числа: " + b + "а их сумма равна: " + d);
            Console.ReadLine();
            
        }
    }

}
