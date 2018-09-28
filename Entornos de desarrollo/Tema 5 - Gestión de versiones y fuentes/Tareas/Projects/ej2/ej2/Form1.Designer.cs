namespace ej2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lText = new System.Windows.Forms.Label();
            this.bRojo = new System.Windows.Forms.Button();
            this.bAzul1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lTeclado = new System.Windows.Forms.Label();
            this.lRaton = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lText);
            this.groupBox1.Controls.Add(this.bRojo);
            this.groupBox1.Controls.Add(this.bAzul1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lText
            // 
            this.lText.AutoSize = true;
            this.lText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lText.Location = new System.Drawing.Point(100, 74);
            this.lText.Name = "lText";
            this.lText.Size = new System.Drawing.Size(331, 31);
            this.lText.TabIndex = 2;
            this.lText.Text = "Texto que cambia de color";
            this.lText.Visible = false;
            // 
            // bRojo
            // 
            this.bRojo.Location = new System.Drawing.Point(371, 19);
            this.bRojo.Name = "bRojo";
            this.bRojo.Size = new System.Drawing.Size(149, 34);
            this.bRojo.TabIndex = 1;
            this.bRojo.Text = "Rojo";
            this.bRojo.UseVisualStyleBackColor = true;
            this.bRojo.Click += new System.EventHandler(this.bRojo_Click);
            // 
            // bAzul1
            // 
            this.bAzul1.Location = new System.Drawing.Point(6, 19);
            this.bAzul1.Name = "bAzul1";
            this.bAzul1.Size = new System.Drawing.Size(149, 34);
            this.bAzul1.TabIndex = 0;
            this.bAzul1.Text = "Azul";
            this.bAzul1.UseVisualStyleBackColor = true;
            this.bAzul1.Click += new System.EventHandler(this.bAzul1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lRaton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ratón";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pulsa el ratón";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lTeclado);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(297, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teclado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aprieta una tecla";
            // 
            // lTeclado
            // 
            this.lTeclado.AutoSize = true;
            this.lTeclado.Location = new System.Drawing.Point(7, 64);
            this.lTeclado.Name = "lTeclado";
            this.lTeclado.Size = new System.Drawing.Size(35, 13);
            this.lTeclado.TabIndex = 1;
            this.lTeclado.Text = "label4";
            this.lTeclado.Visible = false;
            // 
            // lRaton
            // 
            this.lRaton.AutoSize = true;
            this.lRaton.Location = new System.Drawing.Point(6, 63);
            this.lRaton.Name = "lRaton";
            this.lRaton.Size = new System.Drawing.Size(35, 13);
            this.lRaton.TabIndex = 1;
            this.lRaton.Text = "label4";
            this.lRaton.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 291);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
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
        private System.Windows.Forms.Label lText;
        private System.Windows.Forms.Button bRojo;
        private System.Windows.Forms.Button bAzul1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lRaton;
        private System.Windows.Forms.Label lTeclado;
    }
}

