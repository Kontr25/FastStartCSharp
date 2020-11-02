﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3._1b
{
    class Complex
    {
        private double im;
        double re;

        public Complex()
        {
            im = 0;
            re = 0;
        }

        public Complex(double _im, double re)
        {             
            im = _im;
            this.re = re;
        }
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }
        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1 = new Complex(1, 1);
            Complex complex2 = new Complex(2, 2);
            complex2.Im = 3;
            Complex result;
            result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }

}
