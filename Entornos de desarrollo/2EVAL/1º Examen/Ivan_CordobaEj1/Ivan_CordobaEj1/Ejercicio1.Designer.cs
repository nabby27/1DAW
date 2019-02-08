namespace Ivan_CordobaEj1
{
    partial class Ejercicio1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio1));
            this.btCereza = new System.Windows.Forms.Button();
            this.btFresa = new System.Windows.Forms.Button();
            this.btNaranja = new System.Windows.Forms.Button();
            this.btMelocoton = new System.Windows.Forms.Button();
            this.btPera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTicket = new System.Windows.Forms.ListBox();
            this.btClean = new System.Windows.Forms.Button();
            this.btSetPrice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tbPriceCerezas = new System.Windows.Forms.TextBox();
            this.tbPricePeras = new System.Windows.Forms.TextBox();
            this.tbPriceMelocontones = new System.Windows.Forms.TextBox();
            this.tbPriceNaranjas = new System.Windows.Forms.TextBox();
            this.tbPriceFresas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btCereza
            // 
            this.btCereza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCereza.BackgroundImage")));
            this.btCereza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCereza.Enabled = false;
            this.btCereza.Location = new System.Drawing.Point(30, 12);
            this.btCereza.Name = "btCereza";
            this.btCereza.Size = new System.Drawing.Size(75, 71);
            this.btCereza.TabIndex = 0;
            this.btCereza.UseVisualStyleBackColor = true;
            this.btCereza.Click += new System.EventHandler(this.btCereza_Click);
            // 
            // btFresa
            // 
            this.btFresa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btFresa.BackgroundImage")));
            this.btFresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFresa.Enabled = false;
            this.btFresa.Location = new System.Drawing.Point(111, 12);
            this.btFresa.Name = "btFresa";
            this.btFresa.Size = new System.Drawing.Size(75, 71);
            this.btFresa.TabIndex = 1;
            this.btFresa.UseVisualStyleBackColor = true;
            this.btFresa.Click += new System.EventHandler(this.btFresa_Click);
            // 
            // btNaranja
            // 
            this.btNaranja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btNaranja.BackgroundImage")));
            this.btNaranja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNaranja.Enabled = false;
            this.btNaranja.Location = new System.Drawing.Point(192, 12);
            this.btNaranja.Name = "btNaranja";
            this.btNaranja.Size = new System.Drawing.Size(75, 71);
            this.btNaranja.TabIndex = 2;
            this.btNaranja.UseVisualStyleBackColor = true;
            this.btNaranja.Click += new System.EventHandler(this.btNaranja_Click);
            // 
            // btMelocoton
            // 
            this.btMelocoton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btMelocoton.BackgroundImage")));
            this.btMelocoton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMelocoton.Enabled = false;
            this.btMelocoton.Location = new System.Drawing.Point(273, 12);
            this.btMelocoton.Name = "btMelocoton";
            this.btMelocoton.Size = new System.Drawing.Size(75, 71);
            this.btMelocoton.TabIndex = 3;
            this.btMelocoton.UseVisualStyleBackColor = true;
            this.btMelocoton.Click += new System.EventHandler(this.btMelocoton_Click);
            // 
            // btPera
            // 
            this.btPera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPera.BackgroundImage")));
            this.btPera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPera.Enabled = false;
            this.btPera.Location = new System.Drawing.Point(354, 12);
            this.btPera.Name = "btPera";
            this.btPera.Size = new System.Drawing.Size(75, 71);
            this.btPera.TabIndex = 4;
            this.btPera.UseVisualStyleBackColor = true;
            this.btPera.Click += new System.EventHandler(this.btPera_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad (kg)";
            // 
            // tbCant
            // 
            this.tbCant.Enabled = false;
            this.tbCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCant.Location = new System.Drawing.Point(245, 113);
            this.tbCant.Name = "tbCant";
            this.tbCant.Size = new System.Drawing.Size(36, 26);
            this.tbCant.TabIndex = 6;
            this.tbCant.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total";
            // 
            // lbTicket
            // 
            this.lbTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTicket.FormattingEnabled = true;
            this.lbTicket.ItemHeight = 20;
            this.lbTicket.Location = new System.Drawing.Point(45, 166);
            this.lbTicket.Name = "lbTicket";
            this.lbTicket.Size = new System.Drawing.Size(369, 144);
            this.lbTicket.TabIndex = 8;
            // 
            // btClean
            // 
            this.btClean.Location = new System.Drawing.Point(166, 330);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(127, 23);
            this.btClean.TabIndex = 9;
            this.btClean.Text = "Limpiar ticket";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click_1);
            // 
            // btSetPrice
            // 
            this.btSetPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetPrice.Location = new System.Drawing.Point(166, 359);
            this.btSetPrice.Name = "btSetPrice";
            this.btSetPrice.Size = new System.Drawing.Size(127, 23);
            this.btSetPrice.TabIndex = 10;
            this.btSetPrice.Text = "Precios Rellenados";
            this.btSetPrice.UseVisualStyleBackColor = true;
            this.btSetPrice.Click += new System.EventHandler(this.btClean_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(10, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(99, 387);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(188, 387);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(277, 387);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(366, 387);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // tbPriceCerezas
            // 
            this.tbPriceCerezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPriceCerezas.Location = new System.Drawing.Point(70, 401);
            this.tbPriceCerezas.Name = "tbPriceCerezas";
            this.tbPriceCerezas.Size = new System.Drawing.Size(23, 20);
            this.tbPriceCerezas.TabIndex = 16;
            // 
            // tbPricePeras
            // 
            this.tbPricePeras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPricePeras.Location = new System.Drawing.Point(426, 401);
            this.tbPricePeras.Name = "tbPricePeras";
            this.tbPricePeras.Size = new System.Drawing.Size(23, 20);
            this.tbPricePeras.TabIndex = 17;
            // 
            // tbPriceMelocontones
            // 
            this.tbPriceMelocontones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPriceMelocontones.Location = new System.Drawing.Point(337, 401);
            this.tbPriceMelocontones.Name = "tbPriceMelocontones";
            this.tbPriceMelocontones.Size = new System.Drawing.Size(23, 20);
            this.tbPriceMelocontones.TabIndex = 18;
            // 
            // tbPriceNaranjas
            // 
            this.tbPriceNaranjas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPriceNaranjas.Location = new System.Drawing.Point(248, 401);
            this.tbPriceNaranjas.Name = "tbPriceNaranjas";
            this.tbPriceNaranjas.Size = new System.Drawing.Size(23, 20);
            this.tbPriceNaranjas.TabIndex = 19;
            // 
            // tbPriceFresas
            // 
            this.tbPriceFresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPriceFresas.Location = new System.Drawing.Point(159, 401);
            this.tbPriceFresas.Name = "tbPriceFresas";
            this.tbPriceFresas.Size = new System.Drawing.Size(23, 20);
            this.tbPriceFresas.TabIndex = 20;
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 449);
            this.Controls.Add(this.tbPriceFresas);
            this.Controls.Add(this.tbPriceNaranjas);
            this.Controls.Add(this.tbPriceMelocontones);
            this.Controls.Add(this.tbPricePeras);
            this.Controls.Add(this.tbPriceCerezas);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSetPrice);
            this.Controls.Add(this.btClean);
            this.Controls.Add(this.lbTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPera);
            this.Controls.Add(this.btMelocoton);
            this.Controls.Add(this.btNaranja);
            this.Controls.Add(this.btFresa);
            this.Controls.Add(this.btCereza);
            this.Name = "Ejercicio1";
            this.Text = "Tienda de alimentación";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCereza;
        private System.Windows.Forms.Button btFresa;
        private System.Windows.Forms.Button btNaranja;
        private System.Windows.Forms.Button btMelocoton;
        private System.Windows.Forms.Button btPera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbTicket;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.Button btSetPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox tbPriceCerezas;
        private System.Windows.Forms.TextBox tbPricePeras;
        private System.Windows.Forms.TextBox tbPriceMelocontones;
        private System.Windows.Forms.TextBox tbPriceNaranjas;
        private System.Windows.Forms.TextBox tbPriceFresas;
    }
}

