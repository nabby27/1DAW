namespace PracticaExamen2
{
    partial class PracticaExamen2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracticaExamen2));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripsLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btBack = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerPictureNext = new System.Windows.Forms.Timer(this.components);
            this.timerPictureBack = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripsLabelDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(291, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripsLabelDate
            // 
            this.statusStripsLabelDate.Name = "statusStripsLabelDate";
            this.statusStripsLabelDate.Size = new System.Drawing.Size(118, 17);
            this.statusStripsLabelDate.Text = "toolStripStatusLabel1";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(80, 52);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(131, 108);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(80, 245);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(131, 129);
            this.listBox.TabIndex = 2;
            // 
            // timerDate
            // 
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuEdicion,
            this.menuHerramientas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(291, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivoSalir});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "Archivo";
            // 
            // menuArchivoSalir
            // 
            this.menuArchivoSalir.Name = "menuArchivoSalir";
            this.menuArchivoSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuArchivoSalir.Size = new System.Drawing.Size(152, 22);
            this.menuArchivoSalir.Text = "Salir";
            this.menuArchivoSalir.Click += new System.EventHandler(this.menuArchivoSalir_Click);
            // 
            // menuEdicion
            // 
            this.menuEdicion.Name = "menuEdicion";
            this.menuEdicion.Size = new System.Drawing.Size(58, 20);
            this.menuEdicion.Text = "Edición";
            // 
            // menuHerramientas
            // 
            this.menuHerramientas.Name = "menuHerramientas";
            this.menuHerramientas.Size = new System.Drawing.Size(90, 20);
            this.menuHerramientas.Text = "Herramientas";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "1.png");
            this.imageList.Images.SetKeyName(1, "2.png");
            this.imageList.Images.SetKeyName(2, "3.png");
            this.imageList.Images.SetKeyName(3, "4.png");
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(12, 180);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "<";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(108, 180);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 5;
            this.btStop.Text = "STOP";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(204, 180);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 6;
            this.btNext.Text = ">";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PictureBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ListBox";
            // 
            // timerPictureNext
            // 
            this.timerPictureNext.Interval = 1000;
            this.timerPictureNext.Tick += new System.EventHandler(this.timerPictureNext_Tick);
            // 
            // timerPictureBack
            // 
            this.timerPictureBack.Interval = 1000;
            this.timerPictureBack.Tick += new System.EventHandler(this.timerPictureBack_Tick);
            // 
            // PracticaExamen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PracticaExamen2";
            this.Text = "Practica Examen 2";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem menuArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem menuEdicion;
        private System.Windows.Forms.ToolStripMenuItem menuHerramientas;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.ToolStripStatusLabel statusStripsLabelDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerPictureNext;
        private System.Windows.Forms.Timer timerPictureBack;
    }
}

