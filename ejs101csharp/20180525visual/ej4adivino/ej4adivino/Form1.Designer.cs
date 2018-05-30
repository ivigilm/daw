namespace ej4adivino
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
            this.BTmayor = new System.Windows.Forms.Button();
            this.BTmenor = new System.Windows.Forms.Button();
            this.BTacertado = new System.Windows.Forms.Button();
            this.LBinstrucciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTmayor
            // 
            this.BTmayor.Location = new System.Drawing.Point(70, 122);
            this.BTmayor.Name = "BTmayor";
            this.BTmayor.Size = new System.Drawing.Size(197, 45);
            this.BTmayor.TabIndex = 0;
            this.BTmayor.Text = "¡Mi número es mayor!";
            this.BTmayor.UseVisualStyleBackColor = true;
            this.BTmayor.Click += new System.EventHandler(this.BTmayor_Click);
            // 
            // BTmenor
            // 
            this.BTmenor.Location = new System.Drawing.Point(70, 189);
            this.BTmenor.Name = "BTmenor";
            this.BTmenor.Size = new System.Drawing.Size(197, 53);
            this.BTmenor.TabIndex = 1;
            this.BTmenor.Text = "¡Mi número es menor!";
            this.BTmenor.UseVisualStyleBackColor = true;
            this.BTmenor.Click += new System.EventHandler(this.BTmenor_Click);
            // 
            // BTacertado
            // 
            this.BTacertado.Location = new System.Drawing.Point(70, 263);
            this.BTacertado.Name = "BTacertado";
            this.BTacertado.Size = new System.Drawing.Size(197, 49);
            this.BTacertado.TabIndex = 2;
            this.BTacertado.Text = "¡Has acertado!";
            this.BTacertado.UseVisualStyleBackColor = true;
            this.BTacertado.Click += new System.EventHandler(this.BTacertado_Click);
            // 
            // LBinstrucciones
            // 
            this.LBinstrucciones.Location = new System.Drawing.Point(88, 32);
            this.LBinstrucciones.Name = "LBinstrucciones";
            this.LBinstrucciones.Size = new System.Drawing.Size(165, 60);
            this.LBinstrucciones.TabIndex = 3;
            this.LBinstrucciones.Text = "¡Vamos a jugar!\r\n\r\n¿Es tu número el 50?";
            this.LBinstrucciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 340);
            this.Controls.Add(this.LBinstrucciones);
            this.Controls.Add(this.BTacertado);
            this.Controls.Add(this.BTmenor);
            this.Controls.Add(this.BTmayor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTmayor;
        private System.Windows.Forms.Button BTmenor;
        private System.Windows.Forms.Button BTacertado;
        private System.Windows.Forms.Label LBinstrucciones;
    }
}

