using CapacitacionForms.Excepciones;
using CapacitacionForms.Operaciones;
using System;
using System.Windows.Forms;

namespace CapacitacionForms
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
                MessageBox.Show("Los valores S1 y S2 son requeridos");
            }
            else
            {
                int.TryParse(txtSumando1.Text, out var sumando1);
                int.TryParse(txtSumando2.Text, out var sumando2);
                if (sumando1 == 0 || sumando2 == 0)
                {
                    MessageBox.Show("Los valores digitados deben ser números enteros");
                    return;
                }

                try
                {
                    txtResultado.Text = _sumaService.Sumar(sumando1, sumando2).ToString();
                }
                catch (BaseException exce)
                {
                    MessageBox.Show(exce.Message);
                }
            }
        }
    }
}
