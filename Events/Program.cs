using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Events
{
    public delegate void Transformer(int x);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plz enter a number");
            int i = int.Parse(Console.ReadLine());
            Transformer t;
            t = Square;
            t += Cubes;
            t.Invoke(i);
            NotificationMethods obj = new NotificationMethods();
            obj.transformerEvent += user1.Xhandler;
            obj.transformerEvent += user2.Yhandler;
            obj.NotifyOnCell(i);
            Console.ReadLine();

        }
        static void Square(int x)
        {
            Console.WriteLine(x * x);
        }
        static void Cubes(int x)
        {
            Console.WriteLine(x *x*x);
        }
    }
    class NotificationMethods
    {
        public event  Transformer transformerEvent;
        public void NotifyOnCell(int x)
        {
            if(transformerEvent != null)
            {
                transformerEvent(x);
            }

        }
    }
    class user1
    {
          public static void Xhandler(int x)
        {
            Console.WriteLine("Event received by user1 object");
        }
    }
    class user2
    {
        public static void Yhandler(int x)
        {
            Console.WriteLine("Event received by user2 object");
        }
    }

































}
