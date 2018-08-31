using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.error
{
    class Class11
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first number");
                int x = int.Parse(Console.ReadLine());// cause runtime error
                Console.WriteLine("Enter second number");
                int y = int.Parse(Console.ReadLine()); // cause runtime error
                int z = x / y; //cause run time error
                Console.WriteLine("The result is :" + z);
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
                //message is a property

            }
            catch (FormatException ex2)
            {
                Console.WriteLine(ex2.Message);
                Console.WriteLine("Input must be numeric");
                //message is a property

            }
            catch (Exception ex)//it sud be last catch block
            {
                Console.WriteLine(ex.Message);
                //it can be catch all exception
            }

            Console.WriteLine("End of the Programm");
            Console.Read();


        }
    }
}
