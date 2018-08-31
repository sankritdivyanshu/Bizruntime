using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegate
{
    class ClsDelegate
    {
        static void Dispaly(string s)
        {
            Console.WriteLine("value of s is :" + s);

        }
         delegate void mydelegate(string a);//creating delegate
        static void Main(string[] args)
        {
            mydelegate obj1 = new mydelegate(Dispaly);// create obj to delegate
            obj1("Hello"); // invoking the delegate
            Console.Read();

        }
          


    }
}
