using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExample03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(myIntArray[0]);
            Console.WriteLine(myIntArray[myIntArray.Length - 1]);
            //Dictionary
            Dictionary<string, Student> stuDic = new Dictionary<string, Student>();
            for (int i = 1; i <= 100; i++)
            {
                Student stu = new Student();
                stu.Name = "s_" + i.ToString();
                stu.Score= 100 + i;
                stuDic.Add(stu.Name, stu);
            }

            Student number6 = stuDic["s_6"];
            Console.WriteLine(number6.Score);
        }

        class Student
        {
            public string Name;
            public int Score;
        }
    }
}