namespace Factorial
{
    partial class Factorial
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
            this.tbCalcular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.btReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCalcular
            // 
            this.tbCalcular.Location = new System.Drawing.Point(12, 25);
            this.tbCalcular.Name = "tbCalcular";
            this.tbCalcular.Size = new System.Drawing.Size(100, 20);
            this.tbCalcular.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserta un número:";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(131, 25);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 20);
            this.btCalcular.TabIndex = 2;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.calcular);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "-1 para cerrar";
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(12, 51);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.Size = new System.Drawing.Size(100, 20);
            this.tbResultado.TabIndex = 4;
            // 
            // btReiniciar
            // 
            this.btReiniciar.Location = new System.Drawing.Point(130, 82);
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(75, 20);
            this.btReiniciar.TabIndex = 5;
            this.btReiniciar.Text = "Reiniciar";
            this.btReiniciar.UseVisualStyleBackColor = true;
            this.btReiniciar.Click += new System.EventHandler(this.reset);
            // 
            // Factorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 114);
            this.Controls.Add(this.btReiniciar);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCalcular);
            this.Name = "Factorial";
            this.Text = "Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Button btReiniciar;
    }
}

