﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcExample
{
    public class Calc
    {
        public void Add(double n1, double n2)
        {
            Console.WriteLine("Result after addition:\t"+(n1 + n2));
            }
        public void sub(double n1, double n2)
        {
            Console.WriteLine("Result after Subtraction:\t" + (n1 -n2));
        }
        public void Multi(double n1, double n2)
        {
            Console.WriteLine("Result after Multiplication:\t"+(n1 *n2)); 
               
        }
        public void Div(double n1, double n2)
        {
            Console.WriteLine("Result after Divison:\t"+(n1 / n2));

        }
    }
}
