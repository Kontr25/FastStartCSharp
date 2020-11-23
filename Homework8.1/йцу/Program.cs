using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace йцу
{
    class Program
    {
        static void Main()
        {
            Type t = typeof(DateTime);
            foreach (var sv in t.GetProperties())
                Console.WriteLine(sv.Name);
            Console.ReadLine();
        }
    }
}