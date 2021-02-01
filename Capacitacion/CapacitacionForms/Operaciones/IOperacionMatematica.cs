namespace CapacitacionForms.Operaciones
{
    public interface IOperacionMatematica
    {
        void ValidarStringNoContienePunto(string numeroPrueba);
        int ObtenerParteDecimal(float numero);
        void ValidarStringSoloNumeros(string valor);
    }
}
