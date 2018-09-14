using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq; 

     
namespace FourStepsImpIementObserver
{
    class Class1
    {
        static void Main(string[] args)
        {
            var observable = new MyRangeObservable(5, 8);
            var subscription = observable.Subscribe();
            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey();

        }
    }
}
