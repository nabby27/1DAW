namespace Comensales
{
    partial class NuevoComensal
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
            this.btNewComensalCancel = new System.Windows.Forms.Button();
            this.btNewComensalOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNameNewComensal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btNewComensalCancel
            // 
            this.btNewComensalCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btNewComensalCancel.Location = new System.Drawing.Point(12, 68);
            this.btNewComensalCancel.Name = "btNewComensalCancel";
            this.btNewComensalCancel.Size = new System.Drawing.Size(75, 23);
            this.btNewComensalCancel.TabIndex = 0;
            this.btNewComensalCancel.Text = "Cancel";
            this.btNewComensalCancel.UseVisualStyleBackColor = true;
            // 
            // btNewComensalOk
            // 
            this.btNewComensalOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btNewComensalOk.Location = new System.Drawing.Point(348, 68);
            this.btNewComensalOk.Name = "btNewComensalOk";
            this.btNewComensalOk.Size = new System.Drawing.Size(75, 23);
            this.btNewComensalOk.TabIndex = 1;
            this.btNewComensalOk.Text = "Ok";
            this.btNewComensalOk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.tbNameNewComensal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Comensal";
            // 
            // tbNameNewComensal
            // 
            this.tbNameNewComensal.Location = new System.Drawing.Point(6, 19);
            this.tbNameNewComensal.Name = "tbNameNewComensal";
            this.tbNameNewComensal.Size = new System.Drawing.Size(399, 20);
            this.tbNameNewComensal.TabIndex = 0;
            // 
            // nuevoComensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 101);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btNewComensalOk);
            this.Controls.Add(this.btNewComensalCancel);
            this.Name = "nuevoComensal";
            this.Text = "nuevoComensal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNewComensalCancel;
        private System.Windows.Forms.Button btNewComensalOk;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox tbNameNewComensal;
    }
}