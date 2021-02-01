using CapacitacionForms.Division;
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
            FrmSuma Suma = new FrmSuma(new Suma.Suma());
            Suma.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmDivision Division = new FrmDivision(new Division.Division());
            Division.Show();
        }
    }
}
