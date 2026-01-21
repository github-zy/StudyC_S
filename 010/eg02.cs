using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Form;

namespace OperatorExample01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //点操作符的用途
            //1.访问子名称空间
            //2.访问名称空间中的类型
            //3.访问类型的静态成员
            System.IO.File.Create("D:\\HelloWorld.txt");
            //4.访问对象的成员
            Form myForm = new Form();
            myForm.Text = "Hello, World";
            myForm.ShowDialog();
        }
    }
}