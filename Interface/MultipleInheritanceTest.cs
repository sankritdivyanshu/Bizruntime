using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{


    interface Interface1
    {
        void Test();
        void Show();

    }
    interface Interface2
    {
        void Test();
        void Show();
    }
    class MultipleInheritanceTest :Interface1, Interface2
    {
        public void Test()
        {
            Console.WriteLine("Interfaces method Implemented in Child class");//this implementation is for both
            //we r cheating with both the interfaces
            //interface1 just see and tell Wow my Test() is implemented
            //sameway interface2 just see and happpy my Test() is implemented
            //interface1 dont know anything abt interface2
            //interface 2 dont know anything abt interface1

        }
        void Interface1.Show()
        {
            Console.WriteLine("Declared in Interface1 and Implemented in Class");
        }
        void Interface2.Show()
        {
            Console.WriteLine("Declared in Interface2 and Implemented in Class");
        }





        static void Main(string[] args)
        {
            MultipleInheritanceTest obj = new MultipleInheritanceTest();
            obj.Test();
            Interface1 i1 = obj;
            Interface2 i2 = obj;
            i1.Show();
            i2.Show();
            Console.ReadLine();
        }

       
    }
}
