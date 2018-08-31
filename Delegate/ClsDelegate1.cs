using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegate
{
    class ClsDelegate1
    {
        public void Display(string s)
        {
            Console.WriteLine("value of s is :" + s);
        }
    }
    public delegate void Sampledelegate(string s);
    class ClsDelegate2
    {
        static void Main(string[] args)
        {
            ClsDelegate1 obj1 = new ClsDelegate1();//create the obj of those class in which function is present

            Sampledelegate sd = new Sampledelegate(obj1.Display);//create object of delegate
            sd("welcome");//invoking
            Console.Read();
        }
    }
}
