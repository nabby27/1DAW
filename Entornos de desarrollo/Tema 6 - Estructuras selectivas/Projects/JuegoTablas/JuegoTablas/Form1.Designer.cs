namespace JuegoTablas
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
            this.lTitle = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.lable2 = new System.Windows.Forms.Label();
            this.lResultado = new System.Windows.Forms.Label();
            this.btPlay = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.lMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Location = new System.Drawing.Point(13, 13);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(148, 13);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "¿Con que tabla quieres jugar?";
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(16, 29);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(145, 20);
            this.tbNum.TabIndex = 1;
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(13, 121);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(48, 13);
            this.lable2.TabIndex = 2;
            this.lable2.Text = "Aciertos:";
            this.lable2.Visible = false;
            // 
            // lResultado
            // 
            this.lResultado.AutoSize = true;
            this.lResultado.Location = new System.Drawing.Point(68, 121);
            this.lResultado.Name = "lResultado";
            this.lResultado.Size = new System.Drawing.Size(0, 13);
            this.lResultado.TabIndex = 3;
            this.lResultado.Visible = false;
            // 
            // btPlay
            // 
            this.btPlay.Location = new System.Drawing.Point(221, 28);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(75, 21);
            this.btPlay.TabIndex = 4;
            this.btPlay.Text = "Jugar";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.play);
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(221, 69);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(75, 21);
            this.btChange.TabIndex = 5;
            this.btChange.Text = "Cambiar";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.change);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(221, 117);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 21);
            this.btReset.TabIndex = 6;
            this.btReset.Text = "Reiniciar";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.reset);
            // 
            // lMsg
            // 
            this.lMsg.AutoSize = true;
            this.lMsg.Location = new System.Drawing.Point(16, 76);
            this.lMsg.Name = "lMsg";
            this.lMsg.Size = new System.Drawing.Size(0, 13);
            this.lMsg.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 146);
            this.Controls.Add(this.lMsg);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.lResultado);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.lTitle);
            this.Name = "Form1";
            this.Text = "Juego con las tablas de múltiplicar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label lResultado;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label lMsg;
    }
}

