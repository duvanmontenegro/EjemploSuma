using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapacitacionForms.Multiplicacion
{
    public partial class FrmMultiplicacion : Form
    {
        public FrmMultiplicacion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static void esDecimal(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == '\b') || (e.KeyChar == 44) || (e.KeyChar == 45))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtFactor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            esDecimal(e);
        }

        private void txtFactor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            esDecimal(e);
        }
    }
}
