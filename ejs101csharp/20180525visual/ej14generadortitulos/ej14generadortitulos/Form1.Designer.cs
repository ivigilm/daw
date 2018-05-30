namespace ej14generadortitulos
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
            this.CBlista1 = new System.Windows.Forms.ComboBox();
            this.CBlista2 = new System.Windows.Forms.ComboBox();
            this.BTejecutar = new System.Windows.Forms.Button();
            this.BTrandom = new System.Windows.Forms.Button();
            this.LABtitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBlista1
            // 
            this.CBlista1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBlista1.FormattingEnabled = true;
            this.CBlista1.Location = new System.Drawing.Point(49, 75);
            this.CBlista1.Name = "CBlista1";
            this.CBlista1.Size = new System.Drawing.Size(121, 24);
            this.CBlista1.TabIndex = 0;
            // 
            // CBlista2
            // 
            this.CBlista2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBlista2.FormattingEnabled = true;
            this.CBlista2.Location = new System.Drawing.Point(246, 75);
            this.CBlista2.Name = "CBlista2";
            this.CBlista2.Size = new System.Drawing.Size(121, 24);
            this.CBlista2.TabIndex = 1;
            // 
            // BTejecutar
            // 
            this.BTejecutar.Location = new System.Drawing.Point(87, 133);
            this.BTejecutar.Name = "BTejecutar";
            this.BTejecutar.Size = new System.Drawing.Size(103, 34);
            this.BTejecutar.TabIndex = 2;
            this.BTejecutar.Text = "Mi selección";
            this.BTejecutar.UseVisualStyleBackColor = true;
            this.BTejecutar.Click += new System.EventHandler(this.BTejecutar_Click);
            // 
            // BTrandom
            // 
            this.BTrandom.Location = new System.Drawing.Point(232, 133);
            this.BTrandom.Name = "BTrandom";
            this.BTrandom.Size = new System.Drawing.Size(82, 34);
            this.BTrandom.TabIndex = 3;
            this.BTrandom.Text = "Aleatorio";
            this.BTrandom.UseVisualStyleBackColor = true;
            this.BTrandom.Click += new System.EventHandler(this.BTrandom_Click);
            // 
            // LABtitulo
            // 
            this.LABtitulo.AutoSize = true;
            this.LABtitulo.Location = new System.Drawing.Point(157, 29);
            this.LABtitulo.Name = "LABtitulo";
            this.LABtitulo.Size = new System.Drawing.Size(111, 17);
            this.LABtitulo.TabIndex = 4;
            this.LABtitulo.Text = "Elige tu película.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 203);
            this.Controls.Add(this.LABtitulo);
            this.Controls.Add(this.BTrandom);
            this.Controls.Add(this.BTejecutar);
            this.Controls.Add(this.CBlista2);
            this.Controls.Add(this.CBlista1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBlista1;
        private System.Windows.Forms.ComboBox CBlista2;
        private System.Windows.Forms.Button BTejecutar;
        private System.Windows.Forms.Button BTrandom;
        private System.Windows.Forms.Label LABtitulo;
    }
}

