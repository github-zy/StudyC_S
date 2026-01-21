using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorsExample05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //{}是初始化器，()是构造器
            Form myForm = new Form() { Text = "Hello"};
            System.Console.WriteLine(myForm.Text);
            //匿名对象
            new Form() { Text = "Hello"}.ShowDialog();
            //匿名类型
            var person = new {Name = "Mr.Okay", Age = 34};
            System.Console.WriteLine(person.Name);
            System.Console.WriteLine(person.Age);
            System.Console.WriteLine(person.GetType().Name);
        }
    }
}