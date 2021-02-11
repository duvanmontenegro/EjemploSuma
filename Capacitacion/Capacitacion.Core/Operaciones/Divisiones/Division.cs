namespace Capacitacion.Core.Operaciones.Divisiones
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
        public virtual double Dividir(DivisionDto request) => request.Dividendo / request.Divisor;
    }
}
