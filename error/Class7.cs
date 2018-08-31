using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.error
{
    class Class7
    {
        static void Main(string[] args)
        {
            unchecked
            {
                int n = int.MaxValue;
                Console.WriteLine(n + 2);
            }
            Console.Read();
           
        }
    }
}
