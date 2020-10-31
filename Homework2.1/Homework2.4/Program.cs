using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._4
{
    class Program
    { 
        static void Main(string[] args)
        {
            //4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). 
            //Используя метод проверки логина и пароля, написать программу:
            //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            //С помощью цикла do while ограничить ввод пароля тремя попытками.
            //Бураев


            int count = 0;
            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();
                if (login == "root" && password == "GeekBrains")
                {
                    Console.WriteLine("Вы вошли в систему");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неверные данные");
                    count++;
                }
            } while (count < 3);
            Console.ReadLine();
        }
    }
}
