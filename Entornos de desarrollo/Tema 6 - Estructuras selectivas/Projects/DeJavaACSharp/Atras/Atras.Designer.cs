namespace Atras
{
    partial class Atras
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
            this.tbNum = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.bReiniciar = new System.Windows.Forms.Button();
            this.tbCont = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce un número:";
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(12, 29);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(105, 20);
            this.tbNum.TabIndex = 1;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(125, 29);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(91, 23);
            this.bCalcular.TabIndex = 2;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.contar);
            // 
            // bReiniciar
            // 
            this.bReiniciar.Location = new System.Drawing.Point(125, 189);
            this.bReiniciar.Name = "bReiniciar";
            this.bReiniciar.Size = new System.Drawing.Size(91, 23);
            this.bReiniciar.TabIndex = 3;
            this.bReiniciar.Text = "Reiniciar";
            this.bReiniciar.UseVisualStyleBackColor = true;
            this.bReiniciar.Click += new System.EventHandler(this.reset);
            // 
            // tbCont
            // 
            this.tbCont.Location = new System.Drawing.Point(12, 58);
            this.tbCont.Multiline = true;
            this.tbCont.Name = "tbCont";
            this.tbCont.Size = new System.Drawing.Size(105, 154);
            this.tbCont.TabIndex = 4;
            // 
            // Atras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 224);
            this.Controls.Add(this.tbCont);
            this.Controls.Add(this.bReiniciar);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.label1);
            this.Name = "Atras";
            this.Text = "Atrás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Button bReiniciar;
        private System.Windows.Forms.TextBox tbCont;
    }
}

