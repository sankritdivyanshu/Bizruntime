using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace FourStepsImpIementObserver
{
    class implicitcontract
    {
        static void Main(string[] args)
        {
            var subject = new Subject<string>();
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("a");
            subject.OnNext("b");
            subject.OnCompleted();
            subject.OnNext("c");
            Console.Read();
        }
    }
}
