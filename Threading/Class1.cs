using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Threading
{
    class Class1  
    {


        static void Test1()
        {
            for(int i=1;i<=100; i++)
            {
                Console.WriteLine("Test1:" + i);
            }
        }
        static void Test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i==50)
                {
                    Console.WriteLine("Main thread going to sleep");
                    Thread.Sleep(5000);// 5sec
                    Console.WriteLine("Main thread woke up");
                }
                Console.WriteLine("Test2:" + i);
            }
        }
        static void Test3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test3:" + i);
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Thread t = Thread.CurrentThread;
            //t.Name = "Main thread";
            //   Console.WriteLine("current executing thread" + Thread.CurrentThread.Name);
            Test1();
            Test2();
            Test3();
            Console.Read();

        }
    }
}
