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
            this.ilKillBill = new System.Windows.Forms.ImageList(this.components);
            this.ilDjango = new System.Windows.Forms.ImageList(this.components);
            this.ilAbierto = new System.Windows.Forms.ImageList(this.components);
            this.pbImagenes = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPeliculas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lFichaTecnicaDescripcion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lSinopsisDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // ilKillBill
            // 
            this.ilKillBill.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilKillBill.ImageSize = new System.Drawing.Size(160, 160);
            this.ilKillBill.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilDjango
            // 
            this.ilDjango.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilDjango.ImageSize = new System.Drawing.Size(160, 160);
            this.ilDjango.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilAbierto
            // 
            this.ilAbierto.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilAbierto.ImageSize = new System.Drawing.Size(160, 160);
            this.ilAbierto.TransparentColor = System.Drawing.Color.Transparent;
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ficha Técnica";
            // 
            // lFichaTecnicaDescripcion
            // 
            this.lFichaTecnicaDescripcion.Location = new System.Drawing.Point(14, 112);
            this.lFichaTecnicaDescripcion.Name = "lFichaTecnicaDescripcion";
            this.lFichaTecnicaDescripcion.Size = new System.Drawing.Size(196, 110);
            this.lFichaTecnicaDescripcion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sinópsis";
            // 
            // lSinopsisDescripcion
            // 
            this.lSinopsisDescripcion.Location = new System.Drawing.Point(14, 263);
            this.lSinopsisDescripcion.Name = "lSinopsisDescripcion";
            this.lSinopsisDescripcion.Size = new System.Drawing.Size(383, 120);
            this.lSinopsisDescripcion.TabIndex = 6;
            // 
            // Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 392);
            this.Controls.Add(this.lSinopsisDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lFichaTecnicaDescripcion);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lFichaTecnicaDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lSinopsisDescripcion;
    }
}

