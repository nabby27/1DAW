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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMayor60 = new System.Windows.Forms.RadioButton();
            this.rb40_60 = new System.Windows.Forms.RadioButton();
            this.rbMenor40 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lEdad = new System.Windows.Forms.Label();
            this.lSexo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMayor60);
            this.groupBox1.Controls.Add(this.rb40_60);
            this.groupBox1.Controls.Add(this.rbMenor40);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edad";
            // 
            // rbMayor60
            // 
            this.rbMayor60.AutoSize = true;
            this.rbMayor60.Location = new System.Drawing.Point(6, 76);
            this.rbMayor60.Name = "rbMayor60";
            this.rbMayor60.Size = new System.Drawing.Size(84, 17);
            this.rbMayor60.TabIndex = 2;
            this.rbMayor60.Text = "Mayor de 60";
            this.rbMayor60.UseVisualStyleBackColor = true;
            this.rbMayor60.CheckedChanged += new System.EventHandler(this.rbEdad_CheckedChanged);
            // 
            // rb40_60
            // 
            this.rb40_60.AutoSize = true;
            this.rb40_60.Location = new System.Drawing.Point(6, 53);
            this.rb40_60.Name = "rb40_60";
            this.rb40_60.Size = new System.Drawing.Size(88, 17);
            this.rb40_60.TabIndex = 1;
            this.rb40_60.Text = "Entre 40 y 60";
            this.rb40_60.UseVisualStyleBackColor = true;
            this.rb40_60.CheckedChanged += new System.EventHandler(this.rbEdad_CheckedChanged);
            // 
            // rbMenor40
            // 
            this.rbMenor40.AutoSize = true;
            this.rbMenor40.Location = new System.Drawing.Point(6, 30);
            this.rbMenor40.Name = "rbMenor40";
            this.rbMenor40.Size = new System.Drawing.Size(85, 17);
            this.rbMenor40.TabIndex = 0;
            this.rbMenor40.Text = "Menor de 40";
            this.rbMenor40.UseVisualStyleBackColor = true;
            this.rbMenor40.CheckedChanged += new System.EventHandler(this.rbEdad_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbHombre);
            this.groupBox2.Controls.Add(this.rbMujer);
            this.groupBox2.Location = new System.Drawing.Point(13, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(6, 28);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(62, 17);
            this.rbHombre.TabIndex = 1;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            this.rbHombre.CheckedChanged += new System.EventHandler(this.rbSexo_CheckedChanged);
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(6, 61);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(51, 17);
            this.rbMujer.TabIndex = 0;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            this.rbMujer.CheckedChanged += new System.EventHandler(this.rbSexo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Controles RadioButton";
            // 
            // lEdad
            // 
            this.lEdad.AutoSize = true;
            this.lEdad.Location = new System.Drawing.Point(16, 232);
            this.lEdad.Name = "lEdad";
            this.lEdad.Size = new System.Drawing.Size(35, 13);
            this.lEdad.TabIndex = 3;
            this.lEdad.Text = "label2";
            this.lEdad.Visible = false;
            // 
            // lSexo
            // 
            this.lSexo.AutoSize = true;
            this.lSexo.Location = new System.Drawing.Point(16, 254);
            this.lSexo.Name = "lSexo";
            this.lSexo.Size = new System.Drawing.Size(35, 13);
            this.lSexo.TabIndex = 4;
            this.lSexo.Text = "label3";
            this.lSexo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 295);
            this.Controls.Add(this.lSexo);
            this.Controls.Add(this.lEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Controles RadioButton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMayor60;
        private System.Windows.Forms.RadioButton rb40_60;
        private System.Windows.Forms.RadioButton rbMenor40;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lEdad;
        private System.Windows.Forms.Label lSexo;
    }
}

