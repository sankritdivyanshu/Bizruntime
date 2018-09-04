using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ConsoleApp1
{
    class EmployeeDataDeser
    {
        public string ReadJsonFile(string JsonfilePath)

        {

            string json = string.Empty;

            using (StreamReader r = new StreamReader("F://abc.json"))

            {

                json = r.ReadToEnd();

                dynamic array = JsonConvert.DeserializeObject(json);

                //... read text from json file

            }

            return json;

        }
        static void Main(string[] args)
        {
            string path = @"F:\abc.json";
            EmployeeDataDeser employeeDataDeser = new EmployeeDataDeser();
            Console.WriteLine(employeeDataDeser.ReadJsonFile(path));
            Console.ReadLine();

        }
    }


}
