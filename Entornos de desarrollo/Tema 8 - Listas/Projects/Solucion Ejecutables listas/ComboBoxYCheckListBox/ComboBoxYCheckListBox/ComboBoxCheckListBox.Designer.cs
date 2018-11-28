namespace ComboBoxYCheckListBox
{
    partial class ComboBoxCheckListBox
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
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.btRemoveFirstElement = new System.Windows.Forms.Button();
            this.btRemoveSelectedItem = new System.Windows.Forms.Button();
            this.btSelectedElement = new System.Windows.Forms.Button();
            this.clbItems = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lIndexItem = new System.Windows.Forms.Label();
            this.lbItemsSelected = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbItems
            // 
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(12, 12);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(121, 21);
            this.cmbItems.TabIndex = 0;
            this.cmbItems.SelectedIndexChanged += new System.EventHandler(this.cmbItems_SelectedIndexChanged);
            // 
            // btRemoveFirstElement
            // 
            this.btRemoveFirstElement.Location = new System.Drawing.Point(178, 12);
            this.btRemoveFirstElement.Name = "btRemoveFirstElement";
            this.btRemoveFirstElement.Size = new System.Drawing.Size(116, 39);
            this.btRemoveFirstElement.TabIndex = 3;
            this.btRemoveFirstElement.Text = "Borrar el primer elemento";
            this.btRemoveFirstElement.UseVisualStyleBackColor = true;
            this.btRemoveFirstElement.Click += new System.EventHandler(this.btRemoveFirstElement_Click);
            // 
            // btRemoveSelectedItem
            // 
            this.btRemoveSelectedItem.Location = new System.Drawing.Point(178, 57);
            this.btRemoveSelectedItem.Name = "btRemoveSelectedItem";
            this.btRemoveSelectedItem.Size = new System.Drawing.Size(116, 39);
            this.btRemoveSelectedItem.TabIndex = 4;
            this.btRemoveSelectedItem.Text = "Borrar el elemento seleccionado";
            this.btRemoveSelectedItem.UseVisualStyleBackColor = true;
            this.btRemoveSelectedItem.Click += new System.EventHandler(this.btRemoveSelectedItem_Click);
            // 
            // btSelectedElement
            // 
            this.btSelectedElement.Location = new System.Drawing.Point(178, 102);
            this.btSelectedElement.Name = "btSelectedElement";
            this.btSelectedElement.Size = new System.Drawing.Size(116, 39);
            this.btSelectedElement.TabIndex = 5;
            this.btSelectedElement.Text = "Elemento seleccionados";
            this.btSelectedElement.UseVisualStyleBackColor = true;
            this.btSelectedElement.Click += new System.EventHandler(this.btSelectedElement_Click);
            // 
            // clbItems
            // 
            this.clbItems.FormattingEnabled = true;
            this.clbItems.Location = new System.Drawing.Point(12, 154);
            this.clbItems.Name = "clbItems";
            this.clbItems.Size = new System.Drawing.Size(120, 139);
            this.clbItems.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccionado:";
            // 
            // lIndexItem
            // 
            this.lIndexItem.AutoSize = true;
            this.lIndexItem.Location = new System.Drawing.Point(94, 47);
            this.lIndexItem.Name = "lIndexItem";
            this.lIndexItem.Size = new System.Drawing.Size(0, 13);
            this.lIndexItem.TabIndex = 8;
            // 
            // lbItemsSelected
            // 
            this.lbItemsSelected.FormattingEnabled = true;
            this.lbItemsSelected.Location = new System.Drawing.Point(174, 159);
            this.lbItemsSelected.Name = "lbItemsSelected";
            this.lbItemsSelected.Size = new System.Drawing.Size(120, 134);
            this.lbItemsSelected.TabIndex = 9;
            // 
            // ComboBoxCheckListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 305);
            this.Controls.Add(this.lbItemsSelected);
            this.Controls.Add(this.lIndexItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbItems);
            this.Controls.Add(this.btSelectedElement);
            this.Controls.Add(this.btRemoveSelectedItem);
            this.Controls.Add(this.btRemoveFirstElement);
            this.Controls.Add(this.cmbItems);
            this.Name = "ComboBoxCheckListBox";
            this.Text = "ComboBox y CheckListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.Button btRemoveFirstElement;
        private System.Windows.Forms.Button btRemoveSelectedItem;
        private System.Windows.Forms.Button btSelectedElement;
        private System.Windows.Forms.CheckedListBox clbItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lIndexItem;
        private System.Windows.Forms.ListBox lbItemsSelected;
    }
}

