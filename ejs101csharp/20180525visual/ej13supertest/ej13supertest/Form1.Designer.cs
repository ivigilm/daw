namespace ej13supertest
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
            this.LABinicio = new System.Windows.Forms.Label();
            this.BTempezar = new System.Windows.Forms.Button();
            this.LABq = new System.Windows.Forms.Label();
            this.RBa1 = new System.Windows.Forms.RadioButton();
            this.RBa2 = new System.Windows.Forms.RadioButton();
            this.RBa3 = new System.Windows.Forms.RadioButton();
            this.BTcontinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LABinicio
            // 
            this.LABinicio.AutoSize = true;
            this.LABinicio.Location = new System.Drawing.Point(39, 94);
            this.LABinicio.Name = "LABinicio";
            this.LABinicio.Size = new System.Drawing.Size(213, 17);
            this.LABinicio.TabIndex = 0;
            this.LABinicio.Text = "Este test consta de 5 preguntas.";
            // 
            // BTempezar
            // 
            this.BTempezar.Location = new System.Drawing.Point(95, 143);
            this.BTempezar.Name = "BTempezar";
            this.BTempezar.Size = new System.Drawing.Size(75, 33);
            this.BTempezar.TabIndex = 1;
            this.BTempezar.Text = "Empezar";
            this.BTempezar.UseVisualStyleBackColor = true;
            this.BTempezar.Click += new System.EventHandler(this.BTempezar_Click);
            // 
            // LABq
            // 
            this.LABq.AutoSize = true;
            this.LABq.Location = new System.Drawing.Point(23, 35);
            this.LABq.Name = "LABq";
            this.LABq.Size = new System.Drawing.Size(215, 17);
            this.LABq.TabIndex = 2;
            this.LABq.Text = "Pregunta 1: ¿Qué significa LAN?";
            this.LABq.Visible = false;
            // 
            // RBa1
            // 
            this.RBa1.AutoSize = true;
            this.RBa1.Location = new System.Drawing.Point(42, 79);
            this.RBa1.Name = "RBa1";
            this.RBa1.Size = new System.Drawing.Size(152, 21);
            this.RBa1.TabIndex = 3;
            this.RBa1.TabStop = true;
            this.RBa1.Text = "Local Area Network";
            this.RBa1.UseVisualStyleBackColor = true;
            this.RBa1.Visible = false;
            this.RBa1.CheckedChanged += new System.EventHandler(this.RBa1_CheckedChanged);
            // 
            // RBa2
            // 
            this.RBa2.AutoSize = true;
            this.RBa2.Location = new System.Drawing.Point(42, 129);
            this.RBa2.Name = "RBa2";
            this.RBa2.Size = new System.Drawing.Size(193, 21);
            this.RBa2.TabIndex = 4;
            this.RBa2.TabStop = true;
            this.RBa2.Text = "Linux Association Network";
            this.RBa2.UseVisualStyleBackColor = true;
            this.RBa2.Visible = false;
            this.RBa2.CheckedChanged += new System.EventHandler(this.RBa2_CheckedChanged);
            // 
            // RBa3
            // 
            this.RBa3.AutoSize = true;
            this.RBa3.Location = new System.Drawing.Point(42, 172);
            this.RBa3.Name = "RBa3";
            this.RBa3.Size = new System.Drawing.Size(194, 21);
            this.RBa3.TabIndex = 5;
            this.RBa3.TabStop = true;
            this.RBa3.Text = "Local Association Network";
            this.RBa3.UseVisualStyleBackColor = true;
            this.RBa3.Visible = false;
            this.RBa3.CheckedChanged += new System.EventHandler(this.RBa3_CheckedChanged);
            // 
            // BTcontinuar
            // 
            this.BTcontinuar.Location = new System.Drawing.Point(95, 211);
            this.BTcontinuar.Name = "BTcontinuar";
            this.BTcontinuar.Size = new System.Drawing.Size(82, 30);
            this.BTcontinuar.TabIndex = 6;
            this.BTcontinuar.Text = "Continuar";
            this.BTcontinuar.UseVisualStyleBackColor = true;
            this.BTcontinuar.Visible = false;
            this.BTcontinuar.Click += new System.EventHandler(this.BTcontinuar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.BTcontinuar);
            this.Controls.Add(this.RBa3);
            this.Controls.Add(this.RBa2);
            this.Controls.Add(this.RBa1);
            this.Controls.Add(this.LABq);
            this.Controls.Add(this.BTempezar);
            this.Controls.Add(this.LABinicio);
            this.Name = "Form1";
            this.Text = "SuperTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABinicio;
        private System.Windows.Forms.Button BTempezar;
        private System.Windows.Forms.Label LABq;
        private System.Windows.Forms.RadioButton RBa1;
        private System.Windows.Forms.RadioButton RBa2;
        private System.Windows.Forms.RadioButton RBa3;
        private System.Windows.Forms.Button BTcontinuar;
    }
}

