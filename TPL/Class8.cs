    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1.TPL
{
    class Class8
    {
        public static void Main()
        {
            // use an Action delegate and named method
            Task task1 = new Task(new Action(printMessage));
            // use an anonymous delegate
            Task task2 = new Task(delegate { printMessage(); });
            // use a lambda expression and a named method
            Task task3 = new Task(() => printMessage());
            // use a lambda expression and an anonymous method
            Task task4 = new Task(() => { printMessage(); });

            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();
            Console.WriteLine("Main method complete. Press <enter> to finish.");
            Console.ReadLine();
        }
        private static void printMessage()
        {
            Console.WriteLine("Hello, world!");
        }
    }
}
