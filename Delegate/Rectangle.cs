using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegate
{
    public delegate void RectDelegate(double Width, double Height);
    class Rectangle
    {
        public void GetArea(double Width , double Height)
        {
            Console.WriteLine( " Area of rectangle" +(Width * Height));
        }
        public void GetPerimeter(double Width , double Height)
        {
            Console.WriteLine( "Perimeter of rectangle" +(2 * (Width + Height)));
        }
        static void Main(string[] args)
        {
            Rectangle rt = new Rectangle();
            
           // RectDelegate obj = new RectDelegate(rt.GetArea);
            RectDelegate obj1 = rt.GetArea;
            obj1 += rt.GetPerimeter;//holding reference of two method
            obj1.Invoke(12.34,56.78);
            //rt.GetArea(12.3 , 23.4);
            //rt.GetPerimeter(23.4 , 56.7);
            Console.WriteLine();
            obj1.Invoke(23.45, 56.78);
            Console.ReadLine();

        }
    }
}
