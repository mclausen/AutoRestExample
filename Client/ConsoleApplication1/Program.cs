using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using AutoRestTest;
using AutoRestTest.Models;
using Newtonsoft.Json;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            WebApplication2 a = new WebApplication2(new Uri("http://localhost:54403/"));
            var hello = a.Test.TestWithHttpMessagesAsync(new Request() {Name = "Martin"}).Result;

            var message = JsonConvert.DeserializeObject<Response>(hello.Body.ToString());
            Console.WriteLine("Message:");
            Console.WriteLine(message.Message);
            Console.WriteLine(string.Join(", ", message.Properties));
            Console.WriteLine(message.Advanced.A);
            Console.WriteLine(message.Advanced.B);

            Console.ReadLine();
        }

        public class Response
        {
            public string Message { get; set; }
            public List<string> Properties { get; set; } 

            public Advanced Advanced { get; set; }
        }

        public class Advanced
        {
             public string A { get; set; }

             public int B { get; set; }
        }
    }
}
