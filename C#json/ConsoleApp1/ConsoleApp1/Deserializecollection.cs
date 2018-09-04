using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Deserializecollection
    {
        static void Main(string[] args)
        {
            string json = @"['Starcraft','Halo','Legend of Zelda']";

            List<string> videogames = JsonConvert.DeserializeObject<List<string>>(json);

            Console.WriteLine(string.Join(", ", videogames.ToArray()));
            // Starcraft, Halo, Legend of Zelda
            Console.Read();
        }
    }
}
