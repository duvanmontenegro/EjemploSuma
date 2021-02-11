namespace Capacitacion.Core.Multiplicación
{
    public interface IMultiplicacion
    {
        public double Multiplicar(MultiplicacionDto request);
        public double MultiplicarFracciones(MultiplicacionDto request);

    }
}
