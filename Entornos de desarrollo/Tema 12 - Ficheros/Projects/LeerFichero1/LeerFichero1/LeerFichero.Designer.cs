namespace LeerFichero1
{
    partial class LeerFichero
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
            this.btToTextbox = new System.Windows.Forms.Button();
            this.btToListbox = new System.Windows.Forms.Button();
            this.btToCheckedListbox = new System.Windows.Forms.Button();
            this.btCheckedTolistbox = new System.Windows.Forms.Button();
            this.btCrearFichero = new System.Windows.Forms.Button();
            this.btToRichtextbox = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBoxItemsChecked = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btToCombobox = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lrutaFichero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btToTextbox
            // 
            this.btToTextbox.Location = new System.Drawing.Point(12, 52);
            this.btToTextbox.Name = "btToTextbox";
            this.btToTextbox.Size = new System.Drawing.Size(137, 23);
            this.btToTextbox.TabIndex = 0;
            this.btToTextbox.Text = "Cargar fichero en Textbox";
            this.btToTextbox.UseVisualStyleBackColor = true;
            this.btToTextbox.Click += new System.EventHandler(this.btToTextbox_Click);
            // 
            // btToListbox
            // 
            this.btToListbox.Location = new System.Drawing.Point(173, 52);
            this.btToListbox.Name = "btToListbox";
            this.btToListbox.Size = new System.Drawing.Size(137, 23);
            this.btToListbox.TabIndex = 1;
            this.btToListbox.Text = "Cargar fichero en Listbox";
            this.btToListbox.UseVisualStyleBackColor = true;
            this.btToListbox.Click += new System.EventHandler(this.btToListbox_Click);
            // 
            // btToCheckedListbox
            // 
            this.btToCheckedListbox.Location = new System.Drawing.Point(379, 52);
            this.btToCheckedListbox.Name = "btToCheckedListbox";
            this.btToCheckedListbox.Size = new System.Drawing.Size(182, 23);
            this.btToCheckedListbox.TabIndex = 2;
            this.btToCheckedListbox.Text = "Cargar fichero en Checked Listbox";
            this.btToCheckedListbox.UseVisualStyleBackColor = true;
            this.btToCheckedListbox.Click += new System.EventHandler(this.btToCheckedListbox_Click);
            // 
            // btCheckedTolistbox
            // 
            this.btCheckedTolistbox.Location = new System.Drawing.Point(579, 52);
            this.btCheckedTolistbox.Name = "btCheckedTolistbox";
            this.btCheckedTolistbox.Size = new System.Drawing.Size(168, 23);
            this.btCheckedTolistbox.TabIndex = 3;
            this.btCheckedTolistbox.Text = "Pasar los Checked a un Listbox";
            this.btCheckedTolistbox.UseVisualStyleBackColor = true;
            this.btCheckedTolistbox.Click += new System.EventHandler(this.btCheckedTolistbox_Click);
            // 
            // btCrearFichero
            // 
            this.btCrearFichero.Location = new System.Drawing.Point(12, 269);
            this.btCrearFichero.Name = "btCrearFichero";
            this.btCrearFichero.Size = new System.Drawing.Size(114, 23);
            this.btCrearFichero.TabIndex = 4;
            this.btCrearFichero.Text = "Crear fichero TXT";
            this.btCrearFichero.UseVisualStyleBackColor = true;
            this.btCrearFichero.Click += new System.EventHandler(this.btCrearFichero_Click);
            // 
            // btToRichtextbox
            // 
            this.btToRichtextbox.Location = new System.Drawing.Point(173, 269);
            this.btToRichtextbox.Name = "btToRichtextbox";
            this.btToRichtextbox.Size = new System.Drawing.Size(203, 23);
            this.btToRichtextbox.TabIndex = 5;
            this.btToRichtextbox.Text = "Mostrar fichero de texto en Richtextbox";
            this.btToRichtextbox.UseVisualStyleBackColor = true;
            this.btToRichtextbox.Click += new System.EventHandler(this.btToRichtextbox_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 97);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 148);
            this.textBox1.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(173, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(137, 147);
            this.listBox1.TabIndex = 7;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(379, 97);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(182, 154);
            this.checkedListBox1.TabIndex = 8;
            // 
            // listBoxItemsChecked
            // 
            this.listBoxItemsChecked.FormattingEnabled = true;
            this.listBoxItemsChecked.Location = new System.Drawing.Point(579, 97);
            this.listBoxItemsChecked.Name = "listBoxItemsChecked";
            this.listBoxItemsChecked.Size = new System.Drawing.Size(168, 147);
            this.listBoxItemsChecked.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(173, 314);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(203, 125);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // btToCombobox
            // 
            this.btToCombobox.Location = new System.Drawing.Point(458, 344);
            this.btToCombobox.Name = "btToCombobox";
            this.btToCombobox.Size = new System.Drawing.Size(126, 23);
            this.btToCombobox.TabIndex = 11;
            this.btToCombobox.Text = "Cargar en Combobox";
            this.btToCombobox.UseVisualStyleBackColor = true;
            this.btToCombobox.Click += new System.EventHandler(this.btToCombobox_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(602, 346);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "La ruta del fichero es:";
            // 
            // lrutaFichero
            // 
            this.lrutaFichero.AutoSize = true;
            this.lrutaFichero.Location = new System.Drawing.Point(163, 13);
            this.lrutaFichero.Name = "lrutaFichero";
            this.lrutaFichero.Size = new System.Drawing.Size(0, 13);
            this.lrutaFichero.TabIndex = 14;
            // 
            // LeerFichero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 467);
            this.Controls.Add(this.lrutaFichero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btToCombobox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBoxItemsChecked);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btToRichtextbox);
            this.Controls.Add(this.btCrearFichero);
            this.Controls.Add(this.btCheckedTolistbox);
            this.Controls.Add(this.btToCheckedListbox);
            this.Controls.Add(this.btToListbox);
            this.Controls.Add(this.btToTextbox);
            this.Name = "LeerFichero";
            this.Text = "Leer Fichero 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btToTextbox;
        private System.Windows.Forms.Button btToListbox;
        private System.Windows.Forms.Button btToCheckedListbox;
        private System.Windows.Forms.Button btCheckedTolistbox;
        private System.Windows.Forms.Button btCrearFichero;
        private System.Windows.Forms.Button btToRichtextbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBoxItemsChecked;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btToCombobox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lrutaFichero;
    }
}

