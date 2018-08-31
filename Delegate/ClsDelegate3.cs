using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegate
{
    class ClsDelegate3
    {
        public void Add(int a , int b)
        {
            Console.WriteLine("Sum is :" + (a + b));
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("Difference is :" + (a - b));
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine("Multiplication is :" + (a * b));
        }
        public void Div(int a, int b)
        {
            Console.WriteLine("Division is :" + (a / b));
        }
    }
    public delegate void MCDelegate(int a, int b);
    class ClsMulticast
    {
        static void Main(string[] args)
        {
            ClsDelegate3 obj1 = new ClsDelegate3();
            MCDelegate objd = new MCDelegate(obj1.Add);

            objd += obj1.Sub;
            objd += obj1.Mul;
            objd += obj1.Div;

            objd(10, 20);

            objd -= obj1.Div;
            objd -= obj1.Mul;

            objd(30, 40);
            Console.Read();










            



        }

    }
         
}















