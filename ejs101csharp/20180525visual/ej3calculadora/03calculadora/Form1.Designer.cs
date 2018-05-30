namespace _03calculadora
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
            this.TBoperador1 = new System.Windows.Forms.TextBox();
            this.TBoperador2 = new System.Windows.Forms.TextBox();
            this.TBresultado = new System.Windows.Forms.TextBox();
            this.BTsuma = new System.Windows.Forms.Button();
            this.BTresta = new System.Windows.Forms.Button();
            this.BTproducto = new System.Windows.Forms.Button();
            this.BTdivision = new System.Windows.Forms.Button();
            this.LBoperador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBigual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBoperador1
            // 
            this.TBoperador1.Location = new System.Drawing.Point(12, 27);
            this.TBoperador1.Name = "TBoperador1";
            this.TBoperador1.Size = new System.Drawing.Size(100, 22);
            this.TBoperador1.TabIndex = 0;
            // 
            // TBoperador2
            // 
            this.TBoperador2.Location = new System.Drawing.Point(161, 27);
            this.TBoperador2.Name = "TBoperador2";
            this.TBoperador2.Size = new System.Drawing.Size(100, 22);
            this.TBoperador2.TabIndex = 1;
            // 
            // TBresultado
            // 
            this.TBresultado.Location = new System.Drawing.Point(308, 27);
            this.TBresultado.Name = "TBresultado";
            this.TBresultado.Size = new System.Drawing.Size(98, 22);
            this.TBresultado.TabIndex = 2;
            // 
            // BTsuma
            // 
            this.BTsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTsuma.Location = new System.Drawing.Point(12, 83);
            this.BTsuma.Name = "BTsuma";
            this.BTsuma.Size = new System.Drawing.Size(69, 61);
            this.BTsuma.TabIndex = 3;
            this.BTsuma.Text = "+";
            this.BTsuma.UseVisualStyleBackColor = true;
            this.BTsuma.Click += new System.EventHandler(this.BTsuma_Click);
            // 
            // BTresta
            // 
            this.BTresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTresta.Location = new System.Drawing.Point(120, 83);
            this.BTresta.Name = "BTresta";
            this.BTresta.Size = new System.Drawing.Size(75, 61);
            this.BTresta.TabIndex = 4;
            this.BTresta.Text = "-";
            this.BTresta.UseVisualStyleBackColor = true;
            this.BTresta.Click += new System.EventHandler(this.BTresta_Click);
            // 
            // BTproducto
            // 
            this.BTproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTproducto.Location = new System.Drawing.Point(228, 83);
            this.BTproducto.Name = "BTproducto";
            this.BTproducto.Size = new System.Drawing.Size(75, 61);
            this.BTproducto.TabIndex = 5;
            this.BTproducto.Text = "x";
            this.BTproducto.UseVisualStyleBackColor = true;
            this.BTproducto.Click += new System.EventHandler(this.BTproducto_Click);
            // 
            // BTdivision
            // 
            this.BTdivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTdivision.Location = new System.Drawing.Point(331, 83);
            this.BTdivision.Name = "BTdivision";
            this.BTdivision.Size = new System.Drawing.Size(75, 61);
            this.BTdivision.TabIndex = 6;
            this.BTdivision.Text = "/";
            this.BTdivision.UseVisualStyleBackColor = true;
            this.BTdivision.Click += new System.EventHandler(this.BTdivision_Click);
            // 
            // LBoperador
            // 
            this.LBoperador.AutoSize = true;
            this.LBoperador.Location = new System.Drawing.Point(132, 30);
            this.LBoperador.Name = "LBoperador";
            this.LBoperador.Size = new System.Drawing.Size(0, 17);
            this.LBoperador.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 8;
            // 
            // LBigual
            // 
            this.LBigual.AutoSize = true;
            this.LBigual.Location = new System.Drawing.Point(276, 30);
            this.LBigual.Name = "LBigual";
            this.LBigual.Size = new System.Drawing.Size(16, 17);
            this.LBigual.TabIndex = 9;
            this.LBigual.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 167);
            this.Controls.Add(this.LBigual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBoperador);
            this.Controls.Add(this.BTdivision);
            this.Controls.Add(this.BTproducto);
            this.Controls.Add(this.BTresta);
            this.Controls.Add(this.BTsuma);
            this.Controls.Add(this.TBresultado);
            this.Controls.Add(this.TBoperador2);
            this.Controls.Add(this.TBoperador1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBoperador1;
        private System.Windows.Forms.TextBox TBoperador2;
        private System.Windows.Forms.TextBox TBresultado;
        private System.Windows.Forms.Button BTsuma;
        private System.Windows.Forms.Button BTresta;
        private System.Windows.Forms.Button BTproducto;
        private System.Windows.Forms.Button BTdivision;
        private System.Windows.Forms.Label LBoperador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBigual;
    }
}

