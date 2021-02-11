
namespace CapacitacionForms.Multiplicacion
{
    partial class FrmMultiplicacion
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
            this.txtFactor1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFactor2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProducto = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFactor1
            // 
            this.txtFactor1.Location = new System.Drawing.Point(38, 39);
            this.txtFactor1.Name = "txtFactor1";
            this.txtFactor1.Size = new System.Drawing.Size(100, 20);
            this.txtFactor1.TabIndex = 0;
            this.txtFactor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFactor1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Factor 1  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFactor2
            // 
            this.txtFactor2.Location = new System.Drawing.Point(188, 39);
            this.txtFactor2.Name = "txtFactor2";
            this.txtFactor2.Size = new System.Drawing.Size(100, 20);
            this.txtFactor2.TabIndex = 1;
            this.txtFactor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFactor2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Factor 2 ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.Location = new System.Drawing.Point(297, 32);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(32, 33);
            this.btnProducto.TabIndex = 2;
            this.btnProducto.Text = "=";
            this.btnProducto.UseVisualStyleBackColor = true;
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(113, 94);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 20);
            this.txtProducto.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Producto";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmMultiplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 146);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.txtFactor2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtFactor1);
            this.Name = "FrmMultiplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiplicación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFactor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFactor2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label4;
    }
}