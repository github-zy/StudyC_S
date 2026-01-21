using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExample06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint x = uint.MaxValue;
            System.Console.WriteLine(x);
            string binStr = Convert.ToString(x,2);
            System.Console.WriteLine(binStr);
            try
            {
                //checked用来检查是否溢出
                uint y = checked(x + 1);
                System.Console.WriteLine(y);
            }
            catch (OverflowException ex)
            {
                System.Console.WriteLine("There's overflow!");
            }
        }
    }
}