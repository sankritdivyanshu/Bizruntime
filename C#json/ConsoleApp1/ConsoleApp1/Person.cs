using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }



    public class Employeee : Person
    {
        public string Department { get; set; }
        public string JobTitle { get; set; }
    }

    public class PersonConverter : CustomCreationConverter<Person>
    {
        public override Person Create(Type objectType)
        {
            return new Employeee();
        }
    }
    public class Hello
    {
        static void Main(string[] args)
        {
            string json = @"{
  'Department': 'Furniture',
  'JobTitle': 'Carpenter',
  'FirstName': 'John',
  'LastName': 'Joinery',
  'BirthDate': '1983-02-02T00:00:00'
}";
            Person person = JsonConvert.DeserializeObject<Person>(json, new PersonConverter());

            Console.WriteLine(person.GetType().Name);
            // Employee

            Employeee employee = (Employeee)person;

            Console.WriteLine(employee.JobTitle);
            // Carpenter
            Console.Read();

        }

    }
}
