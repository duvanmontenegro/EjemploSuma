using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapacitacionForms.Resta
{
    public partial class FrmResta : Form
    {
        public FrmResta()
        {
            InitializeComponent();
        }

        public static void esNumero(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == '\b') || (e.KeyChar == 45))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtMinuendo_KeyPress(object sender, KeyPressEventArgs e)
        {
            esNumero(e);
        }

        private void txtSustraendo_KeyPress(object sender, KeyPressEventArgs e)
        {
            esNumero(e);
        }
    }
}
