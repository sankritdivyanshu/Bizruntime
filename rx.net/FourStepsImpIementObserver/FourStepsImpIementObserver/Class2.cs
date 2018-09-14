using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourStepsImpIementObserver
{
    class Class2
    {
        static void Main(string[] args)
        {
            Demo();
            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey();

        }
        static void Demo()
        {
            var observable = new MyRangeObservable(5, 8);
            var observer = new MyObserver<int>();
            var subscription = observable.Subscribe(observer);
            Console.WriteLine("Press any key to dispose the subscription");
            Console.ReadKey();
            subscription.Dispose();

        }
    }
}
