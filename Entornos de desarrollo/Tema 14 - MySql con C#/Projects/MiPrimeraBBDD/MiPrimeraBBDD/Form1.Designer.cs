namespace MiPrimeraBBDD
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btShowClientes = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.tbIdCliente = new System.Windows.Forms.TextBox();
            this.tbContacto = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.tbCargoContacto = new System.Windows.Forms.TextBox();
            this.btAddCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btRemove = new System.Windows.Forms.Button();
            this.tbIDToDelete = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 186);
            this.listBox1.TabIndex = 0;
            // 
            // btShowClientes
            // 
            this.btShowClientes.Location = new System.Drawing.Point(12, 214);
            this.btShowClientes.Name = "btShowClientes";
            this.btShowClientes.Size = new System.Drawing.Size(200, 23);
            this.btShowClientes.TabIndex = 1;
            this.btShowClientes.Text = "Ver clientes";
            this.btShowClientes.UseVisualStyleBackColor = true;
            this.btShowClientes.Click += new System.EventHandler(this.btShowClientes_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(238, 28);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(238, 79);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono.TabIndex = 3;
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(238, 129);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(100, 20);
            this.tbPais.TabIndex = 4;
            // 
            // tbIdCliente
            // 
            this.tbIdCliente.Location = new System.Drawing.Point(359, 28);
            this.tbIdCliente.Name = "tbIdCliente";
            this.tbIdCliente.Size = new System.Drawing.Size(100, 20);
            this.tbIdCliente.TabIndex = 5;
            // 
            // tbContacto
            // 
            this.tbContacto.Location = new System.Drawing.Point(359, 178);
            this.tbContacto.Name = "tbContacto";
            this.tbContacto.Size = new System.Drawing.Size(100, 20);
            this.tbContacto.TabIndex = 9;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(359, 129);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(100, 20);
            this.tbDireccion.TabIndex = 8;
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(359, 79);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(100, 20);
            this.tbCiudad.TabIndex = 7;
            // 
            // tbCargoContacto
            // 
            this.tbCargoContacto.Location = new System.Drawing.Point(241, 178);
            this.tbCargoContacto.Name = "tbCargoContacto";
            this.tbCargoContacto.Size = new System.Drawing.Size(100, 20);
            this.tbCargoContacto.TabIndex = 6;
            // 
            // btAddCliente
            // 
            this.btAddCliente.Location = new System.Drawing.Point(238, 214);
            this.btAddCliente.Name = "btAddCliente";
            this.btAddCliente.Size = new System.Drawing.Size(221, 23);
            this.btAddCliente.TabIndex = 10;
            this.btAddCliente.Text = "Añadir clientes";
            this.btAddCliente.UseVisualStyleBackColor = true;
            this.btAddCliente.Click += new System.EventHandler(this.btAddCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cargo contacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ciudad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "País";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Id Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Contacto";
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(487, 214);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(127, 23);
            this.btRemove.TabIndex = 19;
            this.btRemove.Text = "Eliminar Cliente";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // tbIDToDelete
            // 
            this.tbIDToDelete.Location = new System.Drawing.Point(487, 121);
            this.tbIDToDelete.Name = "tbIDToDelete";
            this.tbIDToDelete.Size = new System.Drawing.Size(127, 20);
            this.tbIDToDelete.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 262);
            this.Controls.Add(this.tbIDToDelete);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAddCliente);
            this.Controls.Add(this.tbContacto);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbCiudad);
            this.Controls.Add(this.tbCargoContacto);
            this.Controls.Add(this.tbIdCliente);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btShowClientes);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btShowClientes;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.TextBox tbIdCliente;
        private System.Windows.Forms.TextBox tbContacto;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.TextBox tbCargoContacto;
        private System.Windows.Forms.Button btAddCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.TextBox tbIDToDelete;
    }
}

