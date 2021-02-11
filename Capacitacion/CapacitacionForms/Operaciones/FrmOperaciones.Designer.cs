
namespace CapacitacionForms.Operaciones
{
    partial class FrmOperaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(173, 35);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(139, 43);
            this.btnDividir.TabIndex = 1;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(28, 35);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(139, 43);
            this.btnSumar.TabIndex = 2;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(28, 84);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(139, 43);
            this.btnRestar.TabIndex = 2;
            this.btnRestar.Text = "Restar";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(173, 84);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(139, 43);
            this.btnMultiplicar.TabIndex = 1;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // FrmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 151);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnSumar);
            this.Name = "FrmOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suma - División";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
    }
}