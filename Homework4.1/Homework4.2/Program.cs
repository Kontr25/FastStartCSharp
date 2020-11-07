using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._1
{
    class StaticClass
    {
        public static int Check(int a, int b)
        {
            if (a % 3 == 0 || b % 3 == 0)
            {
                int result = 1;
                return result;
            }
            else
            {
                int result = 0;
                return result;
            }

        }
    }
    class Program
    {
        
    static void Main(string[] args)
        {
            Console.WriteLine("Даны числа: ");
            int[] myArray = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                int value = rnd.Next(-10000, 10000);
                myArray[i] = value;
                Console.WriteLine(myArray[i]);
            }
            
            int v = 0;
            for (int i = 0; i < myArray.Length/2; i = i + 2)
            {
                int b = i + 1;
                if(StaticClass.Check(myArray[i], myArray[b])== 1)
                {
                    v = v + 1;
                }

            }

            Console.WriteLine("Kоличество пар элементов массива, в которых только одно число делится на 3 = " + v);
            Console.ReadLine();
        }
    }
}
