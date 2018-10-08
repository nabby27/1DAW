namespace Menu
{
    partial class Menu
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.btSumar = new System.Windows.Forms.Button();
            this.btRestar = new System.Windows.Forms.Button();
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.btDividir = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.btReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2";
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(30, 29);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(100, 20);
            this.tbNum1.TabIndex = 2;
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(168, 29);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(100, 20);
            this.tbNum2.TabIndex = 3;
            // 
            // btSumar
            // 
            this.btSumar.Location = new System.Drawing.Point(30, 78);
            this.btSumar.Name = "btSumar";
            this.btSumar.Size = new System.Drawing.Size(100, 23);
            this.btSumar.TabIndex = 4;
            this.btSumar.Text = "Sumar";
            this.btSumar.UseVisualStyleBackColor = true;
            this.btSumar.Click += new System.EventHandler(this.sumar);
            // 
            // btRestar
            // 
            this.btRestar.Location = new System.Drawing.Point(168, 77);
            this.btRestar.Name = "btRestar";
            this.btRestar.Size = new System.Drawing.Size(100, 23);
            this.btRestar.TabIndex = 5;
            this.btRestar.Text = "Restar";
            this.btRestar.UseVisualStyleBackColor = true;
            this.btRestar.Click += new System.EventHandler(this.restar);
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.Location = new System.Drawing.Point(30, 127);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(100, 23);
            this.btMultiplicar.TabIndex = 6;
            this.btMultiplicar.Text = "Multiplicar";
            this.btMultiplicar.UseVisualStyleBackColor = true;
            this.btMultiplicar.Click += new System.EventHandler(this.multiplicar);
            // 
            // btDividir
            // 
            this.btDividir.Location = new System.Drawing.Point(168, 127);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(100, 23);
            this.btDividir.TabIndex = 7;
            this.btDividir.Text = "Dividir";
            this.btDividir.UseVisualStyleBackColor = true;
            this.btDividir.Click += new System.EventHandler(this.dividir);
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(12, 226);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 8;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.cerrar);
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(63, 178);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.Size = new System.Drawing.Size(168, 20);
            this.tbResultado.TabIndex = 9;
            // 
            // btReiniciar
            // 
            this.btReiniciar.Location = new System.Drawing.Point(207, 226);
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btReiniciar.TabIndex = 10;
            this.btReiniciar.Text = "Reiniciar";
            this.btReiniciar.UseVisualStyleBackColor = true;
            this.btReiniciar.Click += new System.EventHandler(this.reiniciar);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 261);
            this.Controls.Add(this.btReiniciar);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.btMultiplicar);
            this.Controls.Add(this.btRestar);
            this.Controls.Add(this.btSumar);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Button btSumar;
        private System.Windows.Forms.Button btRestar;
        private System.Windows.Forms.Button btMultiplicar;
        private System.Windows.Forms.Button btDividir;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Button btReiniciar;
    }
}

