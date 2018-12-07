namespace Peliculas
{
    partial class Peliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peliculas));
            this.ilKillBill = new System.Windows.Forms.ImageList(this.components);
            this.ilDjango = new System.Windows.Forms.ImageList(this.components);
            this.ilAbierto = new System.Windows.Forms.ImageList(this.components);
            this.pbImagenes = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPeliculas = new System.Windows.Forms.ComboBox();
            this.lFichaText = new System.Windows.Forms.Label();
            this.lFichaTecnicaDescripcion = new System.Windows.Forms.Label();
            this.lSinopsisText = new System.Windows.Forms.Label();
            this.lSinopsisDescripcion = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // ilKillBill
            // 
            this.ilKillBill.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilKillBill.ImageStream")));
            this.ilKillBill.TransparentColor = System.Drawing.Color.Transparent;
            this.ilKillBill.Images.SetKeyName(0, "kill_bill02.jpg");
            this.ilKillBill.Images.SetKeyName(1, "resizer.jpg");
            this.ilKillBill.Images.SetKeyName(2, "venta-al-por-mayor-de-alta-calidad-kill-bill.jpg");
            // 
            // ilDjango
            // 
            this.ilDjango.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilDjango.ImageStream")));
            this.ilDjango.TransparentColor = System.Drawing.Color.Transparent;
            this.ilDjango.Images.SetKeyName(0, "81GFaYoEjkL._SX342_.jpg");
            this.ilDjango.Images.SetKeyName(1, "django_1.jpg");
            this.ilDjango.Images.SetKeyName(2, "Django_Unchained_Poster.jpg");
            // 
            // ilAbierto
            // 
            this.ilAbierto.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilAbierto.ImageStream")));
            this.ilAbierto.TransparentColor = System.Drawing.Color.Transparent;
            this.ilAbierto.Images.SetKeyName(0, "40303526.jpg");
            this.ilAbierto.Images.SetKeyName(1, "resizer (1).jpg");
            this.ilAbierto.Images.SetKeyName(2, "still_0_3_790x398.jpg");
            // 
            // pbImagenes
            // 
            this.pbImagenes.Location = new System.Drawing.Point(233, 37);
            this.pbImagenes.Name = "pbImagenes";
            this.pbImagenes.Size = new System.Drawing.Size(164, 154);
            this.pbImagenes.TabIndex = 0;
            this.pbImagenes.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona Película";
            // 
            // cbPeliculas
            // 
            this.cbPeliculas.FormattingEnabled = true;
            this.cbPeliculas.Location = new System.Drawing.Point(17, 37);
            this.cbPeliculas.Name = "cbPeliculas";
            this.cbPeliculas.Size = new System.Drawing.Size(196, 21);
            this.cbPeliculas.TabIndex = 2;
            this.cbPeliculas.SelectedIndexChanged += new System.EventHandler(this.cbPeliculas_SelectedIndexChanged);
            // 
            // lFichaText
            // 
            this.lFichaText.AutoSize = true;
            this.lFichaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFichaText.Location = new System.Drawing.Point(14, 79);
            this.lFichaText.Name = "lFichaText";
            this.lFichaText.Size = new System.Drawing.Size(109, 17);
            this.lFichaText.TabIndex = 3;
            this.lFichaText.Text = "Ficha Técnica";
            this.lFichaText.Visible = false;
            // 
            // lFichaTecnicaDescripcion
            // 
            this.lFichaTecnicaDescripcion.Location = new System.Drawing.Point(14, 112);
            this.lFichaTecnicaDescripcion.Name = "lFichaTecnicaDescripcion";
            this.lFichaTecnicaDescripcion.Size = new System.Drawing.Size(196, 110);
            this.lFichaTecnicaDescripcion.TabIndex = 4;
            // 
            // lSinopsisText
            // 
            this.lSinopsisText.AutoSize = true;
            this.lSinopsisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSinopsisText.Location = new System.Drawing.Point(14, 237);
            this.lSinopsisText.Name = "lSinopsisText";
            this.lSinopsisText.Size = new System.Drawing.Size(69, 17);
            this.lSinopsisText.TabIndex = 5;
            this.lSinopsisText.Text = "Sinópsis";
            this.lSinopsisText.Visible = false;
            // 
            // lSinopsisDescripcion
            // 
            this.lSinopsisDescripcion.Location = new System.Drawing.Point(14, 263);
            this.lSinopsisDescripcion.Name = "lSinopsisDescripcion";
            this.lSinopsisDescripcion.Size = new System.Drawing.Size(383, 120);
            this.lSinopsisDescripcion.TabIndex = 6;
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 392);
            this.Controls.Add(this.lSinopsisDescripcion);
            this.Controls.Add(this.lSinopsisText);
            this.Controls.Add(this.lFichaTecnicaDescripcion);
            this.Controls.Add(this.lFichaText);
            this.Controls.Add(this.cbPeliculas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImagenes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Peliculas";
            this.Text = "Peliculas";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ilKillBill;
        private System.Windows.Forms.ImageList ilDjango;
        private System.Windows.Forms.ImageList ilAbierto;
        private System.Windows.Forms.PictureBox pbImagenes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPeliculas;
        private System.Windows.Forms.Label lFichaText;
        private System.Windows.Forms.Label lFichaTecnicaDescripcion;
        private System.Windows.Forms.Label lSinopsisText;
        private System.Windows.Forms.Label lSinopsisDescripcion;
        private System.Windows.Forms.Timer timer;
    }
}

