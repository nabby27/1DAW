namespace CuadroDialogo
{
    partial class cuadroDialogo
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
            this.btImage = new System.Windows.Forms.Button();
            this.btFuente = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.tbFont = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btImage
            // 
            this.btImage.Location = new System.Drawing.Point(29, 27);
            this.btImage.Name = "btImage";
            this.btImage.Size = new System.Drawing.Size(121, 23);
            this.btImage.TabIndex = 0;
            this.btImage.Text = "Cargar imagen";
            this.btImage.UseVisualStyleBackColor = true;
            this.btImage.Click += new System.EventHandler(this.btImage_Click);
            // 
            // btFuente
            // 
            this.btFuente.Location = new System.Drawing.Point(29, 73);
            this.btFuente.Name = "btFuente";
            this.btFuente.Size = new System.Drawing.Size(121, 23);
            this.btFuente.TabIndex = 1;
            this.btFuente.Text = "Cambiar Fuente";
            this.btFuente.UseVisualStyleBackColor = true;
            this.btFuente.Click += new System.EventHandler(this.btFuente_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(166, 29);
            this.tbFile.Name = "tbFile";
            this.tbFile.ReadOnly = true;
            this.tbFile.Size = new System.Drawing.Size(244, 20);
            this.tbFile.TabIndex = 2;
            // 
            // tbFont
            // 
            this.tbFont.Location = new System.Drawing.Point(166, 75);
            this.tbFont.Name = "tbFont";
            this.tbFont.Size = new System.Drawing.Size(244, 20);
            this.tbFont.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(95, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // cuadroDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 292);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbFont);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.btFuente);
            this.Controls.Add(this.btImage);
            this.Name = "cuadroDialogo";
            this.Text = "Cuadro de dialogos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btImage;
        private System.Windows.Forms.Button btFuente;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.TextBox tbFont;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

