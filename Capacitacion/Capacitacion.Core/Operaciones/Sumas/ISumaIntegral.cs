namespace Capacitacion.Core.Operaciones.Sumas
{
    public interface ISumaIntegral
    {
        double Sumar(double sumando1, double sumando2, TipoSuma tipoSuma);
        double Sumar(double sumando1, double sumando2);
    }
}
