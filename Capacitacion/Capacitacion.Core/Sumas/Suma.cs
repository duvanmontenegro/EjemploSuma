using Capacitacion.Core.Operaciones;

namespace Capacitacion.Core.Sumas
{
    public class Suma : OperacionMatematica, ISuma
    {
        public virtual double Sumar(double sumando1, double sumando2) => sumando1 + sumando2;
    }
}
