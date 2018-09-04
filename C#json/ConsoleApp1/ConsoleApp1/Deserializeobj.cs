﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Deserializeobj
    {
        static void Main(string[] args)
        {
            string json = @"{
           'Email': 'james@example.com',
           'Active': true,
           'CreatedDate': '2013-01-20T00:00:00Z',
           'Roles': [
           'User',
           'Admin'
            ]
}";

            Account account = JsonConvert.DeserializeObject<Account>(json);

            Console.WriteLine(account.Email);
            // james@example.com
            Console.Read();
        }

    }
    public class Account1
    {
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<string> Roles { get; set; }
    }
}
