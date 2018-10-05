namespace TablasDeMultiplicar
{
    partial class TabaDeMultiplicar
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTabla = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.tbCalculo = new System.Windows.Forms.TextBox();
            this.bReset = new System.Windows.Forms.Button();
            this.lTabla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Que tabla quieres calcular?";
            // 
            // tbTabla
            // 
            this.tbTabla.Location = new System.Drawing.Point(12, 30);
            this.tbTabla.Name = "tbTabla";
            this.tbTabla.Size = new System.Drawing.Size(110, 20);
            this.tbTabla.TabIndex = 1;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(129, 30);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(96, 20);
            this.bCalcular.TabIndex = 2;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.calcular);
            // 
            // tbCalculo
            // 
            this.tbCalculo.Location = new System.Drawing.Point(13, 78);
            this.tbCalculo.Multiline = true;
            this.tbCalculo.Name = "tbCalculo";
            this.tbCalculo.Size = new System.Drawing.Size(212, 151);
            this.tbCalculo.TabIndex = 3;
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(150, 235);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 4;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.reset);
            // 
            // lTabla
            // 
            this.lTabla.AutoSize = true;
            this.lTabla.Location = new System.Drawing.Point(12, 62);
            this.lTabla.Name = "lTabla";
            this.lTabla.Size = new System.Drawing.Size(0, 13);
            this.lTabla.TabIndex = 5;
            // 
            // TabaDeMultiplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 264);
            this.Controls.Add(this.lTabla);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.tbCalculo);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.tbTabla);
            this.Controls.Add(this.label1);
            this.Name = "TabaDeMultiplicar";
            this.Text = "Tabla de multiplicar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTabla;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.TextBox tbCalculo;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Label lTabla;
    }
}

