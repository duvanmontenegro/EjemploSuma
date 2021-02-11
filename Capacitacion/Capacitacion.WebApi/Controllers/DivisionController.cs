using Capacitacion.Core.Operaciones.Divisiones;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace Capacitacion.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisionController : ControllerBase
    {
        private readonly ILogger<DivisionController> _logger;
        private readonly IDivision _divisionSvc;
        public DivisionController(ILogger<DivisionController> logger, IDivision divisionSvc)
        {
            _logger = logger;
            _divisionSvc = divisionSvc;
        }

        [HttpPost("Dividir")]
        public DivisionDto Post(DivisionDto divisionRequest) => new DivisionDto { Resultado = _divisionSvc.Dividir(divisionRequest) };
    }
}