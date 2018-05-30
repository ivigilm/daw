namespace ej7miniagenda
{
    partial class MiniAgenda
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
            this.TBday = new System.Windows.Forms.TextBox();
            this.TBmonth = new System.Windows.Forms.TextBox();
            this.TByear = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBcontenido
            // 
            this.TBcontenido.Location = new System.Drawing.Point(0, 0);
            this.TBcontenido.Multiline = true;
            this.TBcontenido.Name = "TBcontenido";
            this.TBcontenido.Size = new System.Drawing.Size(607, 319);
            this.TBcontenido.TabIndex = 0;
            this.TBcontenido.TextChanged += new System.EventHandler(this.TBcontenido_TextChanged);
            // 
            // TBday
            // 
            this.TBday.Location = new System.Drawing.Point(35, 357);
            this.TBday.Name = "TBday";
            this.TBday.ReadOnly = true;
            this.TBday.Size = new System.Drawing.Size(100, 22);
            this.TBday.TabIndex = 1;
            this.TBday.Text = "día";
            this.TBday.TextChanged += new System.EventHandler(this.TBday_TextChanged);
            // 
            // TBmonth
            // 
            this.TBmonth.Location = new System.Drawing.Point(239, 357);
            this.TBmonth.Name = "TBmonth";
            this.TBmonth.ReadOnly = true;
            this.TBmonth.Size = new System.Drawing.Size(100, 22);
            this.TBmonth.TabIndex = 2;
            this.TBmonth.Text = "mes";
            this.TBmonth.TextChanged += new System.EventHandler(this.TBmonth_TextChanged);
            // 
            // TByear
            // 
            this.TByear.Location = new System.Drawing.Point(458, 357);
            this.TByear.Name = "TByear";
            this.TByear.ReadOnly = true;
            this.TByear.Size = new System.Drawing.Size(100, 22);
            this.TByear.TabIndex = 3;
            this.TByear.Text = "año";
            this.TByear.TextChanged += new System.EventHandler(this.TByear_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MiniAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 481);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TByear);
            this.Controls.Add(this.TBmonth);
            this.Controls.Add(this.TBday);
            this.Controls.Add(this.TBcontenido);
            this.Name = "MiniAgenda";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MiniAgenda_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBcontenido;
        private System.Windows.Forms.TextBox TBday;
        private System.Windows.Forms.TextBox TBmonth;
        private System.Windows.Forms.TextBox TByear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

