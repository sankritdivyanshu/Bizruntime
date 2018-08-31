using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    interface ITestInterface1
    {
        // int x; interface does not contain any fielfs
        void Add(int a, int b);// it contains only 1 method
       
       
    }
    interface ITestInterface2 :ITestInterface1
    {
        void Sub(int a, int b);
        //it contains two mthods
        //one is inherited from 1st interface
    }
    class ImplementationClass :ITestInterface2
    {
        void ITestInterface1.Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        //public  void Add(int a, int b) // mandatory to write public here
        //{
        //    Console.WriteLine(a + b);
        //}
        void ITestInterface2.Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        //public  void Sub(int a, int b) // mandatory to write public here
        //{
        //    Console.WriteLine(a - b);
        //}
        static void Main(string[] args)
        {
            ImplementationClass obj = new ImplementationClass();
            //obj.Add(10, 5);
            //obj.Sub(10, 5);
            ITestInterface2 i = obj; // we can create reference of obj
            i.Add(10, 5);
            i.Sub(10, 5);
            Console.Read();
        }










    }
}
