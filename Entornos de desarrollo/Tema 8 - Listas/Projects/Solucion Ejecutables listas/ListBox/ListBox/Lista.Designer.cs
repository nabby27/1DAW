namespace ListBox
{
    partial class Lista
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
            this.lbItems = new System.Windows.Forms.ListBox();
            this.bRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lElements = new System.Windows.Forms.Label();
            this.lNumItems = new System.Windows.Forms.Label();
            this.lIndexItems = new System.Windows.Forms.Label();
            this.bReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(12, 12);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(140, 108);
            this.lbItems.TabIndex = 0;
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(158, 12);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(143, 30);
            this.bRemove.TabIndex = 1;
            this.bRemove.Text = "Borrar el primer elemento";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elemento seleccionado: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de items: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Indice del Item seleccionado: ";
            // 
            // lElements
            // 
            this.lElements.AutoSize = true;
            this.lElements.Location = new System.Drawing.Point(196, 141);
            this.lElements.Name = "lElements";
            this.lElements.Size = new System.Drawing.Size(0, 13);
            this.lElements.TabIndex = 5;
            // 
            // lNumItems
            // 
            this.lNumItems.AutoSize = true;
            this.lNumItems.Location = new System.Drawing.Point(196, 168);
            this.lNumItems.Name = "lNumItems";
            this.lNumItems.Size = new System.Drawing.Size(0, 13);
            this.lNumItems.TabIndex = 6;
            // 
            // lIndexItems
            // 
            this.lIndexItems.AutoSize = true;
            this.lIndexItems.Location = new System.Drawing.Point(196, 191);
            this.lIndexItems.Name = "lIndexItems";
            this.lIndexItems.Size = new System.Drawing.Size(0, 13);
            this.lIndexItems.TabIndex = 7;
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(158, 90);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(143, 30);
            this.bReset.TabIndex = 8;
            this.bReset.Text = "Reiniciar";
            this.bReset.UseVisualStyleBackColor = true;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 231);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.lIndexItems);
            this.Controls.Add(this.lNumItems);
            this.Controls.Add(this.lElements);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.lbItems);
            this.Name = "Lista";
            this.Text = "Lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lElements;
        private System.Windows.Forms.Label lNumItems;
        private System.Windows.Forms.Label lIndexItems;
        private System.Windows.Forms.Button bReset;
    }
}

