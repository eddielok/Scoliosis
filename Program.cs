using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Scoliosis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }
       
        public static IWebHost BuildWebHost(string[] args) =>
                WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((webHostBuilder, ConfigurationBinder) => 
                    {
                        ConfigurationBinder.AddJsonFile("settings.json", optional: true);
                    })
                 .UseKestrel(options => {
                     options.Listen(IPAddress.Loopback, 5080); //HTTP port
                 })
                .UseSetting(WebHostDefaults.DetailedErrorsKey, "true")
                .UseStartup<Startup>()
                .Build();
    }
}
