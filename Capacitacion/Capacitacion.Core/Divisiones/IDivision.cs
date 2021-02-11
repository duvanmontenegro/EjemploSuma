using Capacitacion.Core.Suma;
namespace Capacitacion.Core.Divisiones
{
    public interface IDivision
    {
        double Dividir(DivisionDto request);
        string DividirRacionales(string number);
    }
}




