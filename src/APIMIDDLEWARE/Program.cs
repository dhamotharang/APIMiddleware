using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using APIMIDDLEWARE._Functions.Models;
using System;

namespace APIMIDDLEWARE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args)
                .UseUrls($"{Configuration.Current.SoapClient.ClientUrl}")
                .Build()
                .Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
