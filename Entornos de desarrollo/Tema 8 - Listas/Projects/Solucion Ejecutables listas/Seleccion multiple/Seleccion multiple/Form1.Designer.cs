namespace Seleccion_multiple
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
            this.lbItems = new System.Windows.Forms.ListBox();
            this.tbItemsSelected = new System.Windows.Forms.TextBox();
            this.bRemove = new System.Windows.Forms.Button();
            this.bItemsSelected = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lSeleccionado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(12, 12);
            this.lbItems.Name = "lbItems";
            this.lbItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbItems.Size = new System.Drawing.Size(120, 121);
            this.lbItems.TabIndex = 0;
            this.lbItems.Click += new System.EventHandler(this.changeItemsSelected);
            // 
            // tbItemsSelected
            // 
            this.tbItemsSelected.Location = new System.Drawing.Point(12, 209);
            this.tbItemsSelected.Multiline = true;
            this.tbItemsSelected.Name = "tbItemsSelected";
            this.tbItemsSelected.Size = new System.Drawing.Size(120, 117);
            this.tbItemsSelected.TabIndex = 1;
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(138, 12);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(156, 36);
            this.bRemove.TabIndex = 2;
            this.bRemove.Text = "Borrar primer elemento";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.remove);
            // 
            // bItemsSelected
            // 
            this.bItemsSelected.Location = new System.Drawing.Point(138, 209);
            this.bItemsSelected.Name = "bItemsSelected";
            this.bItemsSelected.Size = new System.Drawing.Size(156, 36);
            this.bItemsSelected.TabIndex = 3;
            this.bItemsSelected.Text = "Items seleccionados";
            this.bItemsSelected.UseVisualStyleBackColor = true;
            this.bItemsSelected.Click += new System.EventHandler(this.showSelectedItems);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Se ha seleccionado";
            // 
            // lSeleccionado
            // 
            this.lSeleccionado.AutoSize = true;
            this.lSeleccionado.Location = new System.Drawing.Point(138, 140);
            this.lSeleccionado.Name = "lSeleccionado";
            this.lSeleccionado.Size = new System.Drawing.Size(0, 13);
            this.lSeleccionado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selección múltiple";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lSeleccionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bItemsSelected);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.tbItemsSelected);
            this.Controls.Add(this.lbItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.TextBox tbItemsSelected;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Button bItemsSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lSeleccionado;
        private System.Windows.Forms.Label label2;
    }
}

