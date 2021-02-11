using System;

namespace Capacitacion.Core.Sumas
{
    public class SumaEnteros : Suma, ISuma
    {
        public override double Sumar(double sumando1, double sumando2) => base.Sumar(Convert.ToInt32(sumando1), Convert.ToInt32(sumando2));
    }
}
