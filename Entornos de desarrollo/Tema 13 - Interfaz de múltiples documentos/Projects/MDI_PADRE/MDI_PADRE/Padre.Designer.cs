namespace MDI_PADRE
{
    partial class Padre
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHijo1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHijo2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hijo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hijo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.ventanaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(519, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MenuActivate += new System.EventHandler(this.menuStrip1_MenuActivate);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHijo1,
            this.MenuHijo2});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // MenuHijo1
            // 
            this.MenuHijo1.Name = "MenuHijo1";
            this.MenuHijo1.Size = new System.Drawing.Size(152, 22);
            this.MenuHijo1.Text = "Hijo 1";
            this.MenuHijo1.Click += new System.EventHandler(this.hijo1_Click);
            // 
            // MenuHijo2
            // 
            this.MenuHijo2.Name = "MenuHijo2";
            this.MenuHijo2.Size = new System.Drawing.Size(152, 22);
            this.MenuHijo2.Text = "Hijo 2";
            this.MenuHijo2.Click += new System.EventHandler(this.hijo2_Click);
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hijo1ToolStripMenuItem,
            this.hijo2ToolStripMenuItem});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // hijo1ToolStripMenuItem
            // 
            this.hijo1ToolStripMenuItem.Name = "hijo1ToolStripMenuItem";
            this.hijo1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hijo1ToolStripMenuItem.Text = "Hijo 1";
            // 
            // hijo2ToolStripMenuItem
            // 
            this.hijo2ToolStripMenuItem.Name = "hijo2ToolStripMenuItem";
            this.hijo2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hijo2ToolStripMenuItem.Text = "Hijo 2";
            // 
            // Padre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 404);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Padre";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuHijo1;
        private System.Windows.Forms.ToolStripMenuItem MenuHijo2;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hijo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hijo2ToolStripMenuItem;
    }
}

