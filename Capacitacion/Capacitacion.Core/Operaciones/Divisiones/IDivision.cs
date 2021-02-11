namespace Capacitacion.Core.Operaciones.Divisiones
{
    /// <summary>
    /// Permite realizar divisiones 
    /// </summary>
    public interface IDivision
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"> solicitud de division</param>
        /// <returns> entrega un decimal con el resultado de la division</returns>
        double Dividir(DivisionDto request);
        string DividirRacionales(string number);
    }
}




