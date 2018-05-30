namespace ej12multiconversor
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
            this.TBvoriginal = new System.Windows.Forms.TextBox();
            this.LABvoriginal = new System.Windows.Forms.Label();
            this.TBresultado = new System.Windows.Forms.TextBox();
            this.LABresultado = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.RBTbstoml = new System.Windows.Forms.RadioButton();
            this.RBfloztoml = new System.Windows.Forms.RadioButton();
            this.RBmltofloz = new System.Windows.Forms.RadioButton();
            this.RBmltoTbsp = new System.Windows.Forms.RadioButton();
            this.RBmltotsp = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TBvoriginal
            // 
            this.TBvoriginal.Location = new System.Drawing.Point(198, 218);
            this.TBvoriginal.Name = "TBvoriginal";
            this.TBvoriginal.Size = new System.Drawing.Size(100, 22);
            this.TBvoriginal.TabIndex = 0;
            this.TBvoriginal.TextChanged += new System.EventHandler(this.TBvoriginal_TextChanged);
            // 
            // LABvoriginal
            // 
            this.LABvoriginal.AutoSize = true;
            this.LABvoriginal.Location = new System.Drawing.Point(22, 221);
            this.LABvoriginal.Name = "LABvoriginal";
            this.LABvoriginal.Size = new System.Drawing.Size(119, 17);
            this.LABvoriginal.TabIndex = 1;
            this.LABvoriginal.Text = "Valor ud. original:";
            // 
            // TBresultado
            // 
            this.TBresultado.Enabled = false;
            this.TBresultado.Location = new System.Drawing.Point(198, 265);
            this.TBresultado.Name = "TBresultado";
            this.TBresultado.Size = new System.Drawing.Size(100, 22);
            this.TBresultado.TabIndex = 2;
            this.TBresultado.TextChanged += new System.EventHandler(this.TBresultado_TextChanged);
            // 
            // LABresultado
            // 
            this.LABresultado.AutoSize = true;
            this.LABresultado.Location = new System.Drawing.Point(22, 268);
            this.LABresultado.Name = "LABresultado";
            this.LABresultado.Size = new System.Drawing.Size(136, 17);
            this.LABresultado.TabIndex = 3;
            this.LABresultado.Text = "Valor ud. resultante:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(31, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 21);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "tsp -> ml";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RBTbstoml
            // 
            this.RBTbstoml.AutoSize = true;
            this.RBTbstoml.Location = new System.Drawing.Point(31, 83);
            this.RBTbstoml.Name = "RBTbstoml";
            this.RBTbstoml.Size = new System.Drawing.Size(96, 21);
            this.RBTbstoml.TabIndex = 5;
            this.RBTbstoml.TabStop = true;
            this.RBTbstoml.Text = "Tbsp -> ml";
            this.RBTbstoml.UseVisualStyleBackColor = true;
            this.RBTbstoml.CheckedChanged += new System.EventHandler(this.RBTbstoml_CheckedChanged);
            // 
            // RBfloztoml
            // 
            this.RBfloztoml.AutoSize = true;
            this.RBfloztoml.Location = new System.Drawing.Point(31, 131);
            this.RBfloztoml.Name = "RBfloztoml";
            this.RBfloztoml.Size = new System.Drawing.Size(90, 21);
            this.RBfloztoml.TabIndex = 6;
            this.RBfloztoml.TabStop = true;
            this.RBfloztoml.Text = "fl oz -> ml";
            this.RBfloztoml.UseVisualStyleBackColor = true;
            this.RBfloztoml.CheckedChanged += new System.EventHandler(this.RBfloztoml_CheckedChanged);
            // 
            // RBmltofloz
            // 
            this.RBmltofloz.AutoSize = true;
            this.RBmltofloz.Location = new System.Drawing.Point(188, 131);
            this.RBmltofloz.Name = "RBmltofloz";
            this.RBmltofloz.Size = new System.Drawing.Size(90, 21);
            this.RBmltofloz.TabIndex = 7;
            this.RBmltofloz.TabStop = true;
            this.RBmltofloz.Text = "ml -> fl oz";
            this.RBmltofloz.UseVisualStyleBackColor = true;
            this.RBmltofloz.CheckedChanged += new System.EventHandler(this.RBmltofloz_CheckedChanged);
            // 
            // RBmltoTbsp
            // 
            this.RBmltoTbsp.AutoSize = true;
            this.RBmltoTbsp.Location = new System.Drawing.Point(188, 83);
            this.RBmltoTbsp.Name = "RBmltoTbsp";
            this.RBmltoTbsp.Size = new System.Drawing.Size(96, 21);
            this.RBmltoTbsp.TabIndex = 8;
            this.RBmltoTbsp.TabStop = true;
            this.RBmltoTbsp.Text = "ml -> Tbsp";
            this.RBmltoTbsp.UseVisualStyleBackColor = true;
            this.RBmltoTbsp.CheckedChanged += new System.EventHandler(this.RBmltoTbsp_CheckedChanged);
            // 
            // RBmltotsp
            // 
            this.RBmltotsp.AutoSize = true;
            this.RBmltotsp.Location = new System.Drawing.Point(188, 39);
            this.RBmltotsp.Name = "RBmltotsp";
            this.RBmltotsp.Size = new System.Drawing.Size(83, 21);
            this.RBmltotsp.TabIndex = 9;
            this.RBmltotsp.TabStop = true;
            this.RBmltotsp.Text = "ml -> tsp";
            this.RBmltotsp.UseVisualStyleBackColor = true;
            this.RBmltotsp.CheckedChanged += new System.EventHandler(this.RBmltotsp_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 316);
            this.Controls.Add(this.RBmltotsp);
            this.Controls.Add(this.RBmltoTbsp);
            this.Controls.Add(this.RBmltofloz);
            this.Controls.Add(this.RBfloztoml);
            this.Controls.Add(this.RBTbstoml);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.LABresultado);
            this.Controls.Add(this.TBresultado);
            this.Controls.Add(this.LABvoriginal);
            this.Controls.Add(this.TBvoriginal);
            this.Name = "Form1";
            this.Text = "Multiconversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBvoriginal;
        private System.Windows.Forms.Label LABvoriginal;
        private System.Windows.Forms.TextBox TBresultado;
        private System.Windows.Forms.Label LABresultado;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton RBTbstoml;
        private System.Windows.Forms.RadioButton RBfloztoml;
        private System.Windows.Forms.RadioButton RBmltofloz;
        private System.Windows.Forms.RadioButton RBmltoTbsp;
        private System.Windows.Forms.RadioButton RBmltotsp;
    }
}

