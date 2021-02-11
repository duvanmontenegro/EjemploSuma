using System;

namespace Capacitacion.Core.Operaciones.Sumas
{
    /// <summary>
    /// No recomendamos utilizar esta interfaz, se recomienda utilizar <see cref="Capacitacion.Core.Operaciones.Sumas.ISumaIntegral"/>
    /// </summary>
    [Obsolete]
    public interface ISumaRedondeada
    {
        double SumarEnteros(double sumando1, double sumando2);
    }
}
