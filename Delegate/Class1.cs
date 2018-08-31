using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegate
{
    // Step1 defining the delegate
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);
    class Class1
    {
        public void AddNums(int a , int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)
        {
            return "Hello";
        }
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            //step2 instantiating delegate
            AddDelegate ad = new AddDelegate(c.AddNums);
            // step 3 calling the delegate
            //ad(100, 50);
            ad.Invoke(100, 30);
            SayDelegate sd = new SayDelegate(Class1.SayHello);
           // string str = sd("Hello");
            string str = sd.Invoke("rahul");
            
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
