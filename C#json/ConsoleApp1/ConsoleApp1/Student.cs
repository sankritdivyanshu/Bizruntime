using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Net;

namespace ConsoleApp1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public List<string> Hobbies { get; set; }

        public override string ToString()
        {
            return string.Format("Student Information:\n\t Id: {0} ,\n\tName: {1}, Degree{2}\n\t" + "Hobbies: {3}", Id, Name, Degree, string.Join(",", Hobbies.ToArray()));

        }
    }
   

}
