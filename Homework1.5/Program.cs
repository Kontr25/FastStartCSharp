using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) *Сделать задание, только вывод организовать в центре экрана.
            //в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
            //Бураев

            String name = "Артём";
            String surname = "Бураев";
            String city = "Тольятти";
            Console.WriteLine($"Имя: {name}\nФамилия: {surname}\nГород проживания: {city}");
            Console.ReadLine();
            
        }
    }
}
