using Capacitacion.Core.Operaciones.Sumas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Capacitacion.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SumaController : ControllerBase
    {
        private readonly ILogger<SumaController> _logger;
        private readonly ISumaIntegral _sumaSvc;

        public SumaController(ILogger<SumaController> logger, ISumaIntegral sumaSvc)
        {
            _logger = logger;
            _sumaSvc = sumaSvc;

            _logger.LogInformation($"Controlador de suma opera { (_sumaSvc is SumaRedondeada ? "ENTEROS" : "DECIMALES")}");
        }

        [HttpPost("Sumar")]
        public SumaDto Post(SumaDto sumaRequest) => new SumaDto
        {
            Resultado = _sumaSvc.Sumar(sumaRequest.Sumando1, sumaRequest.Sumando2)
        };
    }
}
