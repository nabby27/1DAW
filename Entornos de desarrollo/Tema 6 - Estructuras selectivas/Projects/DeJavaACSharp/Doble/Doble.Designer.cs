namespace Doble
{
    partial class Doble
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
            this.tbValor = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.lValorDoble = new System.Windows.Forms.Label();
            this.lValor = new System.Windows.Forms.Label();
            this.tbValorDoble = new System.Windows.Forms.TextBox();
            this.bReiniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(27, 36);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 0;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(153, 36);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(75, 20);
            this.bCalcular.TabIndex = 1;
            this.bCalcular.Text = "Doblar valor";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.calcularDoble);
            // 
            // lValorDoble
            // 
            this.lValorDoble.AutoSize = true;
            this.lValorDoble.Location = new System.Drawing.Point(24, 70);
            this.lValorDoble.Name = "lValorDoble";
            this.lValorDoble.Size = new System.Drawing.Size(63, 13);
            this.lValorDoble.TabIndex = 2;
            this.lValorDoble.Text = "Valor doble:";
            this.lValorDoble.Visible = false;
            // 
            // lValor
            // 
            this.lValor.AutoSize = true;
            this.lValor.Location = new System.Drawing.Point(24, 20);
            this.lValor.Name = "lValor";
            this.lValor.Size = new System.Drawing.Size(34, 13);
            this.lValor.TabIndex = 3;
            this.lValor.Text = "Valor:";
            // 
            // tbValorDoble
            // 
            this.tbValorDoble.Location = new System.Drawing.Point(27, 87);
            this.tbValorDoble.Name = "tbValorDoble";
            this.tbValorDoble.Size = new System.Drawing.Size(100, 20);
            this.tbValorDoble.TabIndex = 4;
            this.tbValorDoble.Visible = false;
            // 
            // bReiniciar
            // 
            this.bReiniciar.Location = new System.Drawing.Point(168, 118);
            this.bReiniciar.Name = "bReiniciar";
            this.bReiniciar.Size = new System.Drawing.Size(75, 20);
            this.bReiniciar.TabIndex = 5;
            this.bReiniciar.Text = "Reiniciar";
            this.bReiniciar.UseVisualStyleBackColor = true;
            this.bReiniciar.Visible = false;
            this.bReiniciar.Click += new System.EventHandler(this.reiniciar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "(0 para cerrar)";
            // 
            // Doble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 71);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bReiniciar);
            this.Controls.Add(this.tbValorDoble);
            this.Controls.Add(this.lValor);
            this.Controls.Add(this.lValorDoble);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.tbValor);
            this.Name = "Doble";
            this.Text = "Número doble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Label lValorDoble;
        private System.Windows.Forms.Label lValor;
        private System.Windows.Forms.TextBox tbValorDoble;
        private System.Windows.Forms.Button bReiniciar;
        private System.Windows.Forms.Label label1;

    }
}

