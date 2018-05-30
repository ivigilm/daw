namespace ej15leelistacsv
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
            this.BTcargar = new System.Windows.Forms.Button();
            this.TBcargar = new System.Windows.Forms.TextBox();
            this.LBficherocargado = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BTcargar
            // 
            this.BTcargar.Enabled = false;
            this.BTcargar.Location = new System.Drawing.Point(187, 385);
            this.BTcargar.Name = "BTcargar";
            this.BTcargar.Size = new System.Drawing.Size(75, 37);
            this.BTcargar.TabIndex = 0;
            this.BTcargar.Text = "Cargar";
            this.BTcargar.UseVisualStyleBackColor = true;
            this.BTcargar.Click += new System.EventHandler(this.BTcargar_Click);
            // 
            // TBcargar
            // 
            this.TBcargar.Location = new System.Drawing.Point(12, 392);
            this.TBcargar.Name = "TBcargar";
            this.TBcargar.Size = new System.Drawing.Size(137, 22);
            this.TBcargar.TabIndex = 1;
            this.TBcargar.TextChanged += new System.EventHandler(this.TBcargar_TextChanged);
            // 
            // LBficherocargado
            // 
            this.LBficherocargado.Location = new System.Drawing.Point(12, 12);
            this.LBficherocargado.Name = "LBficherocargado";
            this.LBficherocargado.Size = new System.Drawing.Size(387, 343);
            this.LBficherocargado.TabIndex = 2;
            this.LBficherocargado.UseCompatibleStateImageBehavior = false;
            this.LBficherocargado.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 436);
            this.Controls.Add(this.LBficherocargado);
            this.Controls.Add(this.TBcargar);
            this.Controls.Add(this.BTcargar);
            this.Name = "Form1";
            this.Text = "Visualización de archivos CSV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTcargar;
        private System.Windows.Forms.TextBox TBcargar;
        private System.Windows.Forms.ListView LBficherocargado;
    }
}

