using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebStore
{
    public class Startup
    {
        /// <summary>
        /// Свойство для хранения конфигурации
        /// </summary>
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }

        // Метод вызывается средой ASP.NET.

        /// <summary>
        /// Метод подключения сервисов
        /// </summary>
        /// <param name="services">Коллекция сервисов</param>
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // Метод вызывается средой ASP.NET.
        
        /// <summary>
        /// Метод конфигурации подключенных сервисов и настройки конвеера запросов
        /// </summary>
        /// <param name="app">Построитель приложения</param>
        /// <param name="env">Окружение хоста</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // Считываем параметр из конфигурации
            var greetings = Configuration["CustomGreetings"];

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync(greetings);
                });
            });
        }
    }
}
