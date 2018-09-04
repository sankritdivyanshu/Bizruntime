using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ConsoleApp1
{
    class DeserializeJsonfromfile 
    {
        static void Main(string[] args)
        {
            // read file into a string and deserialize JSON to a type
            Movie movie1 = JsonConvert.DeserializeObject<Movie>(File.ReadAllText(@"F:\abc.json"));

            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(@"F:\abc.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                Movie movie2 = (Movie)serializer.Deserialize(file, typeof(Movie));

            }
            Console.Read();
        }
    }
   
}
