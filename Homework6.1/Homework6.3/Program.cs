using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Homework6._3
{
    class Program
    {
        //3. Переделать программу «Пример использования коллекций» для решения следующих задач:
        //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
        static void Main(string[] args)
        {

            int bakalavr = 0;
            int magistr = 0;
            int ageStudent = 0;
            int[] curs = new int[3];
            int i = 0;
            // Создадим необобщенный список
            ArrayList list = new ArrayList();
            // Запомним время в начале обработки данных
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("HW3.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Console.WriteLine("{0}", s[0], s[1], s[2], s[3], s[4]);
                    list.Add(s[1] + " " + s[0]);// Добавляем склееные имя и фамилию
                    if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
                }
                catch
                {
                }
            }
            StreamReader st = new StreamReader("HW3.csv");
            while (!st.EndOfStream)
            { 
                try
                {
                    string[] b = st.ReadLine().Split(';');
                    if (int.Parse(b[5]) <= 20 && int.Parse (b[5]) >= 18){
                        curs[ageStudent] = int.Parse(b[6]);
                        ageStudent++;
                    }
                }
                catch
                {
                }
            }
            sr.Close();
            list.Sort();
            Console.WriteLine("Всего студентов:{0}", list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalavr);
            foreach (var v in list) Console.WriteLine(v);
            Console.WriteLine("Учеников учащихся на 5 и 6 курсах:{0}", magistr); // Решение подпункта А.
            Console.Write($"Учеников в возрасте от 18 до 20: {ageStudent}, и учатся они на курсах: "); //----------------
            for (i = 0; i < 3; i++)                                                                    //Решение подпункта
            {                                                                                          //         Б
                Console.Write(curs[i] + "-м ");
            }                                                                                          //----------------
            Console.WriteLine();
            // Вычислим время обработки данных
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }
}
