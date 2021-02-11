
namespace CapacitacionForms.Resta
{
    partial class FrmResta
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
            this.btnResta = new System.Windows.Forms.Button();
            this.txtSustraendo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiferencia = new System.Windows.Forms.TextBox();
            this.txtMinuendo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnResta
            // 
            this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(295, 37);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(32, 33);
            this.btnResta.TabIndex = 2;
            this.btnResta.Text = "=";
            this.btnResta.UseVisualStyleBackColor = true;
            // 
            // txtSustraendo
            // 
            this.txtSustraendo.Location = new System.Drawing.Point(186, 44);
            this.txtSustraendo.Name = "txtSustraendo";
            this.txtSustraendo.Size = new System.Drawing.Size(100, 20);
            this.txtSustraendo.TabIndex = 1;
            this.txtSustraendo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSustraendo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sustraendo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Diferencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Minuendo";
            // 
            // txtDiferencia
            // 
            this.txtDiferencia.Enabled = false;
            this.txtDiferencia.Location = new System.Drawing.Point(111, 99);
            this.txtDiferencia.Name = "txtDiferencia";
            this.txtDiferencia.Size = new System.Drawing.Size(100, 20);
            this.txtDiferencia.TabIndex = 3;
            // 
            // txtMinuendo
            // 
            this.txtMinuendo.Location = new System.Drawing.Point(36, 44);
            this.txtMinuendo.Name = "txtMinuendo";
            this.txtMinuendo.Size = new System.Drawing.Size(100, 20);
            this.txtMinuendo.TabIndex = 0;
            this.txtMinuendo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinuendo_KeyPress);
            // 
            // FrmResta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 146);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.txtSustraendo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiferencia);
            this.Controls.Add(this.txtMinuendo);
            this.Name = "FrmResta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.TextBox txtSustraendo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiferencia;
        private System.Windows.Forms.TextBox txtMinuendo;
    }
}