namespace Primo
{
    partial class Primo
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
            this.tbNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btReiniciar = new System.Windows.Forms.Button();
            this.lPrimo = new System.Windows.Forms.Label();
            this.btArreglar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(16, 29);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(105, 20);
            this.tbNum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduce un número:";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(144, 29);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 20);
            this.btCalcular.TabIndex = 2;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.calcular);
            // 
            // btReiniciar
            // 
            this.btReiniciar.Location = new System.Drawing.Point(160, 100);
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(75, 20);
            this.btReiniciar.TabIndex = 3;
            this.btReiniciar.Text = "Reiniciar";
            this.btReiniciar.UseVisualStyleBackColor = true;
            this.btReiniciar.Click += new System.EventHandler(this.reset);
            // 
            // lPrimo
            // 
            this.lPrimo.AutoSize = true;
            this.lPrimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrimo.Location = new System.Drawing.Point(68, 67);
            this.lPrimo.Name = "lPrimo";
            this.lPrimo.Size = new System.Drawing.Size(0, 17);
            this.lPrimo.TabIndex = 4;
            this.lPrimo.Visible = false;
            // 
            // btArreglar
            // 
            this.btArreglar.Location = new System.Drawing.Point(16, 100);
            this.btArreglar.Name = "btArreglar";
            this.btArreglar.Size = new System.Drawing.Size(75, 20);
            this.btArreglar.TabIndex = 5;
            this.btArreglar.Text = "Arreglar";
            this.btArreglar.UseVisualStyleBackColor = true;
            this.btArreglar.Visible = false;
            this.btArreglar.Click += new System.EventHandler(this.arreglar);
            // 
            // Primo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 132);
            this.Controls.Add(this.btArreglar);
            this.Controls.Add(this.lPrimo);
            this.Controls.Add(this.btReiniciar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNum);
            this.Name = "Primo";
            this.Text = "Primo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btReiniciar;
        private System.Windows.Forms.Label lPrimo;
        private System.Windows.Forms.Button btArreglar;
    }
}

