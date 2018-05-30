namespace ej6traductorenes
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
            this.TBen = new System.Windows.Forms.TextBox();
            this.TBes = new System.Windows.Forms.TextBox();
            this.BTenes = new System.Windows.Forms.Button();
            this.BTesen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBen
            // 
            this.TBen.Location = new System.Drawing.Point(77, 60);
            this.TBen.Name = "TBen";
            this.TBen.Size = new System.Drawing.Size(112, 22);
            this.TBen.TabIndex = 0;
            this.TBen.Text = "English";
            // 
            // TBes
            // 
            this.TBes.Location = new System.Drawing.Point(77, 121);
            this.TBes.Name = "TBes";
            this.TBes.Size = new System.Drawing.Size(112, 22);
            this.TBes.TabIndex = 1;
            this.TBes.Text = "Español";
            // 
            // BTenes
            // 
            this.BTenes.Location = new System.Drawing.Point(32, 193);
            this.BTenes.Name = "BTenes";
            this.BTenes.Size = new System.Drawing.Size(75, 23);
            this.BTenes.TabIndex = 2;
            this.BTenes.Text = "EN > ES";
            this.BTenes.UseVisualStyleBackColor = true;
            this.BTenes.Click += new System.EventHandler(this.BTenes_Click);
            // 
            // BTesen
            // 
            this.BTesen.Location = new System.Drawing.Point(163, 193);
            this.BTesen.Name = "BTesen";
            this.BTesen.Size = new System.Drawing.Size(75, 23);
            this.BTesen.TabIndex = 3;
            this.BTesen.Text = "ES > EN";
            this.BTesen.UseVisualStyleBackColor = true;
            this.BTesen.Click += new System.EventHandler(this.BTesen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.BTesen);
            this.Controls.Add(this.BTenes);
            this.Controls.Add(this.TBes);
            this.Controls.Add(this.TBen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBen;
        private System.Windows.Forms.TextBox TBes;
        private System.Windows.Forms.Button BTenes;
        private System.Windows.Forms.Button BTesen;
    }
}

