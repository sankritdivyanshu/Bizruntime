using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.TPL
{
    class Class4
    {

            static void Main(string[] args)
            {

                var t1 = Task.Factory.StartNew(() => DoSomeOtherVeryImportantWork(1, 100)).ContinueWith((prevTask) => DoSomeOtherVeryImportantWork(1, 1000));
                var t2 = Task.Factory.StartNew(() => DoSomeOtherVeryImportantWork(2, 2000)).ContinueWith((prevTask) => DoSomeOtherVeryImportantWork(1, 1000));
                var t3 = Task.Factory.StartNew(() => DoSomeOtherVeryImportantWork(3, 500)).ContinueWith((prevTask) => DoSomeOtherVeryImportantWork(1, 1000));

            var tasklist = new List<Task> { t1, t2, t3 };
            Task.WaitAll(tasklist.ToArray());
            for(int i=1; i < 10; i++)
            {
                Console.WriteLine("doing some other work");
                Thread.Sleep(250);
                Console.WriteLine("i = {0}", +i); 
            }


                Console.WriteLine("presss any key to quit");
                Console.ReadKey();
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
