using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    class Class2 : Class1
    {
        public  Class2(int a): base(10)
        {
            Console.WriteLine("class 2 constructor is called");
        }
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main(string[] args)
        {
            // Class1 p; // p is variable of class 1
            // Class2 c = new Class2(); // c is instance of class 2
            // p = c;//p is a ref of parent class created by using child class instance
            //
            // p.Test1();
            // p.Test2();
           // object obj = new object();
          //  Console.WriteLine(obj.GetType());
            
           // Console.WriteLine(c1.GetType());
            Class2 c2 = new Class2(50);
            //Console.WriteLine(c2.GetType());
            Console.ReadLine();





        }
    }
}
