using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Collections;

namespace ConsoleApp1
{

    class Class2
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "Balaji",
                Degree = "BE",
               Hobbies = new List<string>()
              {
                 "Reading",
                 "Playing games"
              }
          };
            string strResultJson = JsonConvert.SerializeObject(student);
           
            //Console.WriteLine(strResultJson);
            File.WriteAllText(@"student.json", strResultJson);
            Console.WriteLine("stored!");
         
            strResultJson = string.Empty;
            strResultJson = File.ReadAllText(@"student.json");
           // Student resultstudent =JsonConvert.DeserializeObject<Student>(strResultJson);
           // Console.WriteLine(resultstudent.ToString());

           var dictionary= JsonConvert.DeserializeObject<IDictionary>(strResultJson);
            foreach(DictionaryEntry entry in dictionary)
            {
                Console.WriteLine(entry.Key + ":" + entry.Value); 
            }


            Console.Read();
        }
    }
}
