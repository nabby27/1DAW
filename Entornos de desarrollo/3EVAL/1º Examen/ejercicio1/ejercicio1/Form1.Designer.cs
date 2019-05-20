namespace ejercicio1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAlumnos = new System.Windows.Forms.TabPage();
            this.tabAsignar = new System.Windows.Forms.TabPage();
            this.tabResultado = new System.Windows.Forms.TabPage();
            this.btSeleccionar = new System.Windows.Forms.Button();
            this.btSiguiente1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btAsignarOptativa = new System.Windows.Forms.Button();
            this.btSiguiente2 = new System.Windows.Forms.Button();
            this.lbAlumnosAsignar = new System.Windows.Forms.ListBox();
            this.tbAsignar = new System.Windows.Forms.TextBox();
            this.btAsignarAlumno = new System.Windows.Forms.Button();
            this.cbOptativas1 = new System.Windows.Forms.ComboBox();
            this.cbOptativas2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.clbAlumnos = new System.Windows.Forms.CheckedListBox();
            this.tabControl.SuspendLayout();
            this.tabAlumnos.SuspendLayout();
            this.tabAsignar.SuspendLayout();
            this.tabResultado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAlumnos);
            this.tabControl.Controls.Add(this.tabAsignar);
            this.tabControl.Controls.Add(this.tabResultado);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(671, 359);
            this.tabControl.TabIndex = 0;
            // 
            // tabAlumnos
            // 
            this.tabAlumnos.Controls.Add(this.groupBox1);
            this.tabAlumnos.Controls.Add(this.btSiguiente1);
            this.tabAlumnos.Controls.Add(this.btSeleccionar);
            this.tabAlumnos.Location = new System.Drawing.Point(4, 22);
            this.tabAlumnos.Name = "tabAlumnos";
            this.tabAlumnos.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlumnos.Size = new System.Drawing.Size(663, 333);
            this.tabAlumnos.TabIndex = 0;
            this.tabAlumnos.Text = "ALUMNOS";
            this.tabAlumnos.UseVisualStyleBackColor = true;
            // 
            // tabAsignar
            // 
            this.tabAsignar.Controls.Add(this.btSiguiente2);
            this.tabAsignar.Controls.Add(this.btAsignarOptativa);
            this.tabAsignar.Controls.Add(this.groupBox4);
            this.tabAsignar.Controls.Add(this.groupBox3);
            this.tabAsignar.Controls.Add(this.groupBox2);
            this.tabAsignar.Location = new System.Drawing.Point(4, 22);
            this.tabAsignar.Name = "tabAsignar";
            this.tabAsignar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsignar.Size = new System.Drawing.Size(663, 333);
            this.tabAsignar.TabIndex = 1;
            this.tabAsignar.Text = "ASIGNAR OPTATIVA";
            this.tabAsignar.UseVisualStyleBackColor = true;
            // 
            // tabResultado
            // 
            this.tabResultado.Controls.Add(this.btFinalizar);
            this.tabResultado.Controls.Add(this.groupBox5);
            this.tabResultado.Location = new System.Drawing.Point(4, 22);
            this.tabResultado.Name = "tabResultado";
            this.tabResultado.Padding = new System.Windows.Forms.Padding(3);
            this.tabResultado.Size = new System.Drawing.Size(663, 333);
            this.tabResultado.TabIndex = 2;
            this.tabResultado.Text = "RESULTADO";
            this.tabResultado.UseVisualStyleBackColor = true;
            // 
            // btSeleccionar
            // 
            this.btSeleccionar.Location = new System.Drawing.Point(486, 12);
            this.btSeleccionar.Name = "btSeleccionar";
            this.btSeleccionar.Size = new System.Drawing.Size(148, 22);
            this.btSeleccionar.TabIndex = 2;
            this.btSeleccionar.Text = "SELECCIONAR ALUMNOS";
            this.btSeleccionar.UseVisualStyleBackColor = true;
            this.btSeleccionar.Click += new System.EventHandler(this.btSeleccionar_Click);
            // 
            // btSiguiente1
            // 
            this.btSiguiente1.Enabled = false;
            this.btSiguiente1.Location = new System.Drawing.Point(486, 305);
            this.btSiguiente1.Name = "btSiguiente1";
            this.btSiguiente1.Size = new System.Drawing.Size(148, 22);
            this.btSiguiente1.TabIndex = 3;
            this.btSiguiente1.Text = "SIGUIENTE";
            this.btSiguiente1.UseVisualStyleBackColor = true;
            this.btSiguiente1.Click += new System.EventHandler(this.btSiguiente1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.Controls.Add(this.clbAlumnos);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 305);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECIONE LOS ALUMNOS PARA ASIGNAR OPTATIVA";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox2.Controls.Add(this.lbAlumnosAsignar);
            this.groupBox2.Location = new System.Drawing.Point(19, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 128);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ALUMNOS";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox3.Controls.Add(this.btAsignarAlumno);
            this.groupBox3.Controls.Add(this.tbAsignar);
            this.groupBox3.Location = new System.Drawing.Point(19, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 52);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ALUMNO";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cbOptativas2);
            this.groupBox4.Controls.Add(this.cbOptativas1);
            this.groupBox4.Location = new System.Drawing.Point(19, 207);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(384, 104);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ASIGNAR OPTATIVAS ALUMNO";
            // 
            // btAsignarOptativa
            // 
            this.btAsignarOptativa.Location = new System.Drawing.Point(483, 15);
            this.btAsignarOptativa.Name = "btAsignarOptativa";
            this.btAsignarOptativa.Size = new System.Drawing.Size(148, 22);
            this.btAsignarOptativa.TabIndex = 3;
            this.btAsignarOptativa.Text = "ASIGNAR OPTATIVA";
            this.btAsignarOptativa.UseVisualStyleBackColor = true;
            this.btAsignarOptativa.Click += new System.EventHandler(this.btAsignarOptativa_Click);
            // 
            // btSiguiente2
            // 
            this.btSiguiente2.Location = new System.Drawing.Point(483, 289);
            this.btSiguiente2.Name = "btSiguiente2";
            this.btSiguiente2.Size = new System.Drawing.Size(148, 22);
            this.btSiguiente2.TabIndex = 4;
            this.btSiguiente2.Text = "SIGUIENTE";
            this.btSiguiente2.UseVisualStyleBackColor = true;
            this.btSiguiente2.Click += new System.EventHandler(this.btSiguiente2_Click);
            // 
            // lbAlumnosAsignar
            // 
            this.lbAlumnosAsignar.FormattingEnabled = true;
            this.lbAlumnosAsignar.Location = new System.Drawing.Point(6, 19);
            this.lbAlumnosAsignar.Name = "lbAlumnosAsignar";
            this.lbAlumnosAsignar.Size = new System.Drawing.Size(372, 95);
            this.lbAlumnosAsignar.TabIndex = 0;
            this.lbAlumnosAsignar.DoubleClick += new System.EventHandler(this.lbAlumnosAsignar_DoubleClick);
            // 
            // tbAsignar
            // 
            this.tbAsignar.Location = new System.Drawing.Point(19, 19);
            this.tbAsignar.Name = "tbAsignar";
            this.tbAsignar.Size = new System.Drawing.Size(254, 20);
            this.tbAsignar.TabIndex = 0;
            // 
            // btAsignarAlumno
            // 
            this.btAsignarAlumno.Location = new System.Drawing.Point(288, 17);
            this.btAsignarAlumno.Name = "btAsignarAlumno";
            this.btAsignarAlumno.Size = new System.Drawing.Size(90, 22);
            this.btAsignarAlumno.TabIndex = 5;
            this.btAsignarAlumno.Text = "ASIGNAR";
            this.btAsignarAlumno.UseVisualStyleBackColor = true;
            this.btAsignarAlumno.Click += new System.EventHandler(this.btAsignarAlumno_Click);
            // 
            // cbOptativas1
            // 
            this.cbOptativas1.FormattingEnabled = true;
            this.cbOptativas1.Location = new System.Drawing.Point(103, 30);
            this.cbOptativas1.Name = "cbOptativas1";
            this.cbOptativas1.Size = new System.Drawing.Size(269, 21);
            this.cbOptativas1.TabIndex = 0;
            // 
            // cbOptativas2
            // 
            this.cbOptativas2.FormattingEnabled = true;
            this.cbOptativas2.Location = new System.Drawing.Point(103, 57);
            this.cbOptativas2.Name = "cbOptativas2";
            this.cbOptativas2.Size = new System.Drawing.Size(269, 21);
            this.cbOptativas2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "OPTATIVA 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "OPTATIVA 2";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox5.Controls.Add(this.lbInfo);
            this.groupBox5.Location = new System.Drawing.Point(24, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(385, 293);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DATOS INFORMATIVOS";
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.Location = new System.Drawing.Point(6, 19);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(373, 264);
            this.lbInfo.TabIndex = 0;
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(451, 18);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(169, 23);
            this.btFinalizar.TabIndex = 1;
            this.btFinalizar.Text = "FINALIZAR";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // clbAlumnos
            // 
            this.clbAlumnos.FormattingEnabled = true;
            this.clbAlumnos.Location = new System.Drawing.Point(6, 19);
            this.clbAlumnos.Name = "clbAlumnos";
            this.clbAlumnos.Size = new System.Drawing.Size(427, 274);
            this.clbAlumnos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 383);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Matriculación de alumnos";
            this.tabControl.ResumeLayout(false);
            this.tabAlumnos.ResumeLayout(false);
            this.tabAsignar.ResumeLayout(false);
            this.tabResultado.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAlumnos;
        private System.Windows.Forms.Button btSiguiente1;
        private System.Windows.Forms.Button btSeleccionar;
        private System.Windows.Forms.TabPage tabAsignar;
        private System.Windows.Forms.TabPage tabResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSiguiente2;
        private System.Windows.Forms.Button btAsignarOptativa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOptativas2;
        private System.Windows.Forms.ComboBox cbOptativas1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btAsignarAlumno;
        private System.Windows.Forms.TextBox tbAsignar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbAlumnosAsignar;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.CheckedListBox clbAlumnos;
    }
}

