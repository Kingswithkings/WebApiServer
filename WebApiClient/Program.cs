using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApiClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("Press Any Key Cont...");
            Console.ReadLine();


            using(System.Net.Http.HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:44331/api/Values");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    string message = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine($"response error code: {response.StatusCode}");
                }
            }

            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
