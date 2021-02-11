using System;

namespace Capacitacion.Core.Operaciones.Sumas
{
    public enum TipoSuma 
    {
        Enteros,
        Decimales
    }

    public class SumaIntegral : ISumaIntegral
    {
        private readonly ISuma _sumaSvc;
        private readonly ISumaRedondeada _sumaRedondeada;
        private readonly TipoSuma _tipoSuma;

        public SumaIntegral(ISuma sumaSvc, ISumaRedondeada sumaRedondeada)
        {
            _sumaSvc = sumaSvc;
            _sumaRedondeada = sumaRedondeada;
        }

        public SumaIntegral(ISuma sumaSvc, ISumaRedondeada sumaRedondeada, TipoSuma tipoSuma)
        {
            _sumaSvc = sumaSvc;
            _sumaRedondeada = sumaRedondeada;
            _tipoSuma = tipoSuma;
        }

        public double Sumar(double sumando1, double sumando2, TipoSuma tipoSuma) => EjecutarSuma(sumando1, sumando2, tipoSuma);
            

        public double Sumar(double sumando1, double sumando2) => EjecutarSuma(sumando1, sumando2, _tipoSuma);

        private double EjecutarSuma(double sumando1, double sumando2, TipoSuma tipoSuma) =>
            tipoSuma == TipoSuma.Enteros ? _sumaSvc.Sumar(sumando1, sumando2) : _sumaRedondeada.SumarEnteros(sumando1, sumando2);
    }
}
