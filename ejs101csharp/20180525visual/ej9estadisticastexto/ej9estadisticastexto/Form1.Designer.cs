namespace ej9estadisticastexto
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
            this.TBcontenido = new System.Windows.Forms.TextBox();
            this.LBletras = new System.Windows.Forms.Label();
            this.LBpalabras = new System.Windows.Forms.Label();
            this.LBespacios = new System.Windows.Forms.Label();
            this.LBvocales = new System.Windows.Forms.Label();
            this.LBconsonantes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBcontenido
            // 
            this.TBcontenido.Location = new System.Drawing.Point(12, 12);
            this.TBcontenido.Name = "TBcontenido";
            this.TBcontenido.Size = new System.Drawing.Size(825, 22);
            this.TBcontenido.TabIndex = 0;
            this.TBcontenido.TextChanged += new System.EventHandler(this.TBcontenido_TextChanged);
            // 
            // LBletras
            // 
            this.LBletras.AutoSize = true;
            this.LBletras.Location = new System.Drawing.Point(12, 51);
            this.LBletras.Name = "LBletras";
            this.LBletras.Size = new System.Drawing.Size(125, 17);
            this.LBletras.TabIndex = 1;
            this.LBletras.Text = "Número de letras: ";
            // 
            // LBpalabras
            // 
            this.LBpalabras.AutoSize = true;
            this.LBpalabras.Location = new System.Drawing.Point(12, 80);
            this.LBpalabras.Name = "LBpalabras";
            this.LBpalabras.Size = new System.Drawing.Size(145, 17);
            this.LBpalabras.TabIndex = 2;
            this.LBpalabras.Text = "Número de palabras: ";
            // 
            // LBespacios
            // 
            this.LBespacios.AutoSize = true;
            this.LBespacios.Location = new System.Drawing.Point(12, 111);
            this.LBespacios.Name = "LBespacios";
            this.LBespacios.Size = new System.Drawing.Size(146, 17);
            this.LBespacios.TabIndex = 3;
            this.LBespacios.Text = "Número de espacios: ";
            // 
            // LBvocales
            // 
            this.LBvocales.AutoSize = true;
            this.LBvocales.Location = new System.Drawing.Point(388, 51);
            this.LBvocales.Name = "LBvocales";
            this.LBvocales.Size = new System.Drawing.Size(138, 17);
            this.LBvocales.TabIndex = 4;
            this.LBvocales.Text = "Número de vocales: ";
            // 
            // LBconsonantes
            // 
            this.LBconsonantes.AutoSize = true;
            this.LBconsonantes.Location = new System.Drawing.Point(388, 80);
            this.LBconsonantes.Name = "LBconsonantes";
            this.LBconsonantes.Size = new System.Drawing.Size(171, 17);
            this.LBconsonantes.TabIndex = 5;
            this.LBconsonantes.Text = "Número de consonantes: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 150);
            this.Controls.Add(this.LBconsonantes);
            this.Controls.Add(this.LBvocales);
            this.Controls.Add(this.LBespacios);
            this.Controls.Add(this.LBpalabras);
            this.Controls.Add(this.LBletras);
            this.Controls.Add(this.TBcontenido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBcontenido;
        private System.Windows.Forms.Label LBletras;
        private System.Windows.Forms.Label LBpalabras;
        private System.Windows.Forms.Label LBespacios;
        private System.Windows.Forms.Label LBvocales;
        private System.Windows.Forms.Label LBconsonantes;
    }
}

