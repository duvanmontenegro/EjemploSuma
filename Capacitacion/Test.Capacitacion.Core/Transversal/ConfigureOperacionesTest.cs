using Capacitacion.Core.Operaciones.Configuration;
using Capacitacion.Core.Operaciones.Divisiones;
using Capacitacion.Core.Operaciones.Multiplicación;
using Capacitacion.Core.Operaciones.Restas;
using Capacitacion.Core.Operaciones.Sumas;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Categories;

namespace Test.Capacitacion.Core
{
    public class ConfigureOperacionesTest
    {
        [Fact]
        [IntegrationTest]
        public async Task Configure_Operaciones_Service__throws_ArgumentNullException_on_condifureSettings_null_Test()
        {
            var services = new ServiceCollection();
            Assert.Throws<ArgumentNullException>(()=> services.ConfigureOperacionesService(""));
        }
        
        [Fact]
        [IntegrationTest]
        public async Task Configure_Operaciones_Service_Test()
        {
            var services = new ServiceCollection();
            services.ConfigureOperacionesService("ENTEROS");
            using var serviceProvider = services.BuildServiceProvider();

            var divisionService = serviceProvider.GetRequiredService<IDivision>();
            Assert.NotNull(divisionService);
            
            var multiplicacionService = serviceProvider.GetRequiredService<IMultiplicacion>();
            Assert.NotNull(multiplicacionService);            
            
            var restaService = serviceProvider.GetRequiredService<IResta>();
            Assert.NotNull(restaService);            
            
            var sumaService = serviceProvider.GetRequiredService<ISumaIntegral>();
            Assert.NotNull(sumaService);
        }

        [Fact]
        [IntegrationTest]
        public async Task Configure_Operaciones_Service_returns_SumaEnteros_Test()
        {
            var services = new ServiceCollection();
            services.ConfigureOperacionesService("ENTEROS");
            using var serviceProvider = services.BuildServiceProvider();

            var sumaService = serviceProvider.GetRequiredService<ISumaRedondeada>();
            Assert.NotNull(sumaService);
            Assert.IsType<SumaRedondeada>(sumaService);
        }

        [Fact]
        [IntegrationTest]
        public async Task Configure_Operaciones_Service_returns_Suma_Test()
        {
            var services = new ServiceCollection();
            services.ConfigureOperacionesService("DECIMALES");
            using var serviceProvider = services.BuildServiceProvider();

            var sumaService = serviceProvider.GetRequiredService<ISuma>();
            Assert.NotNull(sumaService);
            Assert.IsType<Suma>(sumaService);
        }

        [Fact]
        [IntegrationTest]
        public async Task Configure_Operaciones_Service_returns_SumaIntegral_Test()
        {
            var services = new ServiceCollection();
            services.ConfigureOperacionesService("DECIMALES");
            using var serviceProvider = services.BuildServiceProvider();

            var sumaService = serviceProvider.GetRequiredService<ISumaIntegral>();
            Assert.NotNull(sumaService);
            Assert.IsType<SumaIntegral>(sumaService);
        }
    }
}
