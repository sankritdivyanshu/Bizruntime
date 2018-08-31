using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.error
{



    public class DivideByOddNumberException : ApplicationException
    {

        public override string Message
        {
            get
            {
                return "Attempted to divide by odd number";
            }


        }
    }
    class Class13
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = int.Parse(Console.ReadLine());
            if (y % 2 > 0)
            {
                // throw new ApplicationException("Diviser value can not be odd number");
                throw new ConsoleApp1.DivideByOddNumberException();
            }

            int z = x / y;
            Console.WriteLine("The result is :" + z);


            Console.WriteLine("End of the Programm");
            Console.Read();
        }


    }
}
