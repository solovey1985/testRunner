using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MusicHttpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from 25 of May London");
            Console.WriteLine("Hello new GIT Commit!");
            Console.ReadKey();
        }


        public static async Task<HttpContent> GetRequest()
        {
            HttpClient client = new HttpClient();
            var result = await client.SendAsync(new HttpRequestMessage()
            { RequestUri = new Uri(@"https://www.ukr.net/") }
            );
            return result.Content;
        }
        
    }
}
