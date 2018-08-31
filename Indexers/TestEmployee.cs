using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Indexers
{
    class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1001, "scott", "Manager", "sales", "Mumbai", 2345.00);
            Console.WriteLine("Eno:" + emp[1]);
            Console.WriteLine("Ename:" + emp[2]);
            Console.WriteLine("EDname:" + emp[3]);
            Console.WriteLine("Job:" + emp[4]);
            Console.WriteLine("ELocation:" + emp[5]);
            Console.WriteLine("Esalary:" + emp[6]);

            emp[1] = 1002;
            emp[2] = "duggu";
            


            emp[6] = 25000.00;
            emp["Location"] = "Bangalore";

            Console.WriteLine();


            Console.WriteLine("Eno:" + emp["Eno"]);
            Console.WriteLine("Ename:" + emp["Ename"]);
            Console.WriteLine("EDname:" + emp["Dname"]);
            Console.WriteLine("Job:" + emp["Job"]);
            Console.WriteLine("ELocation:" + emp["Location"]);
            Console.WriteLine("Esalary:" + emp["salary"]);


            Console.ReadLine();

        }
    }
}
