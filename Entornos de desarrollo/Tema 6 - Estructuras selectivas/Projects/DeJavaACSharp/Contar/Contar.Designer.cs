namespace Contar2
{
    partial class Contar
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
            this.bContar = new System.Windows.Forms.Button();
            this.bReiniciar = new System.Windows.Forms.Button();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbCont = new System.Windows.Forms.TextBox();
            this.lNumero = new System.Windows.Forms.Label();
            this.lDe0 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bContar
            // 
            this.bContar.Location = new System.Drawing.Point(92, 27);
            this.bContar.Name = "bContar";
            this.bContar.Size = new System.Drawing.Size(75, 20);
            this.bContar.TabIndex = 0;
            this.bContar.Text = "Contar";
            this.bContar.UseVisualStyleBackColor = true;
            this.bContar.Click += new System.EventHandler(this.contar);
            // 
            // bReiniciar
            // 
            this.bReiniciar.Location = new System.Drawing.Point(92, 168);
            this.bReiniciar.Name = "bReiniciar";
            this.bReiniciar.Size = new System.Drawing.Size(75, 21);
            this.bReiniciar.TabIndex = 1;
            this.bReiniciar.Text = "Reiniciar";
            this.bReiniciar.UseVisualStyleBackColor = true;
            this.bReiniciar.Click += new System.EventHandler(this.reset);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(12, 28);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(74, 20);
            this.tbNum.TabIndex = 2;
            // 
            // tbCont
            // 
            this.tbCont.Location = new System.Drawing.Point(12, 79);
            this.tbCont.Multiline = true;
            this.tbCont.Name = "tbCont";
            this.tbCont.Size = new System.Drawing.Size(74, 110);
            this.tbCont.TabIndex = 3;
            // 
            // lNumero
            // 
            this.lNumero.AutoSize = true;
            this.lNumero.Location = new System.Drawing.Point(13, 9);
            this.lNumero.Name = "lNumero";
            this.lNumero.Size = new System.Drawing.Size(44, 13);
            this.lNumero.TabIndex = 4;
            this.lNumero.Text = "Número";
            // 
            // lDe0
            // 
            this.lDe0.AutoSize = true;
            this.lDe0.Location = new System.Drawing.Point(13, 63);
            this.lDe0.Name = "lDe0";
            this.lDe0.Size = new System.Drawing.Size(62, 13);
            this.lDe0.TabIndex = 5;
            this.lDe0.Text = "De 0 hasta ";
            this.lDe0.Visible = false;
            // 
            // Contar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 200);
            this.Controls.Add(this.lDe0);
            this.Controls.Add(this.lNumero);
            this.Controls.Add(this.tbCont);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.bReiniciar);
            this.Controls.Add(this.bContar);
            this.Name = "Contar";
            this.Text = "Contar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bContar;
        private System.Windows.Forms.Button bReiniciar;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbCont;
        private System.Windows.Forms.Label lNumero;
        private System.Windows.Forms.Label lDe0;
    }
}

