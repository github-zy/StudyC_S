using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExample02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            double x = c.Add(3.0, 5.0);
            Console.WriteLine(x);
            //delegate
            Action myAction = new Action(c.PrintHello);
            myAction();
        }
    }

    class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
    }
} 