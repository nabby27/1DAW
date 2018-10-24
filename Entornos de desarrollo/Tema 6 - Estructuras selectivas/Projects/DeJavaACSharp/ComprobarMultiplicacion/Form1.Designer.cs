namespace ComprobarMultiplicacion
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
            this.btStart = new System.Windows.Forms.Button();
            this.tbTabla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lNum = new System.Windows.Forms.Label();
            this.lPor = new System.Windows.Forms.Label();
            this.lX = new System.Windows.Forms.Label();
            this.lIgual = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btReset = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.lTextResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(229, 12);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 20);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Empezar";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.start);
            // 
            // tbTabla
            // 
            this.tbTabla.Location = new System.Drawing.Point(124, 12);
            this.tbTabla.Name = "tbTabla";
            this.tbTabla.Size = new System.Drawing.Size(99, 20);
            this.tbTabla.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tabla del :";
            // 
            // lNum
            // 
            this.lNum.AutoSize = true;
            this.lNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNum.Location = new System.Drawing.Point(56, 72);
            this.lNum.Name = "lNum";
            this.lNum.Size = new System.Drawing.Size(18, 20);
            this.lNum.TabIndex = 3;
            this.lNum.Text = "4";
            this.lNum.Visible = false;
            // 
            // lPor
            // 
            this.lPor.AutoSize = true;
            this.lPor.Location = new System.Drawing.Point(80, 77);
            this.lPor.Name = "lPor";
            this.lPor.Size = new System.Drawing.Size(12, 13);
            this.lPor.TabIndex = 4;
            this.lPor.Text = "x";
            this.lPor.Visible = false;
            // 
            // lX
            // 
            this.lX.AutoSize = true;
            this.lX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lX.Location = new System.Drawing.Point(98, 72);
            this.lX.Name = "lX";
            this.lX.Size = new System.Drawing.Size(18, 20);
            this.lX.TabIndex = 5;
            this.lX.Text = "0";
            this.lX.Visible = false;
            // 
            // lIgual
            // 
            this.lIgual.AutoSize = true;
            this.lIgual.Location = new System.Drawing.Point(117, 75);
            this.lIgual.Name = "lIgual";
            this.lIgual.Size = new System.Drawing.Size(13, 13);
            this.lIgual.TabIndex = 6;
            this.lIgual.Text = "=";
            this.lIgual.Visible = false;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(142, 72);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(78, 20);
            this.tbResult.TabIndex = 7;
            this.tbResult.Visible = false;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(277, 158);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 8;
            this.btReset.Text = "Reiniciar";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.reset);
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(233, 72);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(75, 20);
            this.btCheck.TabIndex = 9;
            this.btCheck.Text = "Comprobar";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Visible = false;
            this.btCheck.Click += new System.EventHandler(this.check);
            // 
            // lTextResult
            // 
            this.lTextResult.AutoSize = true;
            this.lTextResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTextResult.Location = new System.Drawing.Point(46, 125);
            this.lTextResult.Name = "lTextResult";
            this.lTextResult.Size = new System.Drawing.Size(46, 17);
            this.lTextResult.TabIndex = 10;
            this.lTextResult.Text = "label3";
            this.lTextResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 193);
            this.Controls.Add(this.lTextResult);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lIgual);
            this.Controls.Add(this.lX);
            this.Controls.Add(this.lPor);
            this.Controls.Add(this.lNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTabla);
            this.Controls.Add(this.btStart);
            this.Name = "Form1";
            this.Text = "Comprobar Multiplicación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox tbTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNum;
        private System.Windows.Forms.Label lPor;
        private System.Windows.Forms.Label lX;
        private System.Windows.Forms.Label lIgual;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Label lTextResult;
    }
}

