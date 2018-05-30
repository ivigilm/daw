namespace ej5conversorpulgadas
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
            this.TBcm = new System.Windows.Forms.TextBox();
            this.TBin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBcm
            // 
            this.TBcm.Location = new System.Drawing.Point(88, 128);
            this.TBcm.Name = "TBcm";
            this.TBcm.Size = new System.Drawing.Size(100, 22);
            this.TBcm.TabIndex = 0;
            this.TBcm.Text = "cm";
            this.TBcm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBcm.TextChanged += new System.EventHandler(this.TBcm_TextChanged);
            // 
            // TBin
            // 
            this.TBin.Location = new System.Drawing.Point(88, 179);
            this.TBin.Name = "TBin";
            this.TBin.Size = new System.Drawing.Size(100, 22);
            this.TBin.TabIndex = 1;
            this.TBin.Text = "pulgadas";
            this.TBin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBin.TextChanged += new System.EventHandler(this.TBin_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 92);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduce tu medida en la caja correspondiente\r\ny se actualizará la medida equiva" +
    "lente en la otra.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBin);
            this.Controls.Add(this.TBcm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBcm;
        private System.Windows.Forms.TextBox TBin;
        private System.Windows.Forms.Label label1;
    }
}

