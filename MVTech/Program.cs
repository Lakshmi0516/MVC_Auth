using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;

namespace MVTech
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
       WebHost.CreateDefaultBuilder(args)
           .UseStartup<Startup>();
    }
}
