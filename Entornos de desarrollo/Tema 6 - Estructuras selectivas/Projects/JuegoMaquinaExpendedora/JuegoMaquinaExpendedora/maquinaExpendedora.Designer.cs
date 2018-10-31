namespace JuegoMaquinaExpendedora
{
    partial class maquinaExpendedora
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
            this.label3 = new System.Windows.Forms.Label();
            this.btPagar = new System.Windows.Forms.Button();
            this.rbRefresco = new System.Windows.Forms.RadioButton();
            this.rbAgua = new System.Windows.Forms.RadioButton();
            this.rbCafe = new System.Windows.Forms.RadioButton();
            this.lPrecioRefresco = new System.Windows.Forms.Label();
            this.lPrecioAgua = new System.Windows.Forms.Label();
            this.lPrecioCafe = new System.Windows.Forms.Label();
            this.lIntroducirDinero = new System.Windows.Forms.Label();
            this.tbDinero = new System.Windows.Forms.TextBox();
            this.lCantidadDinero = new System.Windows.Forms.Label();
            this.tbDineroDevolver = new System.Windows.Forms.TextBox();
            this.lDineroDevolver = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.lCantidadNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Refresco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Café";
            // 
            // btPagar
            // 
            this.btPagar.Location = new System.Drawing.Point(197, 76);
            this.btPagar.Name = "btPagar";
            this.btPagar.Size = new System.Drawing.Size(75, 23);
            this.btPagar.TabIndex = 3;
            this.btPagar.Text = "Comprar";
            this.btPagar.UseVisualStyleBackColor = true;
            this.btPagar.Click += new System.EventHandler(this.pagar);
            // 
            // rbRefresco
            // 
            this.rbRefresco.AutoSize = true;
            this.rbRefresco.Location = new System.Drawing.Point(30, 17);
            this.rbRefresco.Name = "rbRefresco";
            this.rbRefresco.Size = new System.Drawing.Size(14, 13);
            this.rbRefresco.TabIndex = 4;
            this.rbRefresco.TabStop = true;
            this.rbRefresco.UseVisualStyleBackColor = true;
            // 
            // rbAgua
            // 
            this.rbAgua.AutoSize = true;
            this.rbAgua.Location = new System.Drawing.Point(192, 17);
            this.rbAgua.Name = "rbAgua";
            this.rbAgua.Size = new System.Drawing.Size(14, 13);
            this.rbAgua.TabIndex = 5;
            this.rbAgua.TabStop = true;
            this.rbAgua.UseVisualStyleBackColor = true;
            // 
            // rbCafe
            // 
            this.rbCafe.AutoSize = true;
            this.rbCafe.Location = new System.Drawing.Point(337, 17);
            this.rbCafe.Name = "rbCafe";
            this.rbCafe.Size = new System.Drawing.Size(14, 13);
            this.rbCafe.TabIndex = 6;
            this.rbCafe.TabStop = true;
            this.rbCafe.UseVisualStyleBackColor = true;
            // 
            // lPrecioRefresco
            // 
            this.lPrecioRefresco.AutoSize = true;
            this.lPrecioRefresco.Location = new System.Drawing.Point(63, 30);
            this.lPrecioRefresco.Name = "lPrecioRefresco";
            this.lPrecioRefresco.Size = new System.Drawing.Size(28, 13);
            this.lPrecioRefresco.TabIndex = 7;
            this.lPrecioRefresco.Text = "55 €";
            // 
            // lPrecioAgua
            // 
            this.lPrecioAgua.AutoSize = true;
            this.lPrecioAgua.Location = new System.Drawing.Point(220, 30);
            this.lPrecioAgua.Name = "lPrecioAgua";
            this.lPrecioAgua.Size = new System.Drawing.Size(28, 13);
            this.lPrecioAgua.TabIndex = 8;
            this.lPrecioAgua.Text = "55 €";
            // 
            // lPrecioCafe
            // 
            this.lPrecioCafe.AutoSize = true;
            this.lPrecioCafe.Location = new System.Drawing.Point(365, 30);
            this.lPrecioCafe.Name = "lPrecioCafe";
            this.lPrecioCafe.Size = new System.Drawing.Size(28, 13);
            this.lPrecioCafe.TabIndex = 9;
            this.lPrecioCafe.Text = "55 €";
            // 
            // lIntroducirDinero
            // 
            this.lIntroducirDinero.AutoSize = true;
            this.lIntroducirDinero.Location = new System.Drawing.Point(85, 122);
            this.lIntroducirDinero.Name = "lIntroducirDinero";
            this.lIntroducirDinero.Size = new System.Drawing.Size(298, 13);
            this.lIntroducirDinero.TabIndex = 10;
            this.lIntroducirDinero.Text = "Introduce la cantidad a pagar (solo monedas de 10, 50 o 100)";
            // 
            // tbDinero
            // 
            this.tbDinero.Location = new System.Drawing.Point(184, 153);
            this.tbDinero.Name = "tbDinero";
            this.tbDinero.Size = new System.Drawing.Size(100, 20);
            this.tbDinero.TabIndex = 11;
            this.tbDinero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.insertMoney);
            // 
            // lCantidadDinero
            // 
            this.lCantidadDinero.AutoSize = true;
            this.lCantidadDinero.Location = new System.Drawing.Point(136, 176);
            this.lCantidadDinero.Name = "lCantidadDinero";
            this.lCantidadDinero.Size = new System.Drawing.Size(101, 13);
            this.lCantidadDinero.TabIndex = 12;
            this.lCantidadDinero.Text = "Cantidad ingresada:";
            // 
            // tbDineroDevolver
            // 
            this.tbDineroDevolver.Location = new System.Drawing.Point(184, 212);
            this.tbDineroDevolver.Name = "tbDineroDevolver";
            this.tbDineroDevolver.ReadOnly = true;
            this.tbDineroDevolver.Size = new System.Drawing.Size(100, 20);
            this.tbDineroDevolver.TabIndex = 13;
            // 
            // lDineroDevolver
            // 
            this.lDineroDevolver.AutoSize = true;
            this.lDineroDevolver.Location = new System.Drawing.Point(93, 215);
            this.lDineroDevolver.Name = "lDineroDevolver";
            this.lDineroDevolver.Size = new System.Drawing.Size(85, 13);
            this.lDineroDevolver.TabIndex = 14;
            this.lDineroDevolver.Text = "Dinero devuelto:";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(382, 227);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 15;
            this.btReset.Text = "Reiniciar";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.reset);
            // 
            // lCantidadNumero
            // 
            this.lCantidadNumero.AutoSize = true;
            this.lCantidadNumero.Location = new System.Drawing.Point(244, 176);
            this.lCantidadNumero.Name = "lCantidadNumero";
            this.lCantidadNumero.Size = new System.Drawing.Size(0, 13);
            this.lCantidadNumero.TabIndex = 16;
            // 
            // maquinaExpendedora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 262);
            this.Controls.Add(this.lCantidadNumero);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.lDineroDevolver);
            this.Controls.Add(this.tbDineroDevolver);
            this.Controls.Add(this.lCantidadDinero);
            this.Controls.Add(this.tbDinero);
            this.Controls.Add(this.lIntroducirDinero);
            this.Controls.Add(this.lPrecioCafe);
            this.Controls.Add(this.lPrecioAgua);
            this.Controls.Add(this.lPrecioRefresco);
            this.Controls.Add(this.rbCafe);
            this.Controls.Add(this.rbAgua);
            this.Controls.Add(this.rbRefresco);
            this.Controls.Add(this.btPagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "maquinaExpendedora";
            this.Text = "Máquina expendedora";
            this.Load += new System.EventHandler(this.load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPagar;
        private System.Windows.Forms.RadioButton rbRefresco;
        private System.Windows.Forms.RadioButton rbAgua;
        private System.Windows.Forms.RadioButton rbCafe;
        private System.Windows.Forms.Label lPrecioRefresco;
        private System.Windows.Forms.Label lPrecioAgua;
        private System.Windows.Forms.Label lPrecioCafe;
        private System.Windows.Forms.Label lIntroducirDinero;
        private System.Windows.Forms.TextBox tbDinero;
        private System.Windows.Forms.Label lCantidadDinero;
        private System.Windows.Forms.TextBox tbDineroDevolver;
        private System.Windows.Forms.Label lDineroDevolver;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label lCantidadNumero;
    }
}

