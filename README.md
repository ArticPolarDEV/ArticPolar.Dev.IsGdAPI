# ArticPolar.Dev.IsGdAPI ![Icon](https://raw.githubusercontent.com/JoseLucas1303/ArticPolar.Dev.IsGdAPI/main/logo/icon.png)
Create shortened links, with custom urls, using is.gd API

## Example of Use
````
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticPolar.Dev.IsGdAPI;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync(args).GetAwaiter().GetResult();

            Console.ReadLine();
        }

        static async Task RunAsync(string[] argsArray)
        {
            // Instantiate the IsGdAPI class
            var isGdApi = new IsGdAPI();

            // Call the ShortenUrlAsync method
            string longUrl = argsArray[0];
            string customUrl = argsArray[1];
            string shortenedUrl = await isGdApi.ShortenUrlAsync(longUrl, customUrl);

            // Check if the shortened URL is not null
            if (shortenedUrl != null)
            {
                Console.WriteLine("Shortened URL: " + shortenedUrl);
            }
            else
            {
                Console.WriteLine("Failed to shorten URL.");
            }
        }
    }
}
````

Command: TestConsole.exe https://github.com/JoseLucas1303/ ArticGIT

Out: Short URL: is.gd/(identification)


Example:
Command: TestConsole.exe https://github.com/JoseLucas1303/ ArticGIT

Out: Shortened URL: https://is.gd/ArticGIT

