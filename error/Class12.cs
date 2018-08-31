using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.error
{
    class Class12
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Enter first number");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int y = int.Parse(Console.ReadLine());
                if (y == 1)
                {
                    return;
                }
                int z = x / y;
                Console.WriteLine("The result is :" + z);
            }
            //catch(Exception ex)//it will handle all exception
            //{
            //    Console.WriteLine(ex.Message);
            //}
            finally
            {
                Console.WriteLine("finally block is executed");
            }
            Console.WriteLine("End of the Programm");
            Console.Read();


        }//end of the method

    }// end of the class

}

