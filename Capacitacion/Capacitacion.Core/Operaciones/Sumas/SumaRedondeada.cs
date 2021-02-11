using System;

namespace Capacitacion.Core.Operaciones.Sumas
{
    public class SumaRedondeada : ISumaRedondeada
    {
        public double SumarEnteros(double sumando1, double sumando2) => Convert.ToInt32(sumando1) + Convert.ToInt32(sumando2);
    }
}
