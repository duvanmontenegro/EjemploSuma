﻿using CapacitacionForms.Excepciones;
using System;

namespace CapacitacionForms.Operaciones
{
    public class OperacionMatematica : IOperacionMatematica
    {
        public void ValidarStringNoContienePunto(string numeroPrueba)
        {
            if (numeroPrueba.Contains("."))
            {
                throw new BaseException("Para ingresar un número con decimales utilizar coma");
            }
        }

        public int ObtenerParteDecimal(float numeroflotante)
        {
            string numeroToString = numeroflotante.ToString();
            if (numeroToString.Contains(","))
            {
                string decimales = numeroToString.Split(',')[1];
                return decimales.Length;
            }
            else
            {
                return 0;
            }
        }

        public void ValidarStringSoloNumeros(string valor)
        {
           try
           {
                float intValor = float.Parse(valor);
            }
            catch (Exception)
           {
                throw new BaseException("Solo se pueden digitar números");
           }
       }
    }
}
