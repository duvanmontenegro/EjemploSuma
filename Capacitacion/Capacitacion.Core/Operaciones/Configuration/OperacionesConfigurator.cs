using Capacitacion.Core.Operaciones.Divisiones;
using Capacitacion.Core.Operaciones.Multiplicación;
using Capacitacion.Core.Operaciones.Restas;
using Capacitacion.Core.Operaciones.Sumas;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;

namespace Capacitacion.Core.Operaciones.Configuration
{
    public static class OperacionesConfigurator
    {
        /// <summary>
        /// Permite configurar y utilizar el microservicio de operaciones  <see cref="System.Console.WriteLine(System.String)"/>
        /// </summary>
        /// <param name="services">Colector de servicios que contiene la el catalogo de la aplicación</param>
        /// <param name="configTipoSuma"> Parametro obligatorio que me permite trabajar con ENTEROS o DECIMALES</param>
        [DebuggerStepThrough]
        public static void ConfigureOperacionesService(this IServiceCollection services, string configTipoSuma)
        {
            if (string.IsNullOrEmpty(configTipoSuma))
                throw new ArgumentNullException($" el parametro: {nameof(configTipoSuma)} es requerido para el metodo: {nameof(ConfigureOperacionesService)} en " +
                    $"la clase {nameof(OperacionesConfigurator)}");

            services.AddTransient<IResta, Resta>();
            services.AddTransient<IDivision, Division>();
            services.AddTransient<IMultiplicacion, Multiplicacion>();
            services.AddTransient<ISumaIntegral, SumaIntegral>();
            services.AddTransient<ISuma, Suma>();
            services.AddTransient<ISumaRedondeada, SumaRedondeada>();
        }
    }
}
