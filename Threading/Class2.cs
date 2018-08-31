using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Threading
{
    class Class2
    {
        private static object thread;

        static void Test1()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Test1:" + i);
            }
            Console.WriteLine("Thread 1 is exiting");
        }
        static void Test2()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Test2:" + i);
                if (i == 50)
                    Console.WriteLine("Thread2 is going to sleep");
                Thread.Sleep(5000);
                Console.WriteLine("Thread2 woke up");
            }
            Console.WriteLine("Thread 2 is exiting");
        }
        static void Test3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Test3:" + i);
            }
            Console.WriteLine("Thread 3 is exiting");
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main thread is exiting");

            Console.Read();











        }
    }
}
