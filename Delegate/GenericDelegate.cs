using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegate
{
    //public delegate double Delegate1(int x , float y , double z );
    //public delegate void Delegate2(int x, float y, double z);
    //public delegate bool Delegate3(string str);

    class GenericDelegate
    {
        //public static double AddNums1(int x , float y, double z)
        //{
        //    return x + y + z;
        //}
        //public static void  AddNums2(int x, float y, double z)
        //{
        //    Console.WriteLine(x + y + z);

        //}
        //public static bool CheckLength(string str)
        //{
        //    if (str.Length > 5)
        //        return true;
        //        return false;
                   
        //}
        static void Main(string[] args)
        {
            //Delegate1 obj1 = new Delegate1(AddNums1);
            //Func<int, float, double, double> obj1 = AddNums1;
            Func<int, float, double, double> obj1 = (x, y, z) =>
            {
                return x + y + z;
            };
            double result = obj1.Invoke(2, 3.45f, 5.56);
            Console.WriteLine(result);

            // Delegate2 obj2 = AddNums2;
            //Action<int, float, double> obj2 = AddNums2;
            Action<int, float, double> obj2 = (x, y, z) =>
             {
                 Console.WriteLine(x + y + z);
             };
            obj2.Invoke(2, 3.45f, 5.56);


            // Delegate3 obj3 = CheckLength;
            // Predicate<string> obj3 = CheckLength;
            // Func<string , bool> obj3 = CheckLength;
            Predicate<string> obj3 = (str) =>
             {
                 if (str.Length > 5)
                     return true;
                 return false;
             };
            bool status = obj3.Invoke("Hello World");
            Console.WriteLine(status);
            Console.Read();
          

























        }
    }
}
