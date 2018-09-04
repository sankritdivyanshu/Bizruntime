using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class serializecollection
    {
        static void Main(string[] args)
        {
            List<string> videogames = new List<string>
           {
              "Starcraft",
              "Halo",
              "Legend of Zelda"
            };

            string json = JsonConvert.SerializeObject(videogames);

            Console.WriteLine(json);
            // ["Starcraft","Halo","Legend of Zelda"]
            Console.Read();
        }
    }
   
}
