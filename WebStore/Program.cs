using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore
{
    public class Program
    {
        public static void Main(string[] args) =>
            CreateHostBuilder(args)
            .Build()
            .Run();


        /// <summary>
        /// Метод постороения хоста
        /// </summary>
        /// <param name="args">Набор параметров для конфигурирования хоста</param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>(); // Конфигурирование хоста с помощью класса Startup
                });
    }
}
