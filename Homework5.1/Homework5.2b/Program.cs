using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Homework5._2b
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Придумайте логин состоящий из латинских букв и цифр (от 2 до 10 символов): ");
            string login = Console.ReadLine();
            int count = 0; // Создал переменную которая будет подсчитывать очки, 
                           //которые будут увеличиваться на +1 если символ в логине соответствует требованиям 
                           //и +100 если не совпадает
            Regex regex1 = new Regex("[0 - 9 | a-z | A-Z]");
            for (int i = 0; i < login.Length; i++)
            {
                if (regex1.IsMatch(login) == true)
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

