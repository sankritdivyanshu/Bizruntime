using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.error
{
    class Class8
    {
        static void Main(string[] args)
        {
            try
            {
                int[] A = new int[5];
                A[10] = 5;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.Read();

        }
    }
}
