namespace EjercicioListas2
{
    partial class EjercicioListas2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCheckedListBox = new System.Windows.Forms.RadioButton();
            this.rbComboBox = new System.Windows.Forms.RadioButton();
            this.rbListBox = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCheckedListBox);
            this.groupBox1.Controls.Add(this.rbComboBox);
            this.groupBox1.Controls.Add(this.rbListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbCheckedListBox
            // 
            this.rbCheckedListBox.AutoSize = true;
            this.rbCheckedListBox.Location = new System.Drawing.Point(215, 26);
            this.rbCheckedListBox.Name = "rbCheckedListBox";
            this.rbCheckedListBox.Size = new System.Drawing.Size(102, 17);
            this.rbCheckedListBox.TabIndex = 2;
            this.rbCheckedListBox.TabStop = true;
            this.rbCheckedListBox.Text = "CheckedListBox";
            this.rbCheckedListBox.UseVisualStyleBackColor = true;
            // 
            // rbComboBox
            // 
            this.rbComboBox.AutoSize = true;
            this.rbComboBox.Location = new System.Drawing.Point(107, 26);
            this.rbComboBox.Name = "rbComboBox";
            this.rbComboBox.Size = new System.Drawing.Size(76, 17);
            this.rbComboBox.TabIndex = 1;
            this.rbComboBox.TabStop = true;
            this.rbComboBox.Text = "ComboBox";
            this.rbComboBox.UseVisualStyleBackColor = true;
            // 
            // rbListBox
            // 
            this.rbListBox.AutoSize = true;
            this.rbListBox.Location = new System.Drawing.Point(7, 26);
            this.rbListBox.Name = "rbListBox";
            this.rbListBox.Size = new System.Drawing.Size(59, 17);
            this.rbListBox.TabIndex = 0;
            this.rbListBox.TabStop = true;
            this.rbListBox.Text = "ListBox";
            this.rbListBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elemento:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(414, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(346, 47);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Añadir";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(444, 47);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 4;
            this.btRemove.Text = "Eliminar";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(179, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 6;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(346, 82);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 7;
            // 
            // EjercicioListas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 262);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "EjercicioListas2";
            this.Text = "Trabajando con listas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCheckedListBox;
        private System.Windows.Forms.RadioButton rbComboBox;
        private System.Windows.Forms.RadioButton rbListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

