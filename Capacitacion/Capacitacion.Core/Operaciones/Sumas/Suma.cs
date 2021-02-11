namespace Capacitacion.Core.Operaciones.Sumas
{
    public class Suma : OperacionMatematica, ISuma
    {
        public virtual double Sumar(double sumando1, double sumando2) => sumando1 + sumando2;
    }
}
