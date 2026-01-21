using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExample08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                Student stu;
                stu.ID = 1;
                stu.Score = 99;
                Student* pStu = &stu;
                pStu -> Score = 100;
                (*pStu).Score = 1000;
                Console.WriteLine(stu.Score);
            }
        }
    }

    struct Student
    {
        public int ID;
        public long Score;
    }
}