using Capacitacion.Core.Divisiones;
using Capacitacion.Core.Multiplicación;
using Capacitacion.Core.Restas;
using Capacitacion.Core.Sumas;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Capacitacion.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IHostEnvironment Environment { get; }

        public Startup(IHostEnvironment env)
        {
            Environment = env;
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings{env.EnvironmentName}.json", true, true)
                .AddEnvironmentVariables();
            //.EnableSubstitutions();
            Configuration = configurationBuilder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            var tipoSumaAdmitida = Configuration.GetSection("ConfiguracionSuma").Get<string>();

            if (tipoSumaAdmitida == "ENTEROS")
                services.AddTransient<ISuma, SumaEnteros>();
            else
                services.AddTransient<ISuma, Suma>();
                
            services.AddTransient<ISuma, Suma>();
            services.AddTransient<IResta, Resta>();
            services.AddTransient<IDivision, Division>();
            services.AddTransient<IMultiplicacion, Multiplicacion>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
