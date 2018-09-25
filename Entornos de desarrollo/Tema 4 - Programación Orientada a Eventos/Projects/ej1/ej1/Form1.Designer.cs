namespace ej1
{
    partial class Form1
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
            this.lPosicionRaton = new System.Windows.Forms.Label();
            this.lColorTexto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bRojo = new System.Windows.Forms.Button();
            this.bVerde = new System.Windows.Forms.Button();
            this.bIzquierda = new System.Windows.Forms.Button();
            this.bCentro = new System.Windows.Forms.Button();
            this.bDerecha = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lPosicionRaton
            // 
            this.lPosicionRaton.AutoSize = true;
            this.lPosicionRaton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPosicionRaton.Location = new System.Drawing.Point(13, 13);
            this.lPosicionRaton.Name = "lPosicionRaton";
            this.lPosicionRaton.Size = new System.Drawing.Size(288, 39);
            this.lPosicionRaton.TabIndex = 0;
            this.lPosicionRaton.Text = "Posición del ratón";
            // 
            // lColorTexto
            // 
            this.lColorTexto.AutoSize = true;
            this.lColorTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lColorTexto.Location = new System.Drawing.Point(369, 13);
            this.lColorTexto.Name = "lColorTexto";
            this.lColorTexto.Size = new System.Drawing.Size(181, 39);
            this.lColorTexto.TabIndex = 1;
            this.lColorTexto.Text = "Color texto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Posición Ratón X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Posición Ratón Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // bRojo
            // 
            this.bRojo.Location = new System.Drawing.Point(376, 64);
            this.bRojo.Name = "bRojo";
            this.bRojo.Size = new System.Drawing.Size(75, 23);
            this.bRojo.TabIndex = 6;
            this.bRojo.Text = "Rojo";
            this.bRojo.UseVisualStyleBackColor = true;
            this.bRojo.Click += new System.EventHandler(this.bRojo_Click);
            // 
            // bVerde
            // 
            this.bVerde.Location = new System.Drawing.Point(475, 64);
            this.bVerde.Name = "bVerde";
            this.bVerde.Size = new System.Drawing.Size(75, 23);
            this.bVerde.TabIndex = 7;
            this.bVerde.Text = "Verde";
            this.bVerde.UseVisualStyleBackColor = true;
            this.bVerde.Click += new System.EventHandler(this.bVerde_Click);
            // 
            // bIzquierda
            // 
            this.bIzquierda.Location = new System.Drawing.Point(69, 145);
            this.bIzquierda.Name = "bIzquierda";
            this.bIzquierda.Size = new System.Drawing.Size(75, 23);
            this.bIzquierda.TabIndex = 8;
            this.bIzquierda.Text = "Izquierda";
            this.bIzquierda.UseVisualStyleBackColor = true;
            this.bIzquierda.Click += new System.EventHandler(this.bIzquierda_Click);
            // 
            // bCentro
            // 
            this.bCentro.Location = new System.Drawing.Point(196, 145);
            this.bCentro.Name = "bCentro";
            this.bCentro.Size = new System.Drawing.Size(75, 23);
            this.bCentro.TabIndex = 9;
            this.bCentro.Text = "Centro";
            this.bCentro.UseVisualStyleBackColor = true;
            this.bCentro.Click += new System.EventHandler(this.bCentro_Click);
            // 
            // bDerecha
            // 
            this.bDerecha.Location = new System.Drawing.Point(322, 145);
            this.bDerecha.Name = "bDerecha";
            this.bDerecha.Size = new System.Drawing.Size(75, 23);
            this.bDerecha.TabIndex = 10;
            this.bDerecha.Text = "Derecha";
            this.bDerecha.UseVisualStyleBackColor = true;
            this.bDerecha.Click += new System.EventHandler(this.bDerecha_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(510, 166);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 11;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 201);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bDerecha);
            this.Controls.Add(this.bCentro);
            this.Controls.Add(this.bIzquierda);
            this.Controls.Add(this.bVerde);
            this.Controls.Add(this.bRojo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lColorTexto);
            this.Controls.Add(this.lPosicionRaton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPosicionRaton;
        private System.Windows.Forms.Label lColorTexto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bRojo;
        private System.Windows.Forms.Button bVerde;
        private System.Windows.Forms.Button bIzquierda;
        private System.Windows.Forms.Button bCentro;
        private System.Windows.Forms.Button bDerecha;
        private System.Windows.Forms.Button bCerrar;

    }
}

