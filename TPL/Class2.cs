using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.TPL
{
    class Class2
    {
        static void Main(string[] args)
        {

            var t1 =Task.Factory.StartNew(() => DoSomeVeryImportantWork(1, 1500));
            var t2 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(2, 3000));
            var t3 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(3, 1000));
           

            Console.WriteLine("presss any key to quit");
            Console.ReadKey();
        }
        static void DoSomeVeryImportantWork(int id, int sleeptime)
        {
            Console.WriteLine("task {0} is begining", id);
            Thread.Sleep(sleeptime);
            Console.WriteLine("task {0} is completed", id);
        }
    }
}
