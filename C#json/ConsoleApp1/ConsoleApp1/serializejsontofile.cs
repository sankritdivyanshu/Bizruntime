using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    public class Movie
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }
   
 
       class serializejsontofile
       {
             static void Main(string[] args)
          {
            Movie movie = new Movie
            {
                Name = "Bad Boys",
                Year = 1995
            };
            // serialize JSON to a string and then write string to a file
            File.WriteAllText(@"F:\abc.json", JsonConvert.SerializeObject(movie));

            // serialize JSON directly to a file
            using (StreamWriter file = File.CreateText(@"F:\abc.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, movie);
            }
            Console.Read();
         }
       
   }
   

}
