namespace Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Articulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elaboradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edicion = new System.Windows.Forms.ToolStripMenuItem();
            this.Edicion1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Edicion2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.Ayuda1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Ayuda2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.TextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.Cortar = new System.Windows.Forms.ToolStripButton();
            this.Pegar = new System.Windows.Forms.ToolStripButton();
            this.Copiar = new System.Windows.Forms.ToolStripButton();
            this.FootBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lTeclado = new System.Windows.Forms.ToolStripStatusLabel();
            this.button = new System.Windows.Forms.Button();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Reproducir = new System.Windows.Forms.ToolStripMenuItem();
            this.Parar = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Menu.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.FootBar.SuspendLayout();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Articulos,
            this.Edicion,
            this.Ayuda,
            this.ComboBox,
            this.TextBox});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(498, 27);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // Articulos
            // 
            this.Articulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeArticulosToolStripMenuItem,
            this.articulosToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.Articulos.Name = "Articulos";
            this.Articulos.Size = new System.Drawing.Size(66, 23);
            this.Articulos.Text = "Articulos";
            // 
            // tipoDeArticulosToolStripMenuItem
            // 
            this.tipoDeArticulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elaboradosToolStripMenuItem,
            this.producciónToolStripMenuItem});
            this.tipoDeArticulosToolStripMenuItem.Name = "tipoDeArticulosToolStripMenuItem";
            this.tipoDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.tipoDeArticulosToolStripMenuItem.Text = "Tipo de articulos";
            // 
            // elaboradosToolStripMenuItem
            // 
            this.elaboradosToolStripMenuItem.Name = "elaboradosToolStripMenuItem";
            this.elaboradosToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.elaboradosToolStripMenuItem.Text = "Elaborados";
            // 
            // producciónToolStripMenuItem
            // 
            this.producciónToolStripMenuItem.Name = "producciónToolStripMenuItem";
            this.producciónToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.producciónToolStripMenuItem.Text = "Producción";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // Edicion
            // 
            this.Edicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edicion1,
            this.Edicion2});
            this.Edicion.Name = "Edicion";
            this.Edicion.Size = new System.Drawing.Size(58, 23);
            this.Edicion.Text = "Edición";
            // 
            // Edicion1
            // 
            this.Edicion1.Name = "Edicion1";
            this.Edicion1.Size = new System.Drawing.Size(122, 22);
            this.Edicion1.Text = "Edición 1";
            // 
            // Edicion2
            // 
            this.Edicion2.Name = "Edicion2";
            this.Edicion2.Size = new System.Drawing.Size(122, 22);
            this.Edicion2.Text = "Edición 2";
            // 
            // Ayuda
            // 
            this.Ayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ayuda1,
            this.Ayuda2});
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(53, 23);
            this.Ayuda.Text = "Ayuda";
            // 
            // Ayuda1
            // 
            this.Ayuda1.Name = "Ayuda1";
            this.Ayuda1.Size = new System.Drawing.Size(117, 22);
            this.Ayuda1.Text = "Ayuda 1";
            // 
            // Ayuda2
            // 
            this.Ayuda2.Name = "Ayuda2";
            this.Ayuda2.Size = new System.Drawing.Size(117, 22);
            this.Ayuda2.Text = "Ayuda 2";
            // 
            // ComboBox
            // 
            this.ComboBox.Items.AddRange(new object[] {
            "Elemento 1",
            "Elemento 2"});
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // TextBox
            // 
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cortar,
            this.Pegar,
            this.Copiar});
            this.ToolBar.Location = new System.Drawing.Point(0, 27);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(498, 25);
            this.ToolBar.TabIndex = 1;
            this.ToolBar.Text = "ToolBar";
            // 
            // Cortar
            // 
            this.Cortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cortar.Image = ((System.Drawing.Image)(resources.GetObject("Cortar.Image")));
            this.Cortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cortar.Name = "Cortar";
            this.Cortar.Size = new System.Drawing.Size(23, 22);
            this.Cortar.Text = "Cortar";
            // 
            // Pegar
            // 
            this.Pegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pegar.Image = ((System.Drawing.Image)(resources.GetObject("Pegar.Image")));
            this.Pegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pegar.Name = "Pegar";
            this.Pegar.Size = new System.Drawing.Size(23, 22);
            this.Pegar.Text = "Pegar";
            // 
            // Copiar
            // 
            this.Copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Copiar.Image = ((System.Drawing.Image)(resources.GetObject("Copiar.Image")));
            this.Copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Copiar.Name = "Copiar";
            this.Copiar.Size = new System.Drawing.Size(23, 22);
            this.Copiar.Text = "Copiar";
            // 
            // FootBar
            // 
            this.FootBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lDate,
            this.lTeclado});
            this.FootBar.Location = new System.Drawing.Point(0, 240);
            this.FootBar.Name = "FootBar";
            this.FootBar.Size = new System.Drawing.Size(498, 22);
            this.FootBar.TabIndex = 2;
            this.FootBar.Text = "FootBar";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(94, 17);
            this.toolStripStatusLabel1.Text = "Hola Bienvenido";
            // 
            // lDate
            // 
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(0, 17);
            // 
            // lTeclado
            // 
            this.lTeclado.Name = "lTeclado";
            this.lTeclado.Size = new System.Drawing.Size(128, 17);
            this.lTeclado.Text = "Teclado en minusculas";
            // 
            // button
            // 
            this.button.ContextMenuStrip = this.ContextMenu;
            this.button.Location = new System.Drawing.Point(12, 91);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(220, 23);
            this.button.TabIndex = 3;
            this.button.Text = "Ejemplo de pinchar botón derecho";
            this.button.UseVisualStyleBackColor = true;
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reproducir,
            this.Parar});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(133, 48);
            // 
            // Reproducir
            // 
            this.Reproducir.Name = "Reproducir";
            this.Reproducir.Size = new System.Drawing.Size(132, 22);
            this.Reproducir.Text = "Reproducir";
            // 
            // Parar
            // 
            this.Parar.Name = "Parar";
            this.Parar.Size = new System.Drawing.Size(132, 22);
            this.Parar.Text = "Parar";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 262);
            this.Controls.Add(this.button);
            this.Controls.Add(this.FootBar);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.Text = "Menu";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.FootBar.ResumeLayout(false);
            this.FootBar.PerformLayout();
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Articulos;
        private System.Windows.Forms.ToolStripMenuItem Edicion;
        private System.Windows.Forms.ToolStripMenuItem tipoDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elaboradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edicion1;
        private System.Windows.Forms.ToolStripMenuItem Edicion2;
        private System.Windows.Forms.ToolStripMenuItem Ayuda;
        private System.Windows.Forms.ToolStripMenuItem Ayuda1;
        private System.Windows.Forms.ToolStripMenuItem Ayuda2;
        private System.Windows.Forms.ToolStripComboBox ComboBox;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton Cortar;
        private System.Windows.Forms.ToolStripButton Pegar;
        private System.Windows.Forms.ToolStripButton Copiar;
        private System.Windows.Forms.ToolStripTextBox TextBox;
        private System.Windows.Forms.StatusStrip FootBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem Reproducir;
        private System.Windows.Forms.ToolStripMenuItem Parar;
        private System.Windows.Forms.ToolStripStatusLabel lDate;
        private System.Windows.Forms.ToolStripStatusLabel lTeclado;
        private System.Windows.Forms.Timer timer1;
    }
}

