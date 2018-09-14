using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Threading;

namespace FourStepsImpIementObserver
{
    class Observer :IObserver<int>
    {

        public void OnNext(int value)
        {
         var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"value receivedon thread {threadId}:{value}");
            //Console.WriteLine(value);
        }
        public void OnError(Exception eroor)
        {
        var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"Error reported on thread{threadId}:{eroor.Message}");
        }
        public void OnCompleted()
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"observation completed on thread {threadId}.");
     
        }

    }
}
