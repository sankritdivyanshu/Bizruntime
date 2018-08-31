using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegate
{
    class LembdaExpression
    {
        // public static string Greetings(string name)
        //{
        //    return "hello" + name + "a very good morning";
        //}
        static void Main(string[] args)
        {
            // GreetingsDelegate gd = new GreetingsDelegate(Greetings);
            //GreetingsDelegate obj = delegate (string name)
            //{

            //    return "hello" + name + "a very good morning";
            //};
            GreetingsDelegate obj = (name) =>
            {
                return "hello" + name + "a very good morning";
            };
            string str =obj.Invoke("Aish");
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
