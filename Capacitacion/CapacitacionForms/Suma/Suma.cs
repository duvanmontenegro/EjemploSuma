using CapacitacionForms.Excepciones;
using CapacitacionForms.Operaciones;
using System;

namespace CapacitacionForms.Suma
{
    public class Suma : OperacionMatematica, ISuma
    {
        public virtual int Sumar(int sumando1, int sumando2) => sumando1 + sumando2;

        public int SumarEnteros(string sumando1, string sumando2)
        {
            if (sumando1.Contains(".") || sumando2.Contains(".") || sumando1.Contains(",") || sumando2.Contains(","))
            {
                throw new BaseException("Los valores digitados deben ser números enteros");
            }
            else
            {
                ValidarStringSoloNumeros(sumando1);
                ValidarStringSoloNumeros(sumando2);
                return Convert.ToInt32(sumando1) + Convert.ToInt32(sumando2);
            }
        }
    }
}
