using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            //1. Написать программу «анкета». последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). в результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.
            //Бураев 


            Console.Write("Введите ваше имя: ");
            String name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            String surname = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            String age = Console.ReadLine();
            Console.Write("Введите ваш рост: ");
            String height = Console.ReadLine();
            Console.Write("Введите ваш вес: ");
            String weight = Console.ReadLine();

            Console.WriteLine("1. " + "Имя: " + name + " Фамилия: " + surname + " Возраст: " + age + " Рост: " + height + " Вес: " + weight);
            Console.WriteLine("2. Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", name, surname, age, height, weight);
            Console.WriteLine($"3. Имя: {name} Фамилия: {surname} Возраст: {age} Рост: {height} Вес: {weight}");
            Console.ReadLine();




        }
    }
}
