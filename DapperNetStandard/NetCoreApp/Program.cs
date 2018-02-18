using DapperNetStandard;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApp
{
    class Program
    {
        private const string ConnectionString = @"";

        static async Task Main(string[] args)
        {
            do
            {
                Console.Write("\nWrite the query you want to search: ");
                var query = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(query))
                {
                    break;
                }

                Console.WriteLine("Getting information...");

                var database = new Places(ConnectionString);
                var places = await database.SearchAsync(query);
                if (places.Any())
                {
                    foreach (var place in places)
                    {
                        Console.WriteLine($"\r\n{place.Name}\r\n{place.Description}\r\n");
                    }
                }
                else
                {
                    Console.WriteLine("Tag not found.");
                }

            } while (true);
        }
    }
}
