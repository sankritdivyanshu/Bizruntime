using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace FourStepsImpIementObserver
{
    class Subject
    {
        static void Main(string[] args)
        {
            var subject = new Subject<string>();
            subject.OnNext("a");
            WriteSequenceToConsole(subject);
            subject.OnNext("b");
            subject.OnNext("c");
            Console.ReadKey();
        }

        private static void WriteSequenceToConsole(Subject<string> subject)
        {
            throw new NotImplementedException();
        }
    }
}
