using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExample04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(int);
            System.Console.WriteLine(t.Namespace);
            System.Console.WriteLine(t.FullName);
            System.Console.WriteLine(t.Name);
            int c = t.GetMethods().Length;
            foreach (var mi in t.GetMethods())
            {
                System.Console.WriteLine(mi.Name);
            }
            System.Console.WriteLine(c);
        }
    }
}