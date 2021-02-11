namespace Capacitacion.Core.Operaciones.Multiplicación
{
    public class Multiplicacion : OperacionMatematica, IMultiplicacion
    {
        public double Multiplicar(MultiplicacionDto request)
        {
            ValidarStringNoContienePunto(request.Factor1);
            ValidarStringNoContienePunto(request.Factor2);

            double.TryParse(request.Factor1, out var factor1);
            double.TryParse(request.Factor2, out var factor2);

            return factor1 * factor2;
        }

        public double MultiplicarFracciones(MultiplicacionDto request)
        {
            ValidarStringNoContienePunto(request.Factor1);
            ValidarStringNoContienePunto(request.Factor2);

            var primerFactor = ObtenerPartesFraccion(request.Factor1);
            var segundoFactor = ObtenerPartesFraccion(request.Factor2);

            var Numeradorfactor1 = double.Parse(primerFactor[0]);
            var Denominadorfactor1 = double.Parse(primerFactor[1]);
            var Numeradorfactor2 = double.Parse(segundoFactor[0]);
            var Denominadorfactor2 = double.Parse(segundoFactor[1]);

            return Numeradorfactor1 * Numeradorfactor2 / (Denominadorfactor1 * Denominadorfactor2);
        }
    }
}
