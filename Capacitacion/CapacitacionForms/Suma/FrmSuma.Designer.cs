
namespace CapacitacionForms.Suma
{
    partial class FrmSuma
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSumando1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSumando2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.rbSumarEnteros = new System.Windows.Forms.RadioButton();
            this.rbSumarPositivos = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sumando 1";
            // 
            // txtSumando1
            // 
            this.txtSumando1.Location = new System.Drawing.Point(29, 87);
            this.txtSumando1.Name = "txtSumando1";
            this.txtSumando1.Size = new System.Drawing.Size(100, 20);
            this.txtSumando1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sumando 2";
            // 
            // txtSumando2
            // 
            this.txtSumando2.Location = new System.Drawing.Point(160, 87);
            this.txtSumando2.Name = "txtSumando2";
            this.txtSumando2.Size = new System.Drawing.Size(100, 20);
            this.txtSumando2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(29, 146);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(231, 20);
            this.txtResultado.TabIndex = 1;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(273, 87);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(31, 20);
            this.btnSumar.TabIndex = 2;
            this.btnSumar.Text = "=";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.BtnSumar_Click);
            // 
            // rbSumarEnteros
            // 
            this.rbSumarEnteros.AutoSize = true;
            this.rbSumarEnteros.Checked = true;
            this.rbSumarEnteros.Location = new System.Drawing.Point(4, 28);
            this.rbSumarEnteros.Margin = new System.Windows.Forms.Padding(2);
            this.rbSumarEnteros.Name = "rbSumarEnteros";
            this.rbSumarEnteros.Size = new System.Drawing.Size(93, 17);
            this.rbSumarEnteros.TabIndex = 3;
            this.rbSumarEnteros.TabStop = true;
            this.rbSumarEnteros.Text = "Sumar enteros";
            this.rbSumarEnteros.UseVisualStyleBackColor = true;
            // 
            // rbSumarPositivos
            // 
            this.rbSumarPositivos.AutoSize = true;
            this.rbSumarPositivos.Location = new System.Drawing.Point(117, 28);
            this.rbSumarPositivos.Margin = new System.Windows.Forms.Padding(2);
            this.rbSumarPositivos.Name = "rbSumarPositivos";
            this.rbSumarPositivos.Size = new System.Drawing.Size(99, 17);
            this.rbSumarPositivos.TabIndex = 3;
            this.rbSumarPositivos.Text = "Sumar positivos";
            this.rbSumarPositivos.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "+";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSumarEnteros);
            this.groupBox1.Controls.Add(this.rbSumarPositivos);
            this.groupBox1.Location = new System.Drawing.Point(29, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(243, 53);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de suma";
            // 
            // FrmSuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 181);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSumando2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSumando1);
            this.Controls.Add(this.label1);
            this.Name = "FrmSuma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSumando1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSumando2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.RadioButton rbSumarEnteros;
        private System.Windows.Forms.RadioButton rbSumarPositivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

