namespace NumerosNaturales
{
    partial class NumerosNaturales
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btReiniciarContar = new System.Windows.Forms.Button();
            this.btContar = new System.Windows.Forms.Button();
            this.tbResultadoCalcular = new System.Windows.Forms.TextBox();
            this.tbFinNumCalcular = new System.Windows.Forms.TextBox();
            this.tbInitNumCalcular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btReiniciarTabla = new System.Windows.Forms.Button();
            this.btCalcularTabla = new System.Windows.Forms.Button();
            this.tbResultadoTabla = new System.Windows.Forms.TextBox();
            this.tbNumTabla = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btCalcularParImpar = new System.Windows.Forms.Button();
            this.btReiniciarParImpar = new System.Windows.Forms.Button();
            this.tbImpar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumParImpar = new System.Windows.Forms.TextBox();
            this.lbResultadoParImpar = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btReiniciarContar);
            this.groupBox1.Controls.Add(this.btContar);
            this.groupBox1.Controls.Add(this.tbResultadoCalcular);
            this.groupBox1.Controls.Add(this.tbFinNumCalcular);
            this.groupBox1.Controls.Add(this.tbInitNumCalcular);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contar Números";
            // 
            // btReiniciarContar
            // 
            this.btReiniciarContar.Location = new System.Drawing.Point(6, 227);
            this.btReiniciarContar.Name = "btReiniciarContar";
            this.btReiniciarContar.Size = new System.Drawing.Size(75, 20);
            this.btReiniciarContar.TabIndex = 6;
            this.btReiniciarContar.Text = "Reiniciar";
            this.btReiniciarContar.UseVisualStyleBackColor = true;
            this.btReiniciarContar.Click += new System.EventHandler(this.resetContar);
            // 
            // btContar
            // 
            this.btContar.Location = new System.Drawing.Point(10, 132);
            this.btContar.Name = "btContar";
            this.btContar.Size = new System.Drawing.Size(100, 20);
            this.btContar.TabIndex = 5;
            this.btContar.Text = "Contar";
            this.btContar.UseVisualStyleBackColor = true;
            this.btContar.Click += new System.EventHandler(this.contar);
            // 
            // tbResultadoCalcular
            // 
            this.tbResultadoCalcular.Location = new System.Drawing.Point(138, 20);
            this.tbResultadoCalcular.Multiline = true;
            this.tbResultadoCalcular.Name = "tbResultadoCalcular";
            this.tbResultadoCalcular.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultadoCalcular.Size = new System.Drawing.Size(100, 217);
            this.tbResultadoCalcular.TabIndex = 4;
            // 
            // tbFinNumCalcular
            // 
            this.tbFinNumCalcular.Location = new System.Drawing.Point(10, 89);
            this.tbFinNumCalcular.Name = "tbFinNumCalcular";
            this.tbFinNumCalcular.Size = new System.Drawing.Size(100, 20);
            this.tbFinNumCalcular.TabIndex = 3;
            // 
            // tbInitNumCalcular
            // 
            this.tbInitNumCalcular.Location = new System.Drawing.Point(10, 48);
            this.tbInitNumCalcular.Name = "tbInitNumCalcular";
            this.tbInitNumCalcular.Size = new System.Drawing.Size(100, 20);
            this.tbInitNumCalcular.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta el número:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde el número:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btReiniciarTabla);
            this.groupBox2.Controls.Add(this.btCalcularTabla);
            this.groupBox2.Controls.Add(this.tbResultadoTabla);
            this.groupBox2.Controls.Add(this.tbNumTabla);
            this.groupBox2.Location = new System.Drawing.Point(263, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabla de multiplicar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tabla de multiplicar del:";
            // 
            // btReiniciarTabla
            // 
            this.btReiniciarTabla.Location = new System.Drawing.Point(6, 227);
            this.btReiniciarTabla.Name = "btReiniciarTabla";
            this.btReiniciarTabla.Size = new System.Drawing.Size(75, 20);
            this.btReiniciarTabla.TabIndex = 3;
            this.btReiniciarTabla.Text = "Reiniciar";
            this.btReiniciarTabla.UseVisualStyleBackColor = true;
            this.btReiniciarTabla.Click += new System.EventHandler(this.resetTabla);
            // 
            // btCalcularTabla
            // 
            this.btCalcularTabla.Location = new System.Drawing.Point(178, 36);
            this.btCalcularTabla.Name = "btCalcularTabla";
            this.btCalcularTabla.Size = new System.Drawing.Size(75, 20);
            this.btCalcularTabla.TabIndex = 2;
            this.btCalcularTabla.Text = "Calcular";
            this.btCalcularTabla.UseVisualStyleBackColor = true;
            this.btCalcularTabla.Click += new System.EventHandler(this.calcularTabla);
            // 
            // tbResultadoTabla
            // 
            this.tbResultadoTabla.Location = new System.Drawing.Point(6, 62);
            this.tbResultadoTabla.Multiline = true;
            this.tbResultadoTabla.Name = "tbResultadoTabla";
            this.tbResultadoTabla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultadoTabla.Size = new System.Drawing.Size(247, 159);
            this.tbResultadoTabla.TabIndex = 1;
            // 
            // tbNumTabla
            // 
            this.tbNumTabla.Location = new System.Drawing.Point(6, 36);
            this.tbNumTabla.Name = "tbNumTabla";
            this.tbNumTabla.Size = new System.Drawing.Size(151, 20);
            this.tbNumTabla.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbResultadoParImpar);
            this.groupBox3.Controls.Add(this.btCalcularParImpar);
            this.groupBox3.Controls.Add(this.btReiniciarParImpar);
            this.groupBox3.Controls.Add(this.tbImpar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbPar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbNumParImpar);
            this.groupBox3.Location = new System.Drawing.Point(529, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 253);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Par o Impar";
            // 
            // btCalcularParImpar
            // 
            this.btCalcularParImpar.Location = new System.Drawing.Point(215, 227);
            this.btCalcularParImpar.Name = "btCalcularParImpar";
            this.btCalcularParImpar.Size = new System.Drawing.Size(100, 20);
            this.btCalcularParImpar.TabIndex = 8;
            this.btCalcularParImpar.Text = "Calcular";
            this.btCalcularParImpar.UseVisualStyleBackColor = true;
            this.btCalcularParImpar.Click += new System.EventHandler(this.calcularParImpar);
            // 
            // btReiniciarParImpar
            // 
            this.btReiniciarParImpar.Location = new System.Drawing.Point(7, 227);
            this.btReiniciarParImpar.Name = "btReiniciarParImpar";
            this.btReiniciarParImpar.Size = new System.Drawing.Size(75, 20);
            this.btReiniciarParImpar.TabIndex = 7;
            this.btReiniciarParImpar.Text = "Reiniciar";
            this.btReiniciarParImpar.UseVisualStyleBackColor = true;
            this.btReiniciarParImpar.Click += new System.EventHandler(this.resetParImpar);
            // 
            // tbImpar
            // 
            this.tbImpar.Location = new System.Drawing.Point(106, 89);
            this.tbImpar.Multiline = true;
            this.tbImpar.Name = "tbImpar";
            this.tbImpar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbImpar.Size = new System.Drawing.Size(75, 132);
            this.tbImpar.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Impares";
            // 
            // tbPar
            // 
            this.tbPar.Location = new System.Drawing.Point(7, 89);
            this.tbPar.Multiline = true;
            this.tbPar.Name = "tbPar";
            this.tbPar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPar.Size = new System.Drawing.Size(75, 132);
            this.tbPar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inserte 15 números (pulse enter)";
            // 
            // tbNumParImpar
            // 
            this.tbNumParImpar.Location = new System.Drawing.Point(7, 47);
            this.tbNumParImpar.Name = "tbNumParImpar";
            this.tbNumParImpar.Size = new System.Drawing.Size(193, 20);
            this.tbNumParImpar.TabIndex = 0;
            this.tbNumParImpar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addParImpar);
            // 
            // lbResultadoParImpar
            // 
            this.lbResultadoParImpar.FormattingEnabled = true;
            this.lbResultadoParImpar.Location = new System.Drawing.Point(215, 45);
            this.lbResultadoParImpar.Name = "lbResultadoParImpar";
            this.lbResultadoParImpar.Size = new System.Drawing.Size(100, 173);
            this.lbResultadoParImpar.TabIndex = 9;
            // 
            // NumerosNaturales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 278);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NumerosNaturales";
            this.Text = "Contar Números";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btReiniciarContar;
        private System.Windows.Forms.Button btContar;
        private System.Windows.Forms.TextBox tbResultadoCalcular;
        private System.Windows.Forms.TextBox tbFinNumCalcular;
        private System.Windows.Forms.TextBox tbInitNumCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btReiniciarTabla;
        private System.Windows.Forms.Button btCalcularTabla;
        private System.Windows.Forms.TextBox tbResultadoTabla;
        private System.Windows.Forms.TextBox tbNumTabla;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btCalcularParImpar;
        private System.Windows.Forms.Button btReiniciarParImpar;
        private System.Windows.Forms.TextBox tbImpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumParImpar;
        private System.Windows.Forms.ListBox lbResultadoParImpar;
    }
}

