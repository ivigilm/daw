namespace ej10creadiccionario
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
            this.LiBcontenido = new System.Windows.Forms.ListBox();
            this.TBen = new System.Windows.Forms.TextBox();
            this.TBes = new System.Windows.Forms.TextBox();
            this.LABen = new System.Windows.Forms.Label();
            this.LABes = new System.Windows.Forms.Label();
            this.BTadd = new System.Windows.Forms.Button();
            this.BTdel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LiBcontenido
            // 
            this.LiBcontenido.FormattingEnabled = true;
            this.LiBcontenido.ItemHeight = 16;
            this.LiBcontenido.Location = new System.Drawing.Point(84, 23);
            this.LiBcontenido.Name = "LiBcontenido";
            this.LiBcontenido.Size = new System.Drawing.Size(275, 244);
            this.LiBcontenido.TabIndex = 0;
            this.LiBcontenido.SelectedIndexChanged += new System.EventHandler(this.LiBcontenido_SelectedIndexChanged);
            // 
            // TBen
            // 
            this.TBen.Location = new System.Drawing.Point(259, 299);
            this.TBen.Name = "TBen";
            this.TBen.Size = new System.Drawing.Size(100, 22);
            this.TBen.TabIndex = 1;
            // 
            // TBes
            // 
            this.TBes.Location = new System.Drawing.Point(259, 348);
            this.TBes.Name = "TBes";
            this.TBes.Size = new System.Drawing.Size(100, 22);
            this.TBes.TabIndex = 2;
            // 
            // LABen
            // 
            this.LABen.AutoSize = true;
            this.LABen.Location = new System.Drawing.Point(81, 302);
            this.LABen.Name = "LABen";
            this.LABen.Size = new System.Drawing.Size(156, 17);
            this.LABen.TabIndex = 3;
            this.LABen.Text = "Nueva palabra (inglés):";
            // 
            // LABes
            // 
            this.LABes.AutoSize = true;
            this.LABes.Location = new System.Drawing.Point(81, 348);
            this.LABes.Name = "LABes";
            this.LABes.Size = new System.Drawing.Size(169, 17);
            this.LABes.TabIndex = 4;
            this.LABes.Text = "Nueva palabra (español):";
            // 
            // BTadd
            // 
            this.BTadd.Location = new System.Drawing.Point(111, 404);
            this.BTadd.Name = "BTadd";
            this.BTadd.Size = new System.Drawing.Size(75, 23);
            this.BTadd.TabIndex = 5;
            this.BTadd.Text = "Añadir";
            this.BTadd.UseVisualStyleBackColor = true;
            this.BTadd.Click += new System.EventHandler(this.BTadd_Click);
            // 
            // BTdel
            // 
            this.BTdel.Enabled = false;
            this.BTdel.Location = new System.Drawing.Point(259, 404);
            this.BTdel.Name = "BTdel";
            this.BTdel.Size = new System.Drawing.Size(75, 23);
            this.BTdel.TabIndex = 6;
            this.BTdel.Text = "Borrar";
            this.BTdel.UseVisualStyleBackColor = true;
            this.BTdel.Click += new System.EventHandler(this.BTdel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 451);
            this.Controls.Add(this.BTdel);
            this.Controls.Add(this.BTadd);
            this.Controls.Add(this.LABes);
            this.Controls.Add(this.LABen);
            this.Controls.Add(this.TBes);
            this.Controls.Add(this.TBen);
            this.Controls.Add(this.LiBcontenido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LiBcontenido;
        private System.Windows.Forms.TextBox TBen;
        private System.Windows.Forms.TextBox TBes;
        private System.Windows.Forms.Label LABen;
        private System.Windows.Forms.Label LABes;
        private System.Windows.Forms.Button BTadd;
        private System.Windows.Forms.Button BTdel;
    }
}

