namespace ej16peqbasedatos
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorpelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.raza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.peso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tamano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorojos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.LABnombre = new System.Windows.Forms.Label();
            this.LABcolorpelo = new System.Windows.Forms.Label();
            this.TBcolorpelo = new System.Windows.Forms.TextBox();
            this.LABraza = new System.Windows.Forms.Label();
            this.TBraza = new System.Windows.Forms.TextBox();
            this.LABpeso = new System.Windows.Forms.Label();
            this.TBpeso = new System.Windows.Forms.TextBox();
            this.LABtamano = new System.Windows.Forms.Label();
            this.TBtamano = new System.Windows.Forms.TextBox();
            this.LABcolorojos = new System.Windows.Forms.Label();
            this.TBcolorojos = new System.Windows.Forms.TextBox();
            this.BTnuevo = new System.Windows.Forms.Button();
            this.BTguardar = new System.Windows.Forms.Button();
            this.BTborrar = new System.Windows.Forms.Button();
            this.BTmodificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombre,
            this.colorpelo,
            this.raza,
            this.peso,
            this.tamano,
            this.colorojos});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(515, 339);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 73;
            // 
            // colorpelo
            // 
            this.colorpelo.Text = "Color de pelo";
            this.colorpelo.Width = 98;
            // 
            // raza
            // 
            this.raza.Text = "Raza";
            this.raza.Width = 91;
            // 
            // peso
            // 
            this.peso.Text = "Peso";
            this.peso.Width = 72;
            // 
            // tamano
            // 
            this.tamano.Text = "Tamaño";
            this.tamano.Width = 79;
            // 
            // colorojos
            // 
            this.colorojos.Text = "Color de ojos";
            this.colorojos.Width = 99;
            // 
            // TBnombre
            // 
            this.TBnombre.Location = new System.Drawing.Point(535, 37);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(100, 22);
            this.TBnombre.TabIndex = 1;
            // 
            // LABnombre
            // 
            this.LABnombre.AutoSize = true;
            this.LABnombre.Location = new System.Drawing.Point(532, 9);
            this.LABnombre.Name = "LABnombre";
            this.LABnombre.Size = new System.Drawing.Size(62, 17);
            this.LABnombre.TabIndex = 2;
            this.LABnombre.Text = "Nombre:";
            // 
            // LABcolorpelo
            // 
            this.LABcolorpelo.AutoSize = true;
            this.LABcolorpelo.Location = new System.Drawing.Point(532, 77);
            this.LABcolorpelo.Name = "LABcolorpelo";
            this.LABcolorpelo.Size = new System.Drawing.Size(96, 17);
            this.LABcolorpelo.TabIndex = 3;
            this.LABcolorpelo.Text = "Color de pelo:";
            // 
            // TBcolorpelo
            // 
            this.TBcolorpelo.Location = new System.Drawing.Point(535, 106);
            this.TBcolorpelo.Name = "TBcolorpelo";
            this.TBcolorpelo.Size = new System.Drawing.Size(100, 22);
            this.TBcolorpelo.TabIndex = 4;
            // 
            // LABraza
            // 
            this.LABraza.AutoSize = true;
            this.LABraza.Location = new System.Drawing.Point(532, 145);
            this.LABraza.Name = "LABraza";
            this.LABraza.Size = new System.Drawing.Size(45, 17);
            this.LABraza.TabIndex = 5;
            this.LABraza.Text = "Raza:";
            // 
            // TBraza
            // 
            this.TBraza.Location = new System.Drawing.Point(535, 174);
            this.TBraza.Name = "TBraza";
            this.TBraza.Size = new System.Drawing.Size(100, 22);
            this.TBraza.TabIndex = 6;
            // 
            // LABpeso
            // 
            this.LABpeso.AutoSize = true;
            this.LABpeso.Location = new System.Drawing.Point(533, 216);
            this.LABpeso.Name = "LABpeso";
            this.LABpeso.Size = new System.Drawing.Size(44, 17);
            this.LABpeso.TabIndex = 7;
            this.LABpeso.Text = "Peso:";
            // 
            // TBpeso
            // 
            this.TBpeso.Location = new System.Drawing.Point(535, 245);
            this.TBpeso.Name = "TBpeso";
            this.TBpeso.Size = new System.Drawing.Size(100, 22);
            this.TBpeso.TabIndex = 8;
            // 
            // LABtamano
            // 
            this.LABtamano.AutoSize = true;
            this.LABtamano.Location = new System.Drawing.Point(532, 286);
            this.LABtamano.Name = "LABtamano";
            this.LABtamano.Size = new System.Drawing.Size(64, 17);
            this.LABtamano.TabIndex = 9;
            this.LABtamano.Text = "Tamaño:";
            // 
            // TBtamano
            // 
            this.TBtamano.Location = new System.Drawing.Point(535, 317);
            this.TBtamano.Name = "TBtamano";
            this.TBtamano.Size = new System.Drawing.Size(100, 22);
            this.TBtamano.TabIndex = 10;
            // 
            // LABcolorojos
            // 
            this.LABcolorojos.AutoSize = true;
            this.LABcolorojos.Location = new System.Drawing.Point(532, 359);
            this.LABcolorojos.Name = "LABcolorojos";
            this.LABcolorojos.Size = new System.Drawing.Size(95, 17);
            this.LABcolorojos.TabIndex = 11;
            this.LABcolorojos.Text = "Color de ojos:";
            // 
            // TBcolorojos
            // 
            this.TBcolorojos.Location = new System.Drawing.Point(535, 391);
            this.TBcolorojos.Name = "TBcolorojos";
            this.TBcolorojos.Size = new System.Drawing.Size(100, 22);
            this.TBcolorojos.TabIndex = 12;
            // 
            // BTnuevo
            // 
            this.BTnuevo.Location = new System.Drawing.Point(38, 375);
            this.BTnuevo.Name = "BTnuevo";
            this.BTnuevo.Size = new System.Drawing.Size(75, 38);
            this.BTnuevo.TabIndex = 13;
            this.BTnuevo.Text = "Nuevo";
            this.BTnuevo.UseVisualStyleBackColor = true;
            this.BTnuevo.Click += new System.EventHandler(this.BTnuevo_Click);
            // 
            // BTguardar
            // 
            this.BTguardar.Location = new System.Drawing.Point(286, 375);
            this.BTguardar.Name = "BTguardar";
            this.BTguardar.Size = new System.Drawing.Size(75, 38);
            this.BTguardar.TabIndex = 14;
            this.BTguardar.Text = "Guardar";
            this.BTguardar.UseVisualStyleBackColor = true;
            this.BTguardar.Click += new System.EventHandler(this.BTguardar_Click);
            // 
            // BTborrar
            // 
            this.BTborrar.Enabled = false;
            this.BTborrar.Location = new System.Drawing.Point(410, 375);
            this.BTborrar.Name = "BTborrar";
            this.BTborrar.Size = new System.Drawing.Size(75, 38);
            this.BTborrar.TabIndex = 15;
            this.BTborrar.Text = "Borrar";
            this.BTborrar.UseVisualStyleBackColor = true;
            this.BTborrar.Click += new System.EventHandler(this.BTborrar_Click);
            // 
            // BTmodificar
            // 
            this.BTmodificar.Enabled = false;
            this.BTmodificar.Location = new System.Drawing.Point(160, 375);
            this.BTmodificar.Name = "BTmodificar";
            this.BTmodificar.Size = new System.Drawing.Size(75, 38);
            this.BTmodificar.TabIndex = 16;
            this.BTmodificar.Text = "Modificar";
            this.BTmodificar.UseVisualStyleBackColor = true;
            this.BTmodificar.Click += new System.EventHandler(this.BTmodificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.BTmodificar);
            this.Controls.Add(this.BTborrar);
            this.Controls.Add(this.BTguardar);
            this.Controls.Add(this.BTnuevo);
            this.Controls.Add(this.TBcolorojos);
            this.Controls.Add(this.LABcolorojos);
            this.Controls.Add(this.TBtamano);
            this.Controls.Add(this.LABtamano);
            this.Controls.Add(this.TBpeso);
            this.Controls.Add(this.LABpeso);
            this.Controls.Add(this.TBraza);
            this.Controls.Add(this.LABraza);
            this.Controls.Add(this.TBcolorpelo);
            this.Controls.Add(this.LABcolorpelo);
            this.Controls.Add(this.LABnombre);
            this.Controls.Add(this.TBnombre);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Gatos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader colorpelo;
        private System.Windows.Forms.ColumnHeader raza;
        private System.Windows.Forms.ColumnHeader peso;
        private System.Windows.Forms.ColumnHeader tamano;
        private System.Windows.Forms.ColumnHeader colorojos;
        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.Label LABnombre;
        private System.Windows.Forms.Label LABcolorpelo;
        private System.Windows.Forms.TextBox TBcolorpelo;
        private System.Windows.Forms.Label LABraza;
        private System.Windows.Forms.TextBox TBraza;
        private System.Windows.Forms.Label LABpeso;
        private System.Windows.Forms.TextBox TBpeso;
        private System.Windows.Forms.Label LABtamano;
        private System.Windows.Forms.TextBox TBtamano;
        private System.Windows.Forms.Label LABcolorojos;
        private System.Windows.Forms.TextBox TBcolorojos;
        private System.Windows.Forms.Button BTnuevo;
        private System.Windows.Forms.Button BTguardar;
        private System.Windows.Forms.Button BTborrar;
        private System.Windows.Forms.Button BTmodificar;
    }
}

