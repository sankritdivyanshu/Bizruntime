using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.error
{
    class Class10
    {
       
            static void Main(string[] args)
            {
                Console.WriteLine("Enter first number");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("The result is :" + z);
                Console.WriteLine("End of the Programm");
                Console.Read();


            }
     
    }
}
