using Capacitacion.Core.Operaciones;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Categories;

namespace Test.Capacitacion.Core
{
    public class IoCTest
    {
        [Fact]
        [IntegrationTest]
        public async Task Use_GetValues_Extension_Method_Test()
        {
            var services = new ServiceCollection();
            services.AddTransient<IOperacionMatematica, OperacionMatematica>();
            Assert.Throws<ArgumentException>(() => services.BuildServiceProvider());
        }
    }
}
