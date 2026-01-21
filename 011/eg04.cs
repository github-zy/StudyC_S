using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = sizeof(decimal);
            unsafe
            {
                int y = sizeof(Student);
            }
        }
    }

    struct Student
    {
        int ID;
        long Score;
    }
}