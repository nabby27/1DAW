namespace Contar2
{
    partial class Contar2
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
            this.lDesde = new System.Windows.Forms.Label();
            this.tbDesde = new System.Windows.Forms.TextBox();
            this.lHasta = new System.Windows.Forms.Label();
            this.tbHasta = new System.Windows.Forms.TextBox();
            this.bContar = new System.Windows.Forms.Button();
            this.bReiniciar = new System.Windows.Forms.Button();
            this.tbCont = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lDesde
            // 
            this.lDesde.AutoSize = true;
            this.lDesde.Location = new System.Drawing.Point(12, 9);
            this.lDesde.Name = "lDesde";
            this.lDesde.Size = new System.Drawing.Size(38, 13);
            this.lDesde.TabIndex = 0;
            this.lDesde.Text = "Desde";
            // 
            // tbDesde
            // 
            this.tbDesde.Location = new System.Drawing.Point(12, 29);
            this.tbDesde.Name = "tbDesde";
            this.tbDesde.Size = new System.Drawing.Size(100, 20);
            this.tbDesde.TabIndex = 1;
            // 
            // lHasta
            // 
            this.lHasta.AutoSize = true;
            this.lHasta.Location = new System.Drawing.Point(12, 73);
            this.lHasta.Name = "lHasta";
            this.lHasta.Size = new System.Drawing.Size(35, 13);
            this.lHasta.TabIndex = 2;
            this.lHasta.Text = "Hatsa";
            // 
            // tbHasta
            // 
            this.tbHasta.Location = new System.Drawing.Point(12, 89);
            this.tbHasta.Name = "tbHasta";
            this.tbHasta.Size = new System.Drawing.Size(100, 20);
            this.tbHasta.TabIndex = 3;
            // 
            // bContar
            // 
            this.bContar.Location = new System.Drawing.Point(12, 161);
            this.bContar.Name = "bContar";
            this.bContar.Size = new System.Drawing.Size(100, 23);
            this.bContar.TabIndex = 4;
            this.bContar.Text = "Contar";
            this.bContar.UseVisualStyleBackColor = true;
            this.bContar.Click += new System.EventHandler(this.contar);
            // 
            // bReiniciar
            // 
            this.bReiniciar.Location = new System.Drawing.Point(12, 213);
            this.bReiniciar.Name = "bReiniciar";
            this.bReiniciar.Size = new System.Drawing.Size(100, 23);
            this.bReiniciar.TabIndex = 5;
            this.bReiniciar.Text = "Reiniciar";
            this.bReiniciar.UseVisualStyleBackColor = true;
            this.bReiniciar.Click += new System.EventHandler(this.reset);
            // 
            // tbCont
            // 
            this.tbCont.Location = new System.Drawing.Point(118, 29);
            this.tbCont.Multiline = true;
            this.tbCont.Name = "tbCont";
            this.tbCont.Size = new System.Drawing.Size(76, 207);
            this.tbCont.TabIndex = 6;
            // 
            // Contar2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 249);
            this.Controls.Add(this.tbCont);
            this.Controls.Add(this.bReiniciar);
            this.Controls.Add(this.bContar);
            this.Controls.Add(this.tbHasta);
            this.Controls.Add(this.lHasta);
            this.Controls.Add(this.tbDesde);
            this.Controls.Add(this.lDesde);
            this.Name = "Contar2";
            this.Text = "Contar2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDesde;
        private System.Windows.Forms.TextBox tbDesde;
        private System.Windows.Forms.Label lHasta;
        private System.Windows.Forms.TextBox tbHasta;
        private System.Windows.Forms.Button bContar;
        private System.Windows.Forms.Button bReiniciar;
        private System.Windows.Forms.TextBox tbCont;
    }
}

