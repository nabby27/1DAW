namespace PracticaExamen
{
    partial class PracticaExamen
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracticaExamen));
            this.tbOp1 = new System.Windows.Forms.TextBox();
            this.tbOp2 = new System.Windows.Forms.TextBox();
            this.lbNumeros = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lNumOperaciones = new System.Windows.Forms.Label();
            this.lSumaTotal = new System.Windows.Forms.Label();
            this.btCalc = new System.Windows.Forms.PictureBox();
            this.btStart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btStart)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOp1
            // 
            this.tbOp1.Enabled = false;
            this.tbOp1.Location = new System.Drawing.Point(32, 119);
            this.tbOp1.Name = "tbOp1";
            this.tbOp1.Size = new System.Drawing.Size(30, 20);
            this.tbOp1.TabIndex = 0;
            // 
            // tbOp2
            // 
            this.tbOp2.Enabled = false;
            this.tbOp2.Location = new System.Drawing.Point(135, 119);
            this.tbOp2.Name = "tbOp2";
            this.tbOp2.Size = new System.Drawing.Size(30, 20);
            this.tbOp2.TabIndex = 1;
            // 
            // lbNumeros
            // 
            this.lbNumeros.FormattingEnabled = true;
            this.lbNumeros.Location = new System.Drawing.Point(32, 160);
            this.lbNumeros.Name = "lbNumeros";
            this.lbNumeros.Size = new System.Drawing.Size(133, 147);
            this.lbNumeros.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de operaciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suma total de los resultados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "x";
            // 
            // lNumOperaciones
            // 
            this.lNumOperaciones.AutoSize = true;
            this.lNumOperaciones.Location = new System.Drawing.Point(141, 9);
            this.lNumOperaciones.Name = "lNumOperaciones";
            this.lNumOperaciones.Size = new System.Drawing.Size(0, 13);
            this.lNumOperaciones.TabIndex = 8;
            // 
            // lSumaTotal
            // 
            this.lSumaTotal.AutoSize = true;
            this.lSumaTotal.Location = new System.Drawing.Point(160, 39);
            this.lSumaTotal.Name = "lSumaTotal";
            this.lSumaTotal.Size = new System.Drawing.Size(0, 13);
            this.lSumaTotal.TabIndex = 9;
            // 
            // btCalc
            // 
            this.btCalc.Image = ((System.Drawing.Image)(resources.GetObject("btCalc.Image")));
            this.btCalc.Location = new System.Drawing.Point(185, 106);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(109, 48);
            this.btCalc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btCalc.TabIndex = 10;
            this.btCalc.TabStop = false;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // btStart
            // 
            this.btStart.Image = ((System.Drawing.Image)(resources.GetObject("btStart.Image")));
            this.btStart.Location = new System.Drawing.Point(11, 55);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(51, 45);
            this.btStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btStart.TabIndex = 11;
            this.btStart.TabStop = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // PracticaExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(318, 319);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btCalc);
            this.Controls.Add(this.lSumaTotal);
            this.Controls.Add(this.lNumOperaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNumeros);
            this.Controls.Add(this.tbOp2);
            this.Controls.Add(this.tbOp1);
            this.Name = "PracticaExamen";
            this.Text = "Practica Examen";
            ((System.ComponentModel.ISupportInitialize)(this.btCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOp1;
        private System.Windows.Forms.TextBox tbOp2;
        private System.Windows.Forms.ListBox lbNumeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lNumOperaciones;
        private System.Windows.Forms.Label lSumaTotal;
        private System.Windows.Forms.PictureBox btCalc;
        private System.Windows.Forms.PictureBox btStart;
    }
}

