using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourStepsImpIementObserver
{
     internal class MyObserver<T> : IObserver<T>
    {
        private string _name = null;
        public MyObserver(string subscriberName ="subscriber1")
        {
            _name = subscriberName;
        }
        public virtual void OnCompleted()
        {
            Console.WriteLine($"observation completed by {_name}.");

        }
        public virtual void OnError(Exception error)
        {
            Console.WriteLine($"An error occured while {_name} was obsrving:{error.Message}");

        }
        public virtual void OnNext( T value)
        {
            Console.WriteLine($"{_name} received: {value.ToString()}");

        }

    }
}
