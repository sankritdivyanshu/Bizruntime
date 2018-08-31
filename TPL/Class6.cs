using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.TPL
{
    class Class6
    {
        static void Main(string[] args)
        {
            var intList = new List<int> {1, 2, 5, 6, 8, 9, 39 , 49 ,59,67,56 };

            // Parallel.ForEach(intList, (i) => Console.WriteLine(i));
            Parallel.For(0, 100, (i) => Console.WriteLine(i));
            Console.WriteLine("press any key to quit");
            Console.Read();

        }








        static void DoSomeVeryImportantWork(int id, int sleeptime)
        {
            Console.WriteLine("task {0} is begining", id);
            Thread.Sleep(sleeptime);
            Console.WriteLine("task {0} has completed", id);
        }
        static void DoSomeOtherVeryImportantWork(int id, int sleeptime)
        {
            Console.WriteLine("task {0} is begining more work", id);
            Thread.Sleep(sleeptime);
            Console.WriteLine("task {0} has completed more work", id);
        }

    }
   
}
 