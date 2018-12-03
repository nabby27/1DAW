namespace Ej3
{
    partial class ParesImpares
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
            this.tbNum = new System.Windows.Forms.TextBox();
            this.lParImpar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lCont = new System.Windows.Forms.Label();
            this.btCalculate = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lSumaPares = new System.Windows.Forms.Label();
            this.lSumaImpares = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular números pares e impares";
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(12, 31);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(100, 20);
            this.tbNum.TabIndex = 1;
            // 
            // lParImpar
            // 
            this.lParImpar.AutoSize = true;
            this.lParImpar.Location = new System.Drawing.Point(142, 34);
            this.lParImpar.Name = "lParImpar";
            this.lParImpar.Size = new System.Drawing.Size(19, 13);
            this.lParImpar.TabIndex = 2;
            this.lParImpar.Text = "¿?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "es";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "/ 10";
            // 
            // lCont
            // 
            this.lCont.AutoSize = true;
            this.lCont.Location = new System.Drawing.Point(66, 63);
            this.lCont.Name = "lCont";
            this.lCont.Size = new System.Drawing.Size(16, 13);
            this.lCont.TabIndex = 5;
            this.lCont.Text = "...";
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(233, 24);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(75, 23);
            this.btCalculate.TabIndex = 6;
            this.btCalculate.Text = "Calcular";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(233, 75);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 7;
            this.btReset.Text = "Reiniciar";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SUMA PARES ->";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SUMA IMPARES ->";
            // 
            // lSumaPares
            // 
            this.lSumaPares.AutoSize = true;
            this.lSumaPares.Location = new System.Drawing.Point(117, 99);
            this.lSumaPares.Name = "lSumaPares";
            this.lSumaPares.Size = new System.Drawing.Size(16, 13);
            this.lSumaPares.TabIndex = 10;
            this.lSumaPares.Text = "...";
            // 
            // lSumaImpares
            // 
            this.lSumaImpares.AutoSize = true;
            this.lSumaImpares.Location = new System.Drawing.Point(117, 126);
            this.lSumaImpares.Name = "lSumaImpares";
            this.lSumaImpares.Size = new System.Drawing.Size(16, 13);
            this.lSumaImpares.TabIndex = 11;
            this.lSumaImpares.Text = "...";
            // 
            // ParesImpares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 148);
            this.Controls.Add(this.lSumaImpares);
            this.Controls.Add(this.lSumaPares);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.lCont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lParImpar);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.label1);
            this.Name = "ParesImpares";
            this.Text = "Pares e Impares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label lParImpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lCont;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lSumaPares;
        private System.Windows.Forms.Label lSumaImpares;
    }
}

