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
        /// �������� ��� �������� ������������
        /// </summary>
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }

        // ����� ���������� ������ ASP.NET.

        /// <summary>
        /// ����� ����������� ��������
        /// </summary>
        /// <param name="services">��������� ��������</param>
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // ����� ���������� ������ ASP.NET.
        
        /// <summary>
        /// ����� ������������ ������������ �������� � ��������� �������� ��������
        /// </summary>
        /// <param name="app">����������� ����������</param>
        /// <param name="env">��������� �����</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // ��������� �������� �� ������������
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
