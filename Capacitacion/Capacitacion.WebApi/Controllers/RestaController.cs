using Capacitacion.Core.Operaciones.Restas;
using Capacitacion.Core.Operaciones.Sumas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace Capacitacion.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaController : ControllerBase
    {
        private readonly ILogger<RestaController> _logger;
        private readonly IResta _restaSvc;
        public RestaController(ILogger<RestaController> logger, IResta restaSvc)
        {
            _logger = logger;
            _restaSvc = restaSvc;
        }

        [HttpPost("Restar")]
        public SumaDto Post(RestaDto restaRequest) => new SumaDto { Resultado = _restaSvc.Restar(restaRequest) };
    }
}
