using Capacitacion.Core.Operaciones.Multiplicación;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace Capacitacion.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MultiplicacionController : ControllerBase
    {
        private readonly ILogger<MultiplicacionController> _logger;
        private readonly IMultiplicacion _multiplicacionSvc;
        public MultiplicacionController(ILogger<MultiplicacionController> logger, IMultiplicacion multiplicacionSvc)
        {
            _logger = logger;
            _multiplicacionSvc = multiplicacionSvc;
        }

        [HttpPost("Multiplicar")]
        public MultiplicacionDto Post(MultiplicacionDto multiplicacionRequest) => new MultiplicacionDto { Resultado = _multiplicacionSvc.Multiplicar(multiplicacionRequest) };
    }
}