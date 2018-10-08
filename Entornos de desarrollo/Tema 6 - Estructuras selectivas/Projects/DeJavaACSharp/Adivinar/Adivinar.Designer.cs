namespace Adivinar
{
    partial class Adivinar
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
            this.bReiniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.bOcultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdivina = new System.Windows.Forms.TextBox();
            this.btAdivina = new System.Windows.Forms.Button();
            this.lIntentos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bReiniciar
            // 
            this.bReiniciar.Location = new System.Drawing.Point(96, 133);
            this.bReiniciar.Name = "bReiniciar";
            this.bReiniciar.Size = new System.Drawing.Size(75, 23);
            this.bReiniciar.TabIndex = 0;
            this.bReiniciar.Text = "Reiniciar";
            this.bReiniciar.UseVisualStyleBackColor = true;
            this.bReiniciar.Click += new System.EventHandler(this.reset);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escribe el número a adivinar:";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(15, 26);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(140, 20);
            this.tbNumero.TabIndex = 2;
            // 
            // bOcultar
            // 
            this.bOcultar.Location = new System.Drawing.Point(161, 26);
            this.bOcultar.Name = "bOcultar";
            this.bOcultar.Size = new System.Drawing.Size(75, 20);
            this.bOcultar.TabIndex = 3;
            this.bOcultar.Text = "Ocultar";
            this.bOcultar.UseVisualStyleBackColor = true;
            this.bOcultar.Click += new System.EventHandler(this.ocultarNumero);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adivina el número:";
            // 
            // tbAdivina
            // 
            this.tbAdivina.Location = new System.Drawing.Point(15, 82);
            this.tbAdivina.Name = "tbAdivina";
            this.tbAdivina.Size = new System.Drawing.Size(140, 20);
            this.tbAdivina.TabIndex = 5;
            // 
            // btAdivina
            // 
            this.btAdivina.Location = new System.Drawing.Point(161, 79);
            this.btAdivina.Name = "btAdivina";
            this.btAdivina.Size = new System.Drawing.Size(75, 23);
            this.btAdivina.TabIndex = 6;
            this.btAdivina.Text = "Adivina";
            this.btAdivina.UseVisualStyleBackColor = true;
            this.btAdivina.Click += new System.EventHandler(this.adivinar);
            // 
            // lIntentos
            // 
            this.lIntentos.AutoSize = true;
            this.lIntentos.Location = new System.Drawing.Point(15, 109);
            this.lIntentos.Name = "lIntentos";
            this.lIntentos.Size = new System.Drawing.Size(0, 13);
            this.lIntentos.TabIndex = 7;
            this.lIntentos.Visible = false;
            // 
            // Adivinar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 168);
            this.Controls.Add(this.lIntentos);
            this.Controls.Add(this.btAdivina);
            this.Controls.Add(this.tbAdivina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bOcultar);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bReiniciar);
            this.Name = "Adivinar";
            this.Text = "Adivinar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bReiniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Button bOcultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdivina;
        private System.Windows.Forms.Button btAdivina;
        private System.Windows.Forms.Label lIntentos;
    }
}

