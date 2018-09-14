using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Threading;

namespace FourStepsImpIementObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"Program started on main thread with Id{threadId}...");
            //step1. create the observable
           var observable = Observable.Range(5,8);

            //step2. subscribe to the observable
            var subscription = observable.Subscribe(new Observer());
            Console.ReadKey();
            subscription.Dispose();
        }
    }
} 
