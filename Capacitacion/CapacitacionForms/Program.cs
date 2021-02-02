﻿using CapacitacionForms.Operaciones;
using System;
using System.Windows.Forms;

namespace CapacitacionForms
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //TODO: Daniel, Implementar IoC con unity
            var tipoSumaAdmitida = LeerConfigureIni(); 

            //Application.Run(new FrmSuma(tipoSumaAdmitida == "POSITIVOS" ? new SumaPositivos() : new Suma()));
            Application.Run(new FrmSuma(new Suma()));
        }

        public static string LeerConfigureIni() => "POSITVOS";
    }
}
