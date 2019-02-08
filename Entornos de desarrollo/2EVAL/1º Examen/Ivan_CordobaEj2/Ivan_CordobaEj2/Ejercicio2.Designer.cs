namespace Ivan_CordobaEj2
{
    partial class Ejercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio2));
            this.lbNums1 = new System.Windows.Forms.ListBox();
            this.lbNums2 = new System.Windows.Forms.ListBox();
            this.btToRightOne = new System.Windows.Forms.Button();
            this.btToRightAll = new System.Windows.Forms.Button();
            this.btToLeftOne = new System.Windows.Forms.Button();
            this.btToLeftAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNums1
            // 
            this.lbNums1.FormattingEnabled = true;
            this.lbNums1.Location = new System.Drawing.Point(14, 38);
            this.lbNums1.Name = "lbNums1";
            this.lbNums1.Size = new System.Drawing.Size(120, 212);
            this.lbNums1.TabIndex = 0;
            // 
            // lbNums2
            // 
            this.lbNums2.FormattingEnabled = true;
            this.lbNums2.Location = new System.Drawing.Point(195, 38);
            this.lbNums2.Name = "lbNums2";
            this.lbNums2.Size = new System.Drawing.Size(120, 212);
            this.lbNums2.TabIndex = 1;
            // 
            // btToRightOne
            // 
            this.btToRightOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btToRightOne.BackgroundImage")));
            this.btToRightOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btToRightOne.Location = new System.Drawing.Point(140, 47);
            this.btToRightOne.Name = "btToRightOne";
            this.btToRightOne.Size = new System.Drawing.Size(49, 43);
            this.btToRightOne.TabIndex = 2;
            this.btToRightOne.UseVisualStyleBackColor = true;
            this.btToRightOne.Click += new System.EventHandler(this.btToRightOne_Click);
            // 
            // btToRightAll
            // 
            this.btToRightAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btToRightAll.BackgroundImage")));
            this.btToRightAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btToRightAll.Location = new System.Drawing.Point(140, 96);
            this.btToRightAll.Name = "btToRightAll";
            this.btToRightAll.Size = new System.Drawing.Size(49, 43);
            this.btToRightAll.TabIndex = 3;
            this.btToRightAll.UseVisualStyleBackColor = true;
            this.btToRightAll.Click += new System.EventHandler(this.btToRightAll_Click);
            // 
            // btToLeftOne
            // 
            this.btToLeftOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btToLeftOne.BackgroundImage")));
            this.btToLeftOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btToLeftOne.Location = new System.Drawing.Point(140, 145);
            this.btToLeftOne.Name = "btToLeftOne";
            this.btToLeftOne.Size = new System.Drawing.Size(49, 43);
            this.btToLeftOne.TabIndex = 4;
            this.btToLeftOne.UseVisualStyleBackColor = true;
            this.btToLeftOne.Click += new System.EventHandler(this.btToLeftOne_Click);
            // 
            // btToLeftAll
            // 
            this.btToLeftAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btToLeftAll.BackgroundImage")));
            this.btToLeftAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btToLeftAll.Location = new System.Drawing.Point(140, 194);
            this.btToLeftAll.Name = "btToLeftAll";
            this.btToLeftAll.Size = new System.Drawing.Size(49, 43);
            this.btToLeftAll.TabIndex = 5;
            this.btToLeftAll.UseVisualStyleBackColor = true;
            this.btToLeftAll.Click += new System.EventHandler(this.btToLeftAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Archivo";
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 263);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btToLeftAll);
            this.Controls.Add(this.btToLeftOne);
            this.Controls.Add(this.btToRightAll);
            this.Controls.Add(this.btToRightOne);
            this.Controls.Add(this.lbNums2);
            this.Controls.Add(this.lbNums1);
            this.Name = "Ejercicio2";
            this.Text = "Intercambio de elementos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNums1;
        private System.Windows.Forms.ListBox lbNums2;
        private System.Windows.Forms.Button btToRightOne;
        private System.Windows.Forms.Button btToRightAll;
        private System.Windows.Forms.Button btToLeftOne;
        private System.Windows.Forms.Button btToLeftAll;
        private System.Windows.Forms.Label label1;
    }
}

