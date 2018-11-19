namespace Ej1
{
    partial class Eventos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lMouseText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btRed = new System.Windows.Forms.Button();
            this.btBlue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lKeyText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ratón";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lMouseText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 100);
            this.panel1.TabIndex = 1;
            // 
            // lMouseText
            // 
            this.lMouseText.AutoSize = true;
            this.lMouseText.Location = new System.Drawing.Point(18, 58);
            this.lMouseText.Name = "lMouseText";
            this.lMouseText.Size = new System.Drawing.Size(100, 13);
            this.lMouseText.TabIndex = 1;
            this.lMouseText.Text = "Posición del ratón...";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Controls.Add(this.btRed);
            this.panel2.Controls.Add(this.btBlue);
            this.panel2.Location = new System.Drawing.Point(12, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 81);
            this.panel2.TabIndex = 2;
            // 
            // btRed
            // 
            this.btRed.Location = new System.Drawing.Point(279, 17);
            this.btRed.Name = "btRed";
            this.btRed.Size = new System.Drawing.Size(136, 47);
            this.btRed.TabIndex = 1;
            this.btRed.Text = "Rojo";
            this.btRed.UseVisualStyleBackColor = true;
            this.btRed.Click += new System.EventHandler(this.btRed_Click);
            // 
            // btBlue
            // 
            this.btBlue.Location = new System.Drawing.Point(74, 17);
            this.btBlue.Name = "btBlue";
            this.btBlue.Size = new System.Drawing.Size(148, 47);
            this.btBlue.TabIndex = 0;
            this.btBlue.Text = "Azul";
            this.btBlue.UseVisualStyleBackColor = true;
            this.btBlue.Click += new System.EventHandler(this.btBlue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teclado";
            // 
            // lKeyText
            // 
            this.lKeyText.AutoSize = true;
            this.lKeyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKeyText.Location = new System.Drawing.Point(380, 70);
            this.lKeyText.Name = "lKeyText";
            this.lKeyText.Size = new System.Drawing.Size(0, 31);
            this.lKeyText.TabIndex = 3;
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 232);
            this.Controls.Add(this.lKeyText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Eventos";
            this.Text = "Eventos Ratón y Teclado";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lMouseText;
        private System.Windows.Forms.Button btRed;
        private System.Windows.Forms.Button btBlue;
        private System.Windows.Forms.Label lKeyText;
    }
}

