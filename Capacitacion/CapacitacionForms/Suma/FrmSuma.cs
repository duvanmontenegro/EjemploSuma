using CapacitacionForms.Excepciones;
using System;
using System.Windows.Forms;

namespace CapacitacionForms.Suma
{
    public partial class FrmSuma : Form
    {
        private readonly ISuma _sumaService;

        public FrmSuma(ISuma sumaSvc)
        {
            _sumaService = sumaSvc;
            InitializeComponent();
        }

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSumando1.Text) || string.IsNullOrEmpty(txtSumando2.Text))
            {
                MessageBox.Show("Los valores sumando 1 y sumando 2 son requeridos");
                return;
            }

            int.TryParse(txtSumando1.Text, out var sumando1);
            int.TryParse(txtSumando2.Text, out var sumando2);
            try
            {
                if (rbSumarEnteros.Checked == true)
                {
                    txtResultado.Text = _sumaService.SumarEnteros(txtSumando1.Text, txtSumando2.Text).ToString();
                }
                if (rbSumarPositivos.Checked == true)
                {
                    if (sumando1 < 0 || sumando2 < 0)
                    {
                        MessageBox.Show("Los numeros deben ser positivos");
                        return;
                    }

                    txtResultado.Text = _sumaService.SumarEnteros(txtSumando1.Text, txtSumando2.Text).ToString();
                }
            }
            catch (BaseException exce)
            {
                MessageBox.Show(exce.Message);
            }
        }
    }
}