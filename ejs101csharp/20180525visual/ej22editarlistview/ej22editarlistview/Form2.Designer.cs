namespace ej22editarlistview
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTaceptar = new System.Windows.Forms.Button();
            this.LABnif = new System.Windows.Forms.Label();
            this.TBnif = new System.Windows.Forms.TextBox();
            this.LABnombre = new System.Windows.Forms.Label();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.LABapellidos = new System.Windows.Forms.Label();
            this.TBapellidos = new System.Windows.Forms.TextBox();
            this.LABfechaalta = new System.Windows.Forms.Label();
            this.TBfechaalta = new System.Windows.Forms.TextBox();
            this.LABsalario = new System.Windows.Forms.Label();
            this.TBsalario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTaceptar
            // 
            this.BTaceptar.Location = new System.Drawing.Point(83, 259);
            this.BTaceptar.Name = "BTaceptar";
            this.BTaceptar.Size = new System.Drawing.Size(89, 43);
            this.BTaceptar.TabIndex = 5;
            this.BTaceptar.Text = "Aceptar";
            this.BTaceptar.UseVisualStyleBackColor = true;
            this.BTaceptar.Click += new System.EventHandler(this.BTaceptar_Click);
            // 
            // LABnif
            // 
            this.LABnif.AutoSize = true;
            this.LABnif.Location = new System.Drawing.Point(25, 34);
            this.LABnif.Name = "LABnif";
            this.LABnif.Size = new System.Drawing.Size(33, 17);
            this.LABnif.TabIndex = 1;
            this.LABnif.Text = "NIF:";
            // 
            // TBnif
            // 
            this.TBnif.Location = new System.Drawing.Point(142, 31);
            this.TBnif.Name = "TBnif";
            this.TBnif.Size = new System.Drawing.Size(100, 22);
            this.TBnif.TabIndex = 0;
            // 
            // LABnombre
            // 
            this.LABnombre.AutoSize = true;
            this.LABnombre.Location = new System.Drawing.Point(25, 75);
            this.LABnombre.Name = "LABnombre";
            this.LABnombre.Size = new System.Drawing.Size(62, 17);
            this.LABnombre.TabIndex = 1;
            this.LABnombre.Text = "Nombre:";
            // 
            // TBnombre
            // 
            this.TBnombre.Location = new System.Drawing.Point(142, 72);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(100, 22);
            this.TBnombre.TabIndex = 1;
            // 
            // LABapellidos
            // 
            this.LABapellidos.AutoSize = true;
            this.LABapellidos.Location = new System.Drawing.Point(25, 116);
            this.LABapellidos.Name = "LABapellidos";
            this.LABapellidos.Size = new System.Drawing.Size(69, 17);
            this.LABapellidos.TabIndex = 1;
            this.LABapellidos.Text = "Apellidos:";
            // 
            // TBapellidos
            // 
            this.TBapellidos.Location = new System.Drawing.Point(142, 113);
            this.TBapellidos.Name = "TBapellidos";
            this.TBapellidos.Size = new System.Drawing.Size(100, 22);
            this.TBapellidos.TabIndex = 2;
            // 
            // LABfechaalta
            // 
            this.LABfechaalta.AutoSize = true;
            this.LABfechaalta.Location = new System.Drawing.Point(25, 158);
            this.LABfechaalta.Name = "LABfechaalta";
            this.LABfechaalta.Size = new System.Drawing.Size(98, 17);
            this.LABfechaalta.TabIndex = 1;
            this.LABfechaalta.Text = "Fecha de alta:";
            // 
            // TBfechaalta
            // 
            this.TBfechaalta.Location = new System.Drawing.Point(142, 155);
            this.TBfechaalta.Name = "TBfechaalta";
            this.TBfechaalta.Size = new System.Drawing.Size(100, 22);
            this.TBfechaalta.TabIndex = 3;
            this.TBfechaalta.TextChanged += new System.EventHandler(this.TBfechaalta_TextChanged);
            // 
            // LABsalario
            // 
            this.LABsalario.AutoSize = true;
            this.LABsalario.Location = new System.Drawing.Point(25, 203);
            this.LABsalario.Name = "LABsalario";
            this.LABsalario.Size = new System.Drawing.Size(56, 17);
            this.LABsalario.TabIndex = 1;
            this.LABsalario.Text = "Salario:";
            // 
            // TBsalario
            // 
            this.TBsalario.Location = new System.Drawing.Point(142, 200);
            this.TBsalario.Name = "TBsalario";
            this.TBsalario.Size = new System.Drawing.Size(100, 22);
            this.TBsalario.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 330);
            this.Controls.Add(this.TBsalario);
            this.Controls.Add(this.LABsalario);
            this.Controls.Add(this.TBfechaalta);
            this.Controls.Add(this.LABfechaalta);
            this.Controls.Add(this.TBapellidos);
            this.Controls.Add(this.LABapellidos);
            this.Controls.Add(this.TBnombre);
            this.Controls.Add(this.LABnombre);
            this.Controls.Add(this.TBnif);
            this.Controls.Add(this.LABnif);
            this.Controls.Add(this.BTaceptar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTaceptar;
        private System.Windows.Forms.Label LABnif;
        private System.Windows.Forms.TextBox TBnif;
        private System.Windows.Forms.Label LABnombre;
        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.Label LABapellidos;
        private System.Windows.Forms.TextBox TBapellidos;
        private System.Windows.Forms.Label LABfechaalta;
        private System.Windows.Forms.TextBox TBfechaalta;
        private System.Windows.Forms.Label LABsalario;
        private System.Windows.Forms.TextBox TBsalario;
    }
}