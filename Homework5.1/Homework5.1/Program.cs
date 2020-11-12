using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Homework5._1
{
    class Program
    {
        static public bool isNumber(char c)
        {
            return c >= '0' && c <= '9';
        }//Проверка является ли символ числом
        static public bool isLower(char c)
        {
            return c >= 'a' && c <= 'z';
        }//Проверка является ли символ латинской буквой
        static void Main(string[] args)
        {
            Console.Write("Придумайте логин состоящий из латинских букв и цифр (от 2 до 10 символов): ");
            string login = Console.ReadLine();
            int count=0; // Создал переменную которая будет подсчитывать очки, 
                            //которые будут увеличиваться на +1 если символ в логине соответствует требованиям 
                            //и +100 если не совпадает
            for (int i = 0; i < login.Length; i++)
            {
                if (isNumber(login[i]) == true || isLower(login[i]) == true)
                {
                    count++;
                }
                else
                {
                    count = count + 100;
                }
            }
            if (count < 11 && count > 1)
            {
                Console.WriteLine("Логин создан");
            }
            else
            {
                Console.WriteLine("Логин не создан, проверте соблюдены ли все требования^\n1. Длина логина 2-10 символов \n2. Использовать только цифры и латинские буквы");
            }
            Console.ReadLine();
        }
    }
}
