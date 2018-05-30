namespace ej11generadordados
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
            this.NUDdados = new System.Windows.Forms.NumericUpDown();
            this.NUDcaras = new System.Windows.Forms.NumericUpDown();
            this.LABnumdados = new System.Windows.Forms.Label();
            this.LABnumcaras = new System.Windows.Forms.Label();
            this.BTtirar = new System.Windows.Forms.Button();
            this.LBtiradas = new System.Windows.Forms.ListBox();
            this.TBsuma = new System.Windows.Forms.TextBox();
            this.LABsuma = new System.Windows.Forms.Label();
            this.LABtiradas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDdados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDcaras)).BeginInit();
            this.SuspendLayout();
            // 
            // NUDdados
            // 
            this.NUDdados.Location = new System.Drawing.Point(278, 21);
            this.NUDdados.Name = "NUDdados";
            this.NUDdados.Size = new System.Drawing.Size(50, 22);
            this.NUDdados.TabIndex = 0;
            // 
            // NUDcaras
            // 
            this.NUDcaras.Location = new System.Drawing.Point(278, 61);
            this.NUDcaras.Name = "NUDcaras";
            this.NUDcaras.Size = new System.Drawing.Size(50, 22);
            this.NUDcaras.TabIndex = 1;
            // 
            // LABnumdados
            // 
            this.LABnumdados.AutoSize = true;
            this.LABnumdados.Location = new System.Drawing.Point(12, 23);
            this.LABnumdados.Name = "LABnumdados";
            this.LABnumdados.Size = new System.Drawing.Size(199, 17);
            this.LABnumdados.TabIndex = 2;
            this.LABnumdados.Text = "¿Cuántos dados quieres tirar?";
            // 
            // LABnumcaras
            // 
            this.LABnumcaras.AutoSize = true;
            this.LABnumcaras.Location = new System.Drawing.Point(12, 61);
            this.LABnumcaras.Name = "LABnumcaras";
            this.LABnumcaras.Size = new System.Drawing.Size(201, 17);
            this.LABnumcaras.TabIndex = 3;
            this.LABnumcaras.Text = "¿Cuántas caras tiene el dado?";
            // 
            // BTtirar
            // 
            this.BTtirar.Location = new System.Drawing.Point(253, 106);
            this.BTtirar.Name = "BTtirar";
            this.BTtirar.Size = new System.Drawing.Size(75, 23);
            this.BTtirar.TabIndex = 4;
            this.BTtirar.Text = "Tirar";
            this.BTtirar.UseVisualStyleBackColor = true;
            this.BTtirar.Click += new System.EventHandler(this.BTtirar_Click);
            // 
            // LBtiradas
            // 
            this.LBtiradas.FormattingEnabled = true;
            this.LBtiradas.ItemHeight = 16;
            this.LBtiradas.Location = new System.Drawing.Point(12, 195);
            this.LBtiradas.Name = "LBtiradas";
            this.LBtiradas.Size = new System.Drawing.Size(120, 84);
            this.LBtiradas.TabIndex = 5;
            // 
            // TBsuma
            // 
            this.TBsuma.Location = new System.Drawing.Point(267, 262);
            this.TBsuma.Name = "TBsuma";
            this.TBsuma.Size = new System.Drawing.Size(61, 22);
            this.TBsuma.TabIndex = 6;
            // 
            // LABsuma
            // 
            this.LABsuma.AutoSize = true;
            this.LABsuma.Location = new System.Drawing.Point(155, 262);
            this.LABsuma.Name = "LABsuma";
            this.LABsuma.Size = new System.Drawing.Size(95, 17);
            this.LABsuma.TabIndex = 7;
            this.LABsuma.Text = "Suma tiradas:";
            // 
            // LABtiradas
            // 
            this.LABtiradas.AutoSize = true;
            this.LABtiradas.Location = new System.Drawing.Point(12, 164);
            this.LABtiradas.Name = "LABtiradas";
            this.LABtiradas.Size = new System.Drawing.Size(60, 17);
            this.LABtiradas.TabIndex = 8;
            this.LABtiradas.Text = "Tiradas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 296);
            this.Controls.Add(this.LABtiradas);
            this.Controls.Add(this.LABsuma);
            this.Controls.Add(this.TBsuma);
            this.Controls.Add(this.LBtiradas);
            this.Controls.Add(this.BTtirar);
            this.Controls.Add(this.LABnumcaras);
            this.Controls.Add(this.LABnumdados);
            this.Controls.Add(this.NUDcaras);
            this.Controls.Add(this.NUDdados);
            this.Name = "Form1";
            this.Text = "Generador de dados";
            ((System.ComponentModel.ISupportInitialize)(this.NUDdados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDcaras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUDdados;
        private System.Windows.Forms.NumericUpDown NUDcaras;
        private System.Windows.Forms.Label LABnumdados;
        private System.Windows.Forms.Label LABnumcaras;
        private System.Windows.Forms.Button BTtirar;
        private System.Windows.Forms.ListBox LBtiradas;
        private System.Windows.Forms.TextBox TBsuma;
        private System.Windows.Forms.Label LABsuma;
        private System.Windows.Forms.Label LABtiradas;
    }
}

