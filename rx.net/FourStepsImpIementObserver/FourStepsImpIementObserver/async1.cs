using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Subjects;

namespace FourStepsImpIementObserver
{
    class async1
    {
        static void Main(string[] args)
        {
            var subject = new AsyncSubject<string>();
            subject.OnNext("a");
            WriteSequenceToConsole(subject);
            subject.OnNext("b");
            subject.OnNext("c");
            subject.OnCompleted();
            Console.ReadKey();
        }

        static void WriteSequenceToConsole(IObservable<string> sequence)
        {
            
            sequence.Subscribe(Console.WriteLine);
        }
    }
}
