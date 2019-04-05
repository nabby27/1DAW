namespace Comensales
{
    partial class Comensales
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btTab1Siquiente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTab1 = new System.Windows.Forms.ListBox();
            this.btTab1Seleccionar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btTab2Siguiente = new System.Windows.Forms.Button();
            this.btTab2NuevoComensal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clbTab2 = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btTab3Siguiente = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btTab3AsignarMenu = new System.Windows.Forms.Button();
            this.cbTab3Plato2 = new System.Windows.Forms.ComboBox();
            this.cbTab3Bebida = new System.Windows.Forms.ComboBox();
            this.cbTab3Postre = new System.Windows.Forms.ComboBox();
            this.cbTab3Plato1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btTab3Asignar = new System.Windows.Forms.Button();
            this.tbTab3Comensal = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbTab3 = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btTab4Finalizar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbTab4 = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(434, 451);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btTab1Siquiente);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btTab1Seleccionar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "POSIBLES COMENSALES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btTab1Siquiente
            // 
            this.btTab1Siquiente.Location = new System.Drawing.Point(6, 392);
            this.btTab1Siquiente.Name = "btTab1Siquiente";
            this.btTab1Siquiente.Size = new System.Drawing.Size(414, 27);
            this.btTab1Siquiente.TabIndex = 2;
            this.btTab1Siquiente.Text = "SIGUIENTE";
            this.btTab1Siquiente.UseVisualStyleBackColor = true;
            this.btTab1Siquiente.Click += new System.EventHandler(this.btTab1Siquiente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.lbTab1);
            this.groupBox1.Location = new System.Drawing.Point(6, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 349);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posibles comensales";
            // 
            // lbTab1
            // 
            this.lbTab1.FormattingEnabled = true;
            this.lbTab1.Location = new System.Drawing.Point(6, 19);
            this.lbTab1.Name = "lbTab1";
            this.lbTab1.Size = new System.Drawing.Size(402, 316);
            this.lbTab1.TabIndex = 0;
            // 
            // btTab1Seleccionar
            // 
            this.btTab1Seleccionar.Location = new System.Drawing.Point(6, 6);
            this.btTab1Seleccionar.Name = "btTab1Seleccionar";
            this.btTab1Seleccionar.Size = new System.Drawing.Size(414, 28);
            this.btTab1Seleccionar.TabIndex = 0;
            this.btTab1Seleccionar.Text = "CARGAR PERSONAS DE BBDD";
            this.btTab1Seleccionar.UseVisualStyleBackColor = true;
            this.btTab1Seleccionar.Click += new System.EventHandler(this.btTab1Seleccionar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btTab2Siguiente);
            this.tabPage2.Controls.Add(this.btTab2NuevoComensal);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "COMENSALES";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btTab2Siguiente
            // 
            this.btTab2Siguiente.Location = new System.Drawing.Point(257, 382);
            this.btTab2Siguiente.Name = "btTab2Siguiente";
            this.btTab2Siguiente.Size = new System.Drawing.Size(157, 37);
            this.btTab2Siguiente.TabIndex = 4;
            this.btTab2Siguiente.Text = "SIGUIENTE";
            this.btTab2Siguiente.UseVisualStyleBackColor = true;
            this.btTab2Siguiente.Click += new System.EventHandler(this.btTab2Siguiente_Click);
            // 
            // btTab2NuevoComensal
            // 
            this.btTab2NuevoComensal.Location = new System.Drawing.Point(6, 385);
            this.btTab2NuevoComensal.Name = "btTab2NuevoComensal";
            this.btTab2NuevoComensal.Size = new System.Drawing.Size(157, 37);
            this.btTab2NuevoComensal.TabIndex = 3;
            this.btTab2NuevoComensal.Text = "NUEVO COMENSAL";
            this.btTab2NuevoComensal.UseVisualStyleBackColor = true;
            this.btTab2NuevoComensal.Click += new System.EventHandler(this.btTab2NuevoComensal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.clbTab2);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 373);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SELECCIONE LOS COMENSALES QUE PARTICIPARAN EN LA COMIDA";
            // 
            // clbTab2
            // 
            this.clbTab2.FormattingEnabled = true;
            this.clbTab2.Location = new System.Drawing.Point(6, 19);
            this.clbTab2.Name = "clbTab2";
            this.clbTab2.Size = new System.Drawing.Size(402, 349);
            this.clbTab2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btTab3Siguiente);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(426, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ASIGNACIÓN DE MENU";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btTab3Siguiente
            // 
            this.btTab3Siguiente.Enabled = false;
            this.btTab3Siguiente.Location = new System.Drawing.Point(6, 388);
            this.btTab3Siguiente.Name = "btTab3Siguiente";
            this.btTab3Siguiente.Size = new System.Drawing.Size(414, 31);
            this.btTab3Siguiente.TabIndex = 5;
            this.btTab3Siguiente.Text = "SIGUIENTE";
            this.btTab3Siguiente.UseVisualStyleBackColor = true;
            this.btTab3Siguiente.Click += new System.EventHandler(this.btTab3Siguiente_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.btTab3AsignarMenu);
            this.groupBox5.Controls.Add(this.cbTab3Plato2);
            this.groupBox5.Controls.Add(this.cbTab3Bebida);
            this.groupBox5.Controls.Add(this.cbTab3Postre);
            this.groupBox5.Controls.Add(this.cbTab3Plato1);
            this.groupBox5.Location = new System.Drawing.Point(6, 205);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(414, 174);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ASIGNAR MENU PERSONAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "POSTRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "BEBIDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "PLATO 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PLATO 1";
            // 
            // btTab3AsignarMenu
            // 
            this.btTab3AsignarMenu.Enabled = false;
            this.btTab3AsignarMenu.Location = new System.Drawing.Point(35, 141);
            this.btTab3AsignarMenu.Name = "btTab3AsignarMenu";
            this.btTab3AsignarMenu.Size = new System.Drawing.Size(345, 23);
            this.btTab3AsignarMenu.TabIndex = 4;
            this.btTab3AsignarMenu.Text = "ASIGNAR MENU SELECCIONADO AL COMENSAL";
            this.btTab3AsignarMenu.UseVisualStyleBackColor = true;
            this.btTab3AsignarMenu.Click += new System.EventHandler(this.btTab3AsignarMenu_Click);
            // 
            // cbTab3Plato2
            // 
            this.cbTab3Plato2.Enabled = false;
            this.cbTab3Plato2.FormattingEnabled = true;
            this.cbTab3Plato2.Location = new System.Drawing.Point(73, 46);
            this.cbTab3Plato2.Name = "cbTab3Plato2";
            this.cbTab3Plato2.Size = new System.Drawing.Size(325, 21);
            this.cbTab3Plato2.TabIndex = 3;
            // 
            // cbTab3Bebida
            // 
            this.cbTab3Bebida.Enabled = false;
            this.cbTab3Bebida.FormattingEnabled = true;
            this.cbTab3Bebida.Location = new System.Drawing.Point(73, 73);
            this.cbTab3Bebida.Name = "cbTab3Bebida";
            this.cbTab3Bebida.Size = new System.Drawing.Size(325, 21);
            this.cbTab3Bebida.TabIndex = 2;
            // 
            // cbTab3Postre
            // 
            this.cbTab3Postre.Enabled = false;
            this.cbTab3Postre.FormattingEnabled = true;
            this.cbTab3Postre.Location = new System.Drawing.Point(73, 100);
            this.cbTab3Postre.Name = "cbTab3Postre";
            this.cbTab3Postre.Size = new System.Drawing.Size(325, 21);
            this.cbTab3Postre.TabIndex = 1;
            // 
            // cbTab3Plato1
            // 
            this.cbTab3Plato1.Enabled = false;
            this.cbTab3Plato1.FormattingEnabled = true;
            this.cbTab3Plato1.Location = new System.Drawing.Point(73, 19);
            this.cbTab3Plato1.Name = "cbTab3Plato1";
            this.cbTab3Plato1.Size = new System.Drawing.Size(325, 21);
            this.cbTab3Plato1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox4.Controls.Add(this.btTab3Asignar);
            this.groupBox4.Controls.Add(this.tbTab3Comensal);
            this.groupBox4.Location = new System.Drawing.Point(6, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(414, 52);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "COMENSAL";
            // 
            // btTab3Asignar
            // 
            this.btTab3Asignar.Location = new System.Drawing.Point(333, 19);
            this.btTab3Asignar.Name = "btTab3Asignar";
            this.btTab3Asignar.Size = new System.Drawing.Size(75, 20);
            this.btTab3Asignar.TabIndex = 5;
            this.btTab3Asignar.Text = "ASIGNAR";
            this.btTab3Asignar.UseVisualStyleBackColor = true;
            this.btTab3Asignar.Click += new System.EventHandler(this.btTab3Asignar_Click);
            // 
            // tbTab3Comensal
            // 
            this.tbTab3Comensal.Location = new System.Drawing.Point(6, 19);
            this.tbTab3Comensal.Name = "tbTab3Comensal";
            this.tbTab3Comensal.Size = new System.Drawing.Size(321, 20);
            this.tbTab3Comensal.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox3.Controls.Add(this.lbTab3);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 135);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "COMENSALES";
            // 
            // lbTab3
            // 
            this.lbTab3.FormattingEnabled = true;
            this.lbTab3.Location = new System.Drawing.Point(6, 19);
            this.lbTab3.Name = "lbTab3";
            this.lbTab3.Size = new System.Drawing.Size(402, 108);
            this.lbTab3.TabIndex = 0;
            this.lbTab3.DoubleClick += new System.EventHandler(this.lbTab3_DoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btTab4Finalizar);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(426, 425);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "COMIDA";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btTab4Finalizar
            // 
            this.btTab4Finalizar.Enabled = false;
            this.btTab4Finalizar.Location = new System.Drawing.Point(6, 388);
            this.btTab4Finalizar.Name = "btTab4Finalizar";
            this.btTab4Finalizar.Size = new System.Drawing.Size(414, 31);
            this.btTab4Finalizar.TabIndex = 6;
            this.btTab4Finalizar.Text = "FINALIZAR";
            this.btTab4Finalizar.UseVisualStyleBackColor = true;
            this.btTab4Finalizar.Click += new System.EventHandler(this.btTab4Finalizar_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox6.Controls.Add(this.lbTab4);
            this.groupBox6.Location = new System.Drawing.Point(14, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(399, 369);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "COMENSALES";
            // 
            // lbTab4
            // 
            this.lbTab4.FormattingEnabled = true;
            this.lbTab4.Location = new System.Drawing.Point(6, 19);
            this.lbTab4.Name = "lbTab4";
            this.lbTab4.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbTab4.Size = new System.Drawing.Size(387, 342);
            this.lbTab4.TabIndex = 0;
            // 
            // Comensales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 475);
            this.Controls.Add(this.tabControl);
            this.Name = "Comensales";
            this.Text = "DDBB Comensales";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btTab1Siquiente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbTab1;
        private System.Windows.Forms.Button btTab1Seleccionar;
        private System.Windows.Forms.Button btTab2Siguiente;
        private System.Windows.Forms.Button btTab2NuevoComensal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTab3AsignarMenu;
        private System.Windows.Forms.ComboBox cbTab3Plato2;
        private System.Windows.Forms.ComboBox cbTab3Bebida;
        private System.Windows.Forms.ComboBox cbTab3Postre;
        private System.Windows.Forms.ComboBox cbTab3Plato1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btTab3Asignar;
        private System.Windows.Forms.TextBox tbTab3Comensal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbTab3;
        private System.Windows.Forms.Button btTab3Siguiente;
        private System.Windows.Forms.Button btTab4Finalizar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lbTab4;
        private System.Windows.Forms.CheckedListBox clbTab2;
    }
}

