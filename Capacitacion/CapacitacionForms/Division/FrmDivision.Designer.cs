
namespace CapacitacionForms.Division
{
    partial class FrmDivision
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dividendoTitle = new System.Windows.Forms.Label();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.divisorTitle = new System.Windows.Forms.Label();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.resultTitle = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dividendoTitle
            // 
            this.dividendoTitle.AutoSize = true;
            this.dividendoTitle.Location = new System.Drawing.Point(28, 46);
            this.dividendoTitle.Name = "dividendoTitle";
            this.dividendoTitle.Size = new System.Drawing.Size(55, 13);
            this.dividendoTitle.TabIndex = 0;
            this.dividendoTitle.Text = "Dividendo";
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(31, 62);
            this.txtDividendo.MaxLength = 10;
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(100, 20);
            this.txtDividendo.TabIndex = 1;
            // 
            // divisorTitle
            // 
            this.divisorTitle.AutoSize = true;
            this.divisorTitle.Location = new System.Drawing.Point(168, 46);
            this.divisorTitle.Name = "divisorTitle";
            this.divisorTitle.Size = new System.Drawing.Size(39, 13);
            this.divisorTitle.TabIndex = 0;
            this.divisorTitle.Text = "Divisor";
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(171, 62);
            this.txtDivisor.MaxLength = 10;
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 20);
            this.txtDivisor.TabIndex = 1;
            // 
            // resultTitle
            // 
            this.resultTitle.AutoSize = true;
            this.resultTitle.Location = new System.Drawing.Point(28, 126);
            this.resultTitle.Name = "resultTitle";
            this.resultTitle.Size = new System.Drawing.Size(55, 13);
            this.resultTitle.TabIndex = 0;
            this.resultTitle.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(31, 154);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(240, 20);
            this.txtResultado.TabIndex = 1;
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(299, 60);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 2;
            this.btnDividir.Text = "=";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.BtnDividir_Click);
            // 
            // FrmDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 219);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.resultTitle);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.divisorTitle);
            this.Controls.Add(this.txtDividendo);
            this.Controls.Add(this.dividendoTitle);
            this.Name = "FrmDivision";
            this.Text = "Division";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dividendoTitle;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.Label divisorTitle;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Label resultTitle;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnDividir;
    }
}

