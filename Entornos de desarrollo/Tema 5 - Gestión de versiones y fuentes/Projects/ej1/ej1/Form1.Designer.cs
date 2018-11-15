namespace ej1
{
    partial class Form1
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
            this.label = new System.Windows.Forms.Label();
            this.bNegrita = new System.Windows.Forms.Button();
            this.bCursiva = new System.Windows.Forms.Button();
            this.bTachado = new System.Windows.Forms.Button();
            this.bSubrayado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicio 1 tema 5";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(184, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(137, 13);
            this.label.TabIndex = 1;
            this.label.Text = "En un lugar de la mancha...";
            // 
            // bNegrita
            // 
            this.bNegrita.Location = new System.Drawing.Point(35, 76);
            this.bNegrita.Name = "bNegrita";
            this.bNegrita.Size = new System.Drawing.Size(75, 23);
            this.bNegrita.TabIndex = 2;
            this.bNegrita.Text = "Negrita";
            this.bNegrita.UseVisualStyleBackColor = true;
            this.bNegrita.Click += new System.EventHandler(this.bNegrita_Click);
            // 
            // bCursiva
            // 
            this.bCursiva.Location = new System.Drawing.Point(160, 76);
            this.bCursiva.Name = "bCursiva";
            this.bCursiva.Size = new System.Drawing.Size(75, 23);
            this.bCursiva.TabIndex = 3;
            this.bCursiva.Text = "Cursiva";
            this.bCursiva.UseVisualStyleBackColor = true;
            this.bCursiva.Click += new System.EventHandler(this.bCursiva_Click);
            // 
            // bTachado
            // 
            this.bTachado.Location = new System.Drawing.Point(286, 76);
            this.bTachado.Name = "bTachado";
            this.bTachado.Size = new System.Drawing.Size(75, 23);
            this.bTachado.TabIndex = 4;
            this.bTachado.Text = "Tachado";
            this.bTachado.UseVisualStyleBackColor = true;
            this.bTachado.Click += new System.EventHandler(this.bTachado_Click);
            // 
            // bSubrayado
            // 
            this.bSubrayado.Location = new System.Drawing.Point(405, 76);
            this.bSubrayado.Name = "bSubrayado";
            this.bSubrayado.Size = new System.Drawing.Size(75, 23);
            this.bSubrayado.TabIndex = 5;
            this.bSubrayado.Text = "Subrayado";
            this.bSubrayado.UseVisualStyleBackColor = true;
            this.bSubrayado.Click += new System.EventHandler(this.bSubrayado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 153);
            this.Controls.Add(this.bSubrayado);
            this.Controls.Add(this.bTachado);
            this.Controls.Add(this.bCursiva);
            this.Controls.Add(this.bNegrita);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gestión de la propiedad Font";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button bNegrita;
        private System.Windows.Forms.Button bCursiva;
        private System.Windows.Forms.Button bTachado;
        private System.Windows.Forms.Button bSubrayado;
    }
}

