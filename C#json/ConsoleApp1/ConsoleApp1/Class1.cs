using System;
using System.Net;
using Newtonsoft.Json;
namespace ConsoleApp1
{
    class Class1
    {
     

        static void Main(string[] args)
        {
            var client = new WebClient();
            var text = client.DownloadString("https://jsonplaceholder.typicode.com/posts/1");
            Post post = JsonConvert.DeserializeObject<Post>(text);
            Console.WriteLine("userId :" + post.userId);
            Console.WriteLine("id :" + post.id);
            Console.WriteLine("title :" + post.title);
            Console.WriteLine("body :" + post.body);




            Console.Read();

              
        }
    }
}
