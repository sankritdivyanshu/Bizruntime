using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace FourStepsImpIementObserver
{
    class Class8
    {
        static void Main(string[] args)
        {
         
                var subject = new BehaviorSubject<string>("a");
                subject.OnNext("b");
                subject.Subscribe(Console.WriteLine);
                Console.Read();
            
        }

    }
}
