using System;

namespace Capacitacion.Core.Operaciones.Sumas
{
    /// <summary>
    /// No recomendamos utilizar esta interfaz, se recomienda utilizar <see cref="Capacitacion.Core.Operaciones.Sumas.ISumaIntegral"/>
    /// </summary>
    [Obsolete]
    public interface ISuma
    {
        /// <summary>
        /// No recomendamos utilizar esta interfaz, se recomienda utilizar <see cref="Capacitacion.Core.Operaciones.Sumas.ISumaIntegral.Sumar(double, double)(double, double)"/>
        /// </summary>
        double Sumar(double sumando1, double sumando2);
    }
}
