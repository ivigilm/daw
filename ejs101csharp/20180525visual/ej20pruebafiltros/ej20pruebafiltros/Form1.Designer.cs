namespace ej20pruebafiltros
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
            this.LABnumerico = new System.Windows.Forms.Label();
            this.TBnumerico = new System.Windows.Forms.TextBox();
            this.LABenteros = new System.Windows.Forms.Label();
            this.TBenteros = new System.Windows.Forms.TextBox();
            this.LABreales = new System.Windows.Forms.Label();
            this.TBreales = new System.Windows.Forms.TextBox();
            this.LABletras = new System.Windows.Forms.Label();
            this.LABalfanumerico = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TBalfanumerico = new System.Windows.Forms.TextBox();
            this.LABNIF = new System.Windows.Forms.Label();
            this.TBNIF = new System.Windows.Forms.TextBox();
            this.LABemail = new System.Windows.Forms.Label();
            this.TBemail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LABnumerico
            // 
            this.LABnumerico.AutoSize = true;
            this.LABnumerico.Location = new System.Drawing.Point(12, 20);
            this.LABnumerico.Name = "LABnumerico";
            this.LABnumerico.Size = new System.Drawing.Size(72, 17);
            this.LABnumerico.TabIndex = 0;
            this.LABnumerico.Text = "Numérico:";
            // 
            // TBnumerico
            // 
            this.TBnumerico.Location = new System.Drawing.Point(168, 20);
            this.TBnumerico.Name = "TBnumerico";
            this.TBnumerico.Size = new System.Drawing.Size(142, 22);
            this.TBnumerico.TabIndex = 1;
            this.TBnumerico.Leave += new System.EventHandler(this.TBnumerico_Leave);
            // 
            // LABenteros
            // 
            this.LABenteros.AutoSize = true;
            this.LABenteros.Location = new System.Drawing.Point(12, 69);
            this.LABenteros.Name = "LABenteros";
            this.LABenteros.Size = new System.Drawing.Size(121, 17);
            this.LABenteros.TabIndex = 2;
            this.LABenteros.Text = "Números enteros:";
            // 
            // TBenteros
            // 
            this.TBenteros.Location = new System.Drawing.Point(168, 69);
            this.TBenteros.Name = "TBenteros";
            this.TBenteros.Size = new System.Drawing.Size(142, 22);
            this.TBenteros.TabIndex = 3;
            this.TBenteros.Leave += new System.EventHandler(this.TBenteros_Leave);
            // 
            // LABreales
            // 
            this.LABreales.AutoSize = true;
            this.LABreales.Location = new System.Drawing.Point(12, 123);
            this.LABreales.Name = "LABreales";
            this.LABreales.Size = new System.Drawing.Size(112, 17);
            this.LABreales.TabIndex = 4;
            this.LABreales.Text = "Números reales:";
            // 
            // TBreales
            // 
            this.TBreales.Location = new System.Drawing.Point(168, 120);
            this.TBreales.Name = "TBreales";
            this.TBreales.Size = new System.Drawing.Size(142, 22);
            this.TBreales.TabIndex = 5;
            this.TBreales.Leave += new System.EventHandler(this.TBreales_Leave);
            // 
            // LABletras
            // 
            this.LABletras.AutoSize = true;
            this.LABletras.Location = new System.Drawing.Point(12, 173);
            this.LABletras.Name = "LABletras";
            this.LABletras.Size = new System.Drawing.Size(52, 17);
            this.LABletras.TabIndex = 6;
            this.LABletras.Text = "Letras:";
            // 
            // LABalfanumerico
            // 
            this.LABalfanumerico.AutoSize = true;
            this.LABalfanumerico.Location = new System.Drawing.Point(12, 226);
            this.LABalfanumerico.Name = "LABalfanumerico";
            this.LABalfanumerico.Size = new System.Drawing.Size(94, 17);
            this.LABalfanumerico.TabIndex = 7;
            this.LABalfanumerico.Text = "Alfanumérico:";
            this.LABalfanumerico.Leave += new System.EventHandler(this.LABalfanumerico_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // TBalfanumerico
            // 
            this.TBalfanumerico.Location = new System.Drawing.Point(168, 223);
            this.TBalfanumerico.Name = "TBalfanumerico";
            this.TBalfanumerico.Size = new System.Drawing.Size(142, 22);
            this.TBalfanumerico.TabIndex = 9;
            // 
            // LABNIF
            // 
            this.LABNIF.AutoSize = true;
            this.LABNIF.Location = new System.Drawing.Point(12, 278);
            this.LABNIF.Name = "LABNIF";
            this.LABNIF.Size = new System.Drawing.Size(33, 17);
            this.LABNIF.TabIndex = 10;
            this.LABNIF.Text = "NIF:";
            // 
            // TBNIF
            // 
            this.TBNIF.Location = new System.Drawing.Point(168, 278);
            this.TBNIF.Name = "TBNIF";
            this.TBNIF.Size = new System.Drawing.Size(142, 22);
            this.TBNIF.TabIndex = 11;
            this.TBNIF.Leave += new System.EventHandler(this.TBNIF_Leave);
            // 
            // LABemail
            // 
            this.LABemail.AutoSize = true;
            this.LABemail.Location = new System.Drawing.Point(12, 331);
            this.LABemail.Name = "LABemail";
            this.LABemail.Size = new System.Drawing.Size(51, 17);
            this.LABemail.TabIndex = 12;
            this.LABemail.Text = "E-mail:";
            // 
            // TBemail
            // 
            this.TBemail.Location = new System.Drawing.Point(112, 328);
            this.TBemail.Name = "TBemail";
            this.TBemail.Size = new System.Drawing.Size(198, 22);
            this.TBemail.TabIndex = 13;
            this.TBemail.Leave += new System.EventHandler(this.TBemail_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 377);
            this.Controls.Add(this.TBemail);
            this.Controls.Add(this.LABemail);
            this.Controls.Add(this.TBNIF);
            this.Controls.Add(this.LABNIF);
            this.Controls.Add(this.TBalfanumerico);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LABalfanumerico);
            this.Controls.Add(this.LABletras);
            this.Controls.Add(this.TBreales);
            this.Controls.Add(this.LABreales);
            this.Controls.Add(this.TBenteros);
            this.Controls.Add(this.LABenteros);
            this.Controls.Add(this.TBnumerico);
            this.Controls.Add(this.LABnumerico);
            this.Name = "Form1";
            this.Text = "Comprobación de inputs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABnumerico;
        private System.Windows.Forms.TextBox TBnumerico;
        private System.Windows.Forms.Label LABenteros;
        private System.Windows.Forms.TextBox TBenteros;
        private System.Windows.Forms.Label LABreales;
        private System.Windows.Forms.TextBox TBreales;
        private System.Windows.Forms.Label LABletras;
        private System.Windows.Forms.Label LABalfanumerico;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TBalfanumerico;
        private System.Windows.Forms.Label LABNIF;
        private System.Windows.Forms.TextBox TBNIF;
        private System.Windows.Forms.Label LABemail;
        private System.Windows.Forms.TextBox TBemail;
    }
}

