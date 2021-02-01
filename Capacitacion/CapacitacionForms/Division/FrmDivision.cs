using CapacitacionForms.Excepciones;
using System;
using System.Windows.Forms;

namespace CapacitacionForms.Division
{
    public partial class FrmDivision : Form
    {
        private readonly IDivision _divisionService;

        public FrmDivision(IDivision divisionSvc)
        {
            _divisionService = divisionSvc;
            InitializeComponent();
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDividendo.Text) || string.IsNullOrEmpty(txtDivisor.Text))
            {
                MessageBox.Show("Campo obligatorio");
                return;
            }

            try
            {
                txtResultado.Text = _divisionService.Dividir(txtDivisor.Text, txtDividendo.Text).ToString();
            }
            catch (BaseException exce)
            {
                MessageBox.Show(exce.Message);
            }
        }
    }
}
