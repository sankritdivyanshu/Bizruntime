using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegate
{
    public delegate string GreetingsDelegate(string name);
    class AnnonymousMethod
    {
   
        static void Main(string[] args)
        {
            // GreetingsDelegate obj = new GreetingsDelegate(Greetings);
            GreetingsDelegate obj = delegate (string name)
             {
                 return "hello" + " " + name + " " + "Very Good Morning";
             };



            string str = obj.Invoke("Aishwarya");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
