using CapacitacionForms.Division;
using CapacitacionForms.Multiplicacion;
using CapacitacionForms.Resta;
using CapacitacionForms.Suma;
using System;
using System.Windows.Forms;

namespace CapacitacionForms.Operaciones
{
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmSuma Suma = new FrmSuma(new Capacitacion.Core.Sumas.Suma());
            Suma.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmDivision Division = new FrmDivision(new Capacitacion.Core.Divisiones.Division());
            Division.Show();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            FrmMultiplicacion Multiplicacion = new FrmMultiplicacion();
            Multiplicacion.Show();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            FrmResta Resta = new FrmResta();
            Resta.Show();
        }
    }
}
