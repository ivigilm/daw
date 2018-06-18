namespace ej22editarlistview
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
            this.colnif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colnombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colapellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colfechaalta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colsalario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTnuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colnif,
            this.colnombre,
            this.colapellidos,
            this.colfechaalta,
            this.colsalario});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(536, 260);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colnif
            // 
            this.colnif.Text = "NIF";
            this.colnif.Width = 100;
            // 
            // colnombre
            // 
            this.colnombre.Text = "Nombre";
            this.colnombre.Width = 100;
            // 
            // colapellidos
            // 
            this.colapellidos.Text = "Apellidos";
            this.colapellidos.Width = 150;
            // 
            // colfechaalta
            // 
            this.colfechaalta.Text = "Fecha de alta";
            this.colfechaalta.Width = 100;
            // 
            // colsalario
            // 
            this.colsalario.Text = "Salario";
            this.colsalario.Width = 80;
            // 
            // BTnuevo
            // 
            this.BTnuevo.Location = new System.Drawing.Point(221, 280);
            this.BTnuevo.Name = "BTnuevo";
            this.BTnuevo.Size = new System.Drawing.Size(75, 44);
            this.BTnuevo.TabIndex = 1;
            this.BTnuevo.Text = "Nuevo";
            this.BTnuevo.UseVisualStyleBackColor = true;
            this.BTnuevo.Click += new System.EventHandler(this.BTnuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 346);
            this.Controls.Add(this.BTnuevo);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colnif;
        private System.Windows.Forms.ColumnHeader colnombre;
        private System.Windows.Forms.ColumnHeader colapellidos;
        private System.Windows.Forms.ColumnHeader colfechaalta;
        private System.Windows.Forms.ColumnHeader colsalario;
        private System.Windows.Forms.Button BTnuevo;
    }
}

