/*
 * Author: Eric Honas
 * Class name: Program.cs
 * Purpose: Class used as the entry point.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Website
{
    /// <summary>
    /// A class that acts as the entry point.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Runs the website using a webserver.
        /// </summary>
        /// <param name="args">Command line arguments</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates and returns a host.
        /// </summary>
        /// <param name="args">Command line arguments</param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
