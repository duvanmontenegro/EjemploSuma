namespace Capacitacion.Core.Operaciones.Restas
{
    public class Resta : OperacionMatematica, IResta
    {
        public int Restar(RestaDto request) => request.Minuendo - request.Sustraendo;
    }
}

