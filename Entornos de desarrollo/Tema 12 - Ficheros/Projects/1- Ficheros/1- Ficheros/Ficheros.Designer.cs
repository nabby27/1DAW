namespace _1__Ficheros
{
    partial class Ficheros
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
            this.btRead = new System.Windows.Forms.Button();
            this.btWrite = new System.Windows.Forms.Button();
            this.tbFileReaded = new System.Windows.Forms.TextBox();
            this.lFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(31, 47);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(135, 23);
            this.btRead.TabIndex = 0;
            this.btRead.Text = "Leer fichero";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btWrite
            // 
            this.btWrite.Location = new System.Drawing.Point(201, 47);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(135, 23);
            this.btWrite.TabIndex = 1;
            this.btWrite.Text = "Escribir fichero";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // tbFileReaded
            // 
            this.tbFileReaded.Location = new System.Drawing.Point(31, 95);
            this.tbFileReaded.Multiline = true;
            this.tbFileReaded.Name = "tbFileReaded";
            this.tbFileReaded.Size = new System.Drawing.Size(135, 161);
            this.tbFileReaded.TabIndex = 2;
            // 
            // lFileName
            // 
            this.lFileName.AutoSize = true;
            this.lFileName.Location = new System.Drawing.Point(28, 22);
            this.lFileName.Name = "lFileName";
            this.lFileName.Size = new System.Drawing.Size(0, 13);
            this.lFileName.TabIndex = 3;
            // 
            // Ficheros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 302);
            this.Controls.Add(this.lFileName);
            this.Controls.Add(this.tbFileReaded);
            this.Controls.Add(this.btWrite);
            this.Controls.Add(this.btRead);
            this.Name = "Ficheros";
            this.Text = "Ficheros de texto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.TextBox tbFileReaded;
        private System.Windows.Forms.Label lFileName;
    }
}

