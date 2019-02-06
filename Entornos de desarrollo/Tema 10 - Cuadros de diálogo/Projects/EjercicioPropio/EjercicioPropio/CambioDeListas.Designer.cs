namespace EjercicioPropio
{
    partial class CambioDeListas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambioDeListas));
            this.lbNums1 = new System.Windows.Forms.ListBox();
            this.btChange = new System.Windows.Forms.Button();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.btAdd1 = new System.Windows.Forms.Button();
            this.btAdd2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbNums2 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNums1
            // 
            this.lbNums1.FormattingEnabled = true;
            this.lbNums1.Location = new System.Drawing.Point(12, 109);
            this.lbNums1.Name = "lbNums1";
            this.lbNums1.Size = new System.Drawing.Size(97, 199);
            this.lbNums1.TabIndex = 1;
            // 
            // btChange
            // 
            this.btChange.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btChange.BackgroundImage")));
            this.btChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btChange.Enabled = false;
            this.btChange.Location = new System.Drawing.Point(114, 140);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(43, 43);
            this.btChange.TabIndex = 2;
            this.btChange.UseVisualStyleBackColor = false;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(12, 45);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(97, 20);
            this.tbNum1.TabIndex = 3;
            this.tbNum1.TextChanged += new System.EventHandler(this.tbNum1_TextChanged);
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(166, 45);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(97, 20);
            this.tbNum2.TabIndex = 4;
            this.tbNum2.TextChanged += new System.EventHandler(this.tbNum2_TextChanged);
            // 
            // btAdd1
            // 
            this.btAdd1.Enabled = false;
            this.btAdd1.Location = new System.Drawing.Point(12, 71);
            this.btAdd1.Name = "btAdd1";
            this.btAdd1.Size = new System.Drawing.Size(97, 23);
            this.btAdd1.TabIndex = 5;
            this.btAdd1.Text = "Add";
            this.btAdd1.UseVisualStyleBackColor = true;
            this.btAdd1.Click += new System.EventHandler(this.btAdd1_Click);
            // 
            // btAdd2
            // 
            this.btAdd2.Enabled = false;
            this.btAdd2.Location = new System.Drawing.Point(166, 71);
            this.btAdd2.Name = "btAdd2";
            this.btAdd2.Size = new System.Drawing.Size(97, 23);
            this.btAdd2.TabIndex = 6;
            this.btAdd2.Text = "Add";
            this.btAdd2.UseVisualStyleBackColor = true;
            this.btAdd2.Click += new System.EventHandler(this.btAdd2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(275, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // lbNums2
            // 
            this.lbNums2.FormattingEnabled = true;
            this.lbNums2.Location = new System.Drawing.Point(163, 109);
            this.lbNums2.Name = "lbNums2";
            this.lbNums2.Size = new System.Drawing.Size(97, 199);
            this.lbNums2.TabIndex = 10;
            // 
            // CambioDeListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 323);
            this.Controls.Add(this.lbNums2);
            this.Controls.Add(this.btAdd2);
            this.Controls.Add(this.btAdd1);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.lbNums1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CambioDeListas";
            this.Text = "Cambio de listas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNums1;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Button btAdd1;
        private System.Windows.Forms.Button btAdd2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ListBox lbNums2;
    }
}

