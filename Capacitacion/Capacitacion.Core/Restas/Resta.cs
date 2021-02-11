using Capacitacion.Core.Operaciones;
namespace Capacitacion.Core.Restas
{
    public class Resta : OperacionMatematica, IResta
    {
        public int Restar(RestaDto request) => request.Minuendo - request.Sustraendo;
    }
}

