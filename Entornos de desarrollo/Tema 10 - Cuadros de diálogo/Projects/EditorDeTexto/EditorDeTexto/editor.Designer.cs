namespace EditorDeTexto
{
    partial class editor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editor));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msMenuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenusArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuEdicionDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.msMenuEdicionCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuEdicionCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuEdicionPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuOpcionesFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuOpcionesFuente1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuOpcionesFuente2 = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuOpcionesFuente3 = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuOpcionesTamano = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuOpcionesTamano1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuOpcionesTamano2 = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuOpcionesTamano3 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.ssStatusStrip = new System.Windows.Forms.StatusStrip();
            this.fecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCortar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCopiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPegar = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msMenu.SuspendLayout();
            this.ssStatusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuArchivo,
            this.msMenuEdicion,
            this.msMenuOpciones});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(384, 24);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // msMenuArchivo
            // 
            this.msMenuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenusArchivoSalir});
            this.msMenuArchivo.Name = "msMenuArchivo";
            this.msMenuArchivo.Size = new System.Drawing.Size(60, 20);
            this.msMenuArchivo.Text = "Archivo";
            // 
            // msMenusArchivoSalir
            // 
            this.msMenusArchivoSalir.Name = "msMenusArchivoSalir";
            this.msMenusArchivoSalir.Size = new System.Drawing.Size(96, 22);
            this.msMenusArchivoSalir.Text = "Salir";
            // 
            // msMenuEdicion
            // 
            this.msMenuEdicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuEdicionDeshacer,
            this.toolStripSeparator3,
            this.msMenuEdicionCortar,
            this.msMenuEdicionCopiar,
            this.msMenuEdicionPegar});
            this.msMenuEdicion.Name = "msMenuEdicion";
            this.msMenuEdicion.Size = new System.Drawing.Size(58, 20);
            this.msMenuEdicion.Text = "Edición";
            // 
            // msMenuEdicionDeshacer
            // 
            this.msMenuEdicionDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("msMenuEdicionDeshacer.Image")));
            this.msMenuEdicionDeshacer.Name = "msMenuEdicionDeshacer";
            this.msMenuEdicionDeshacer.Size = new System.Drawing.Size(147, 22);
            this.msMenuEdicionDeshacer.Text = "Deshacer";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(144, 6);
            // 
            // msMenuEdicionCortar
            // 
            this.msMenuEdicionCortar.Image = ((System.Drawing.Image)(resources.GetObject("msMenuEdicionCortar.Image")));
            this.msMenuEdicionCortar.Name = "msMenuEdicionCortar";
            this.msMenuEdicionCortar.Size = new System.Drawing.Size(147, 22);
            this.msMenuEdicionCortar.Text = "Cortar Ctrl+X";
            // 
            // msMenuEdicionCopiar
            // 
            this.msMenuEdicionCopiar.Image = ((System.Drawing.Image)(resources.GetObject("msMenuEdicionCopiar.Image")));
            this.msMenuEdicionCopiar.Name = "msMenuEdicionCopiar";
            this.msMenuEdicionCopiar.Size = new System.Drawing.Size(147, 22);
            this.msMenuEdicionCopiar.Text = "Copiar Ctrl+C";
            // 
            // msMenuEdicionPegar
            // 
            this.msMenuEdicionPegar.Image = ((System.Drawing.Image)(resources.GetObject("msMenuEdicionPegar.Image")));
            this.msMenuEdicionPegar.Name = "msMenuEdicionPegar";
            this.msMenuEdicionPegar.Size = new System.Drawing.Size(147, 22);
            this.msMenuEdicionPegar.Text = "Pegar Ctrl+V";
            // 
            // msMenuOpciones
            // 
            this.msMenuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuOpcionesFuente,
            this.msMenuOpcionesTamano});
            this.msMenuOpciones.Name = "msMenuOpciones";
            this.msMenuOpciones.Size = new System.Drawing.Size(69, 20);
            this.msMenuOpciones.Text = "Opciones";
            // 
            // msMenuOpcionesFuente
            // 
            this.msMenuOpcionesFuente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuOpcionesFuente1,
            this.msMenuOpcionesFuente2,
            this.msMenuOpcionesFuente3});
            this.msMenuOpcionesFuente.Name = "msMenuOpcionesFuente";
            this.msMenuOpcionesFuente.Size = new System.Drawing.Size(118, 22);
            this.msMenuOpcionesFuente.Text = "Fuente";
            // 
            // msMenuOpcionesFuente1
            // 
            this.msMenuOpcionesFuente1.Name = "msMenuOpcionesFuente1";
            this.msMenuOpcionesFuente1.Size = new System.Drawing.Size(158, 22);
            this.msMenuOpcionesFuente1.Text = "Courier New";
            // 
            // msMenuOpcionesFuente2
            // 
            this.msMenuOpcionesFuente2.Name = "msMenuOpcionesFuente2";
            this.msMenuOpcionesFuente2.Size = new System.Drawing.Size(158, 22);
            this.msMenuOpcionesFuente2.Text = "Arial";
            // 
            // msMenuOpcionesFuente3
            // 
            this.msMenuOpcionesFuente3.Name = "msMenuOpcionesFuente3";
            this.msMenuOpcionesFuente3.Size = new System.Drawing.Size(158, 22);
            this.msMenuOpcionesFuente3.Text = "Predeterminada";
            // 
            // msMenuOpcionesTamano
            // 
            this.msMenuOpcionesTamano.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenuOpcionesTamano1,
            this.msMenuOpcionesTamano2,
            this.msMenuOpcionesTamano3});
            this.msMenuOpcionesTamano.Name = "msMenuOpcionesTamano";
            this.msMenuOpcionesTamano.Size = new System.Drawing.Size(118, 22);
            this.msMenuOpcionesTamano.Text = "Tamaño";
            // 
            // msMenuOpcionesTamano1
            // 
            this.msMenuOpcionesTamano1.Name = "msMenuOpcionesTamano1";
            this.msMenuOpcionesTamano1.Size = new System.Drawing.Size(159, 22);
            this.msMenuOpcionesTamano1.Text = "16";
            // 
            // msMenuOpcionesTamano2
            // 
            this.msMenuOpcionesTamano2.Name = "msMenuOpcionesTamano2";
            this.msMenuOpcionesTamano2.Size = new System.Drawing.Size(159, 22);
            this.msMenuOpcionesTamano2.Text = "24";
            // 
            // msMenuOpcionesTamano3
            // 
            this.msMenuOpcionesTamano3.Name = "msMenuOpcionesTamano3";
            this.msMenuOpcionesTamano3.Size = new System.Drawing.Size(159, 22);
            this.msMenuOpcionesTamano3.Text = "Predeterminado";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(0, 52);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(384, 185);
            this.textBox.TabIndex = 2;
            // 
            // ssStatusStrip
            // 
            this.ssStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecha});
            this.ssStatusStrip.Location = new System.Drawing.Point(0, 240);
            this.ssStatusStrip.Name = "ssStatusStrip";
            this.ssStatusStrip.Size = new System.Drawing.Size(384, 22);
            this.ssStatusStrip.TabIndex = 3;
            this.ssStatusStrip.Text = "statusStrip1";
            // 
            // fecha
            // 
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCortar,
            this.toolStripSeparator1,
            this.toolStripButtonCopiar,
            this.toolStripSeparator2,
            this.toolStripButtonPegar});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(384, 25);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonCortar
            // 
            this.toolStripButtonCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCortar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCortar.Image")));
            this.toolStripButtonCortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCortar.Name = "toolStripButtonCortar";
            this.toolStripButtonCortar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCortar.Text = "Cortar";
            this.toolStripButtonCortar.Click += new System.EventHandler(this.cortar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonCopiar
            // 
            this.toolStripButtonCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCopiar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopiar.Image")));
            this.toolStripButtonCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopiar.Name = "toolStripButtonCopiar";
            this.toolStripButtonCopiar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCopiar.Text = "Copiar";
            this.toolStripButtonCopiar.Click += new System.EventHandler(this.copiar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonPegar
            // 
            this.toolStripButtonPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPegar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPegar.Image")));
            this.toolStripButtonPegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPegar.Name = "toolStripButtonPegar";
            this.toolStripButtonPegar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPegar.Text = "Pegar";
            this.toolStripButtonPegar.Click += new System.EventHandler(this.pegar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.ssStatusStrip);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "editor";
            this.Text = "Editor";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ssStatusStrip.ResumeLayout(false);
            this.ssStatusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msMenuArchivo;
        private System.Windows.Forms.ToolStripMenuItem msMenuEdicion;
        private System.Windows.Forms.ToolStripMenuItem msMenuOpciones;
        private System.Windows.Forms.ToolStripMenuItem msMenusArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem msMenuEdicionDeshacer;
        private System.Windows.Forms.ToolStripMenuItem msMenuEdicionCortar;
        private System.Windows.Forms.ToolStripMenuItem msMenuEdicionCopiar;
        private System.Windows.Forms.ToolStripMenuItem msMenuEdicionPegar;
        private System.Windows.Forms.ToolStripMenuItem msMenuOpcionesFuente;
        private System.Windows.Forms.ToolStripMenuItem msMenuOpcionesFuente1;
        private System.Windows.Forms.ToolStripMenuItem msMenuOpcionesFuente2;
        private System.Windows.Forms.ToolStripMenuItem msMenuOpcionesFuente3;
        private System.Windows.Forms.ToolStripMenuItem msMenuOpcionesTamano;
        private System.Windows.Forms.ToolStripMenuItem msMenuOpcionesTamano1;
        private System.Windows.Forms.ToolStripMenuItem msMenuOpcionesTamano2;
        private System.Windows.Forms.ToolStripMenuItem msMenuOpcionesTamano3;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.StatusStrip ssStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel fecha;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonCortar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonPegar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

