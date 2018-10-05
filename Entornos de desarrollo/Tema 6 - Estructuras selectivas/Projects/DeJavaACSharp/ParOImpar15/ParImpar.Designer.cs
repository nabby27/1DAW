namespace ParOImpar15
{
    partial class ParImpar
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
            this.lCont = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.bAnadir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lNumPares = new System.Windows.Forms.Label();
            this.lNumImpares = new System.Windows.Forms.Label();
            this.bReiniciar = new System.Windows.Forms.Button();
            this.lParOImpar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lCont
            // 
            this.lCont.AutoSize = true;
            this.lCont.Location = new System.Drawing.Point(12, 9);
            this.lCont.Name = "lCont";
            this.lCont.Size = new System.Drawing.Size(60, 13);
            this.lCont.TabIndex = 0;
            this.lCont.Text = "Quedan 15";
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(12, 25);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(110, 20);
            this.tbNum.TabIndex = 1;
            // 
            // bAnadir
            // 
            this.bAnadir.Location = new System.Drawing.Point(128, 25);
            this.bAnadir.Name = "bAnadir";
            this.bAnadir.Size = new System.Drawing.Size(96, 23);
            this.bAnadir.TabIndex = 2;
            this.bAnadir.Text = "Añadir";
            this.bAnadir.UseVisualStyleBackColor = true;
            this.bAnadir.Click += new System.EventHandler(this.anadir);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pares:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Impares:";
            // 
            // lNumPares
            // 
            this.lNumPares.AutoSize = true;
            this.lNumPares.Location = new System.Drawing.Point(127, 103);
            this.lNumPares.Name = "lNumPares";
            this.lNumPares.Size = new System.Drawing.Size(0, 13);
            this.lNumPares.TabIndex = 5;
            // 
            // lNumImpares
            // 
            this.lNumImpares.AutoSize = true;
            this.lNumImpares.Location = new System.Drawing.Point(127, 141);
            this.lNumImpares.Name = "lNumImpares";
            this.lNumImpares.Size = new System.Drawing.Size(0, 13);
            this.lNumImpares.TabIndex = 6;
            // 
            // bReiniciar
            // 
            this.bReiniciar.Location = new System.Drawing.Point(15, 180);
            this.bReiniciar.Name = "bReiniciar";
            this.bReiniciar.Size = new System.Drawing.Size(211, 23);
            this.bReiniciar.TabIndex = 7;
            this.bReiniciar.Text = "Reiniciar";
            this.bReiniciar.UseVisualStyleBackColor = true;
            this.bReiniciar.Click += new System.EventHandler(this.reset);
            // 
            // lParOImpar
            // 
            this.lParOImpar.AutoSize = true;
            this.lParOImpar.Location = new System.Drawing.Point(12, 57);
            this.lParOImpar.Name = "lParOImpar";
            this.lParOImpar.Size = new System.Drawing.Size(0, 13);
            this.lParOImpar.TabIndex = 8;
            // 
            // ParImpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 216);
            this.Controls.Add(this.lParOImpar);
            this.Controls.Add(this.bReiniciar);
            this.Controls.Add(this.lNumImpares);
            this.Controls.Add(this.lNumPares);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAnadir);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.lCont);
            this.Name = "ParImpar";
            this.Text = "Par o Impar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCont;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Button bAnadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lNumPares;
        private System.Windows.Forms.Label lNumImpares;
        private System.Windows.Forms.Button bReiniciar;
        private System.Windows.Forms.Label lParOImpar;
    }
}

