using Capacitacion.Core.Operaciones;
using CapacitacionForms.Core.Excepciones;

namespace Capacitacion.Core.Divisiones
{
    public class Division : OperacionMatematica, IDivision
    {
        public string DividirRacionales(string numeroRacional)
        {
            if (!numeroRacional.Contains("/"))
                return numeroRacional;

            var dividendo = float.Parse(numeroRacional.Split('/')[0]);
            var divisor = float.Parse(numeroRacional.Split('/')[1]);
            numeroRacional = System.Math.Round(dividendo / divisor, 2).ToString();
            return numeroRacional;
        }

        public virtual double Dividir(string divisorIn, string dividendoIn)
        {
            ValidarStringNoContienePunto(divisorIn);
            ValidarStringNoContienePunto(dividendoIn);

            divisorIn = DividirRacionales(divisorIn);
            dividendoIn = DividirRacionales(dividendoIn);

            float.TryParse(divisorIn, out var divisor);
            float.TryParse(dividendoIn, out var dividendo);

            ValidarStringSoloNumeros(divisorIn);
            ValidarStringSoloNumeros(dividendoIn);

            if (ObtenerParteDecimal(divisor) >= 2 && ObtenerParteDecimal(dividendo) >= 2)
                throw new BaseException("Por favor ingrese solo dos decimales");

            switch (divisor)
            {
                case 0:
                    throw new BaseException("El resultado no existe aritmeticamente");
                default:
                    double division = dividendo / divisor;
                    return System.Math.Round(division, 2);
            }
        }
    }
}
