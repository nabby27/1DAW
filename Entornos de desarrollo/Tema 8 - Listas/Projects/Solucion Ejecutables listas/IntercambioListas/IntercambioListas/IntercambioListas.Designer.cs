namespace IntercambioListas
{
    partial class IntercambioListas
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
            this.lbLeft = new System.Windows.Forms.ListBox();
            this.lbRight = new System.Windows.Forms.ListBox();
            this.btToRightOne = new System.Windows.Forms.Button();
            this.btToRightAll = new System.Windows.Forms.Button();
            this.btToLeftAll = new System.Windows.Forms.Button();
            this.btToLeftOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLeft
            // 
            this.lbLeft.FormattingEnabled = true;
            this.lbLeft.Location = new System.Drawing.Point(12, 12);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(146, 238);
            this.lbLeft.TabIndex = 0;
            // 
            // lbRight
            // 
            this.lbRight.FormattingEnabled = true;
            this.lbRight.Location = new System.Drawing.Point(275, 12);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(146, 238);
            this.lbRight.TabIndex = 1;
            // 
            // btToRightOne
            // 
            this.btToRightOne.Location = new System.Drawing.Point(180, 28);
            this.btToRightOne.Name = "btToRightOne";
            this.btToRightOne.Size = new System.Drawing.Size(75, 23);
            this.btToRightOne.TabIndex = 2;
            this.btToRightOne.Text = ">";
            this.btToRightOne.UseVisualStyleBackColor = true;
            this.btToRightOne.Click += new System.EventHandler(this.btToRightOne_Click);
            // 
            // btToRightAll
            // 
            this.btToRightAll.Location = new System.Drawing.Point(180, 83);
            this.btToRightAll.Name = "btToRightAll";
            this.btToRightAll.Size = new System.Drawing.Size(75, 23);
            this.btToRightAll.TabIndex = 3;
            this.btToRightAll.Text = ">>";
            this.btToRightAll.UseVisualStyleBackColor = true;
            this.btToRightAll.Click += new System.EventHandler(this.btToRightAll_Click);
            // 
            // btToLeftAll
            // 
            this.btToLeftAll.Location = new System.Drawing.Point(180, 144);
            this.btToLeftAll.Name = "btToLeftAll";
            this.btToLeftAll.Size = new System.Drawing.Size(75, 23);
            this.btToLeftAll.TabIndex = 4;
            this.btToLeftAll.Text = "<<";
            this.btToLeftAll.UseVisualStyleBackColor = true;
            this.btToLeftAll.Click += new System.EventHandler(this.btToLeftAll_Click);
            // 
            // btToLeftOne
            // 
            this.btToLeftOne.Location = new System.Drawing.Point(180, 201);
            this.btToLeftOne.Name = "btToLeftOne";
            this.btToLeftOne.Size = new System.Drawing.Size(75, 23);
            this.btToLeftOne.TabIndex = 5;
            this.btToLeftOne.Text = "<";
            this.btToLeftOne.UseVisualStyleBackColor = true;
            this.btToLeftOne.Click += new System.EventHandler(this.btToLeftOne_Click);
            // 
            // IntercambioListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 262);
            this.Controls.Add(this.btToLeftOne);
            this.Controls.Add(this.btToLeftAll);
            this.Controls.Add(this.btToRightAll);
            this.Controls.Add(this.btToRightOne);
            this.Controls.Add(this.lbRight);
            this.Controls.Add(this.lbLeft);
            this.Name = "IntercambioListas";
            this.Text = "Intercambio entre listas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLeft;
        private System.Windows.Forms.ListBox lbRight;
        private System.Windows.Forms.Button btToRightOne;
        private System.Windows.Forms.Button btToRightAll;
        private System.Windows.Forms.Button btToLeftAll;
        private System.Windows.Forms.Button btToLeftOne;
    }
}

