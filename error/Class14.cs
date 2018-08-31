using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.error
{
    class Class14
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Second number can not be Zero");
            }
            else
            {
                c = a / b;
                Console.WriteLine("Quotient is :" + c);
            }
            Console.Read();



        }

    }
}
