using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.TPL
{
    class Class1
    {
        static void Main(string[] args)
        {
           
            var t1 = new Task(() => DoSomeVeryImportantWork(1, 1500));
            t1.Start();
            var t2 = new Task(() => DoSomeVeryImportantWork(2, 3000));
            t2.Start();

            var t3 = new Task(() => DoSomeVeryImportantWork(3, 1000));
            t3.Start();

            Console.WriteLine("presss any key");
            Console.ReadKey();
        }
        static void  DoSomeVeryImportantWork(int id, int sleeptime)
        {
            Console.WriteLine("task {0} is begining", id);
            Thread.Sleep(sleeptime);
            Console.WriteLine("task {0} is completed", id);
        }
    }
}
