namespace Sumatorio
{
    partial class Sumatorio
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
            this.lbNums = new System.Windows.Forms.ListBox();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.btSum = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lStart = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.lNums = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNums
            // 
            this.lbNums.FormattingEnabled = true;
            this.lbNums.Location = new System.Drawing.Point(232, 12);
            this.lbNums.Name = "lbNums";
            this.lbNums.Size = new System.Drawing.Size(120, 264);
            this.lbNums.TabIndex = 0;
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(52, 31);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(123, 20);
            this.tbNum.TabIndex = 1;
            this.tbNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNum_KeyDown);
            // 
            // btSum
            // 
            this.btSum.Location = new System.Drawing.Point(75, 57);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(75, 23);
            this.btSum.TabIndex = 2;
            this.btSum.Text = "Sumar";
            this.btSum.UseVisualStyleBackColor = true;
            this.btSum.Click += new System.EventHandler(this.btSum_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(12, 278);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 3;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Introduce números (pulsando enter)";
            // 
            // lStart
            // 
            this.lStart.AutoSize = true;
            this.lStart.Location = new System.Drawing.Point(63, 136);
            this.lStart.Name = "lStart";
            this.lStart.Size = new System.Drawing.Size(68, 13);
            this.lStart.TabIndex = 5;
            this.lStart.Text = "Iniciando en ";
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.Location = new System.Drawing.Point(12, 222);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(74, 25);
            this.lTotal.TabIndex = 7;
            this.lTotal.Text = "Total: ";
            // 
            // lNums
            // 
            this.lNums.AutoSize = true;
            this.lNums.Location = new System.Drawing.Point(231, 291);
            this.lNums.Name = "lNums";
            this.lNums.Size = new System.Drawing.Size(112, 13);
            this.lNums.TabIndex = 8;
            this.lNums.Text = "Números introducidos:";
            // 
            // Sumatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 313);
            this.Controls.Add(this.lNums);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.lStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.lbNums);
            this.Name = "Sumatorio";
            this.Text = "Sumatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNums;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lStart;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label lNums;
    }
}

