namespace final1617ej1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBcargar = new System.Windows.Forms.TextBox();
            this.BTcargar = new System.Windows.Forms.Button();
            this.LABcargar = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TBcargar
            // 
            this.TBcargar.Location = new System.Drawing.Point(24, 41);
            this.TBcargar.Name = "TBcargar";
            this.TBcargar.Size = new System.Drawing.Size(174, 22);
            this.TBcargar.TabIndex = 0;
            // 
            // BTcargar
            // 
            this.BTcargar.Location = new System.Drawing.Point(225, 37);
            this.BTcargar.Name = "BTcargar";
            this.BTcargar.Size = new System.Drawing.Size(79, 31);
            this.BTcargar.TabIndex = 1;
            this.BTcargar.Text = "Cargar";
            this.BTcargar.UseVisualStyleBackColor = true;
            this.BTcargar.Click += new System.EventHandler(this.BTcargar_Click);
            // 
            // LABcargar
            // 
            this.LABcargar.AutoSize = true;
            this.LABcargar.Location = new System.Drawing.Point(21, 21);
            this.LABcargar.Name = "LABcargar";
            this.LABcargar.Size = new System.Drawing.Size(59, 17);
            this.LABcargar.TabIndex = 2;
            this.LABcargar.Text = "Fichero:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(24, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 164);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 284);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LABcargar);
            this.Controls.Add(this.BTcargar);
            this.Controls.Add(this.TBcargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBcargar;
        private System.Windows.Forms.Button BTcargar;
        private System.Windows.Forms.Label LABcargar;
        private System.Windows.Forms.ListBox listBox1;
    }
}

