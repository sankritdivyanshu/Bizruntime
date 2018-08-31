using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    interface ClsEmployee8
    {
        void GetEmpData();
        void DisplayEmpData();
    }
    class ClsManager2 : ClsEmployee8
    {
        int EmpId;
        string Ename;
        double CA, Bonus;
        public void GetEmpData()
        {
            Console.WriteLine("Enter Manager Details:");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.Ename = Console.ReadLine();
            this.CA = Convert.ToDouble(Console.ReadLine());
            this.Bonus = Convert.ToDouble(Console.ReadLine());



        }
        public void DisplayEmpData()
        {
            Console.WriteLine("Manager Details are:");
            Console.WriteLine("Manager Id is :" + this.EmpId);
            Console.WriteLine("Manager Name is:" + this.Ename);
            Console.WriteLine("Manager CA is:" + this.CA);
            Console.WriteLine("Manager Bonus is:" + this.Bonus);


        }
       
            static void Main(string[] args)
            {
                ClsManager2 obj = new ClsManager2();
                obj.GetEmpData();
                obj.DisplayEmpData();
                Console.Read();


            }



        
    }
}
