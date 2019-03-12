using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ChallengeClub
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
           
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(b =>
            {
                b.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
<<<<<<< HEAD
=======
                .AddJsonFile("appsettings.darwin.json", optional: true, reloadOnChange: false)
>>>>>>> 3b54639247ddc161625153995426b83f33240982
                .Build();
            })
                .UseStartup<Startup>();
    }
}
