using CapacitacionForms.Excepciones;

namespace CapacitacionForms.Operaciones
{
    public class Suma : ISuma
    {
        public virtual int Sumar(int sumando1, int sumando2) => sumando1 + sumando2;
    }

    public class SumaPositivos : ISuma, IRedondeo
    {
        public int Redondear(double valor)
        {
            throw new System.NotImplementedException();
        }

        public int Sumar(int sumando1, int sumando2)
        {
            if (sumando1 < 0 || sumando1 < 0)
            {
                throw new BaseException("Los numeros deben ser positivos");
            }
            else
            {
                return sumando1 + sumando2;
            }
        }
    }

    public class Redondear
    { 
    
    }
}
