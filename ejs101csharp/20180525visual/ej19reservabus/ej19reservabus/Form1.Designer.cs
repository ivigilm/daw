namespace ej19reservabus
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
            this.Reserva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Asientos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TBnombrereserva = new System.Windows.Forms.TextBox();
            this.LBnombrereserva = new System.Windows.Forms.Label();
            this.BTguardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Reserva,
            this.Asientos});
            this.listView1.Location = new System.Drawing.Point(370, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(205, 186);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Reserva
            // 
            this.Reserva.Text = "Reserva";
            this.Reserva.Width = 89;
            // 
            // Asientos
            // 
            this.Asientos.Text = "Asientos";
            this.Asientos.Width = 123;
            // 
            // TBnombrereserva
            // 
            this.TBnombrereserva.Location = new System.Drawing.Point(506, 22);
            this.TBnombrereserva.Name = "TBnombrereserva";
            this.TBnombrereserva.Size = new System.Drawing.Size(100, 22);
            this.TBnombrereserva.TabIndex = 1;
            // 
            // LBnombrereserva
            // 
            this.LBnombrereserva.AutoSize = true;
            this.LBnombrereserva.Location = new System.Drawing.Point(341, 25);
            this.LBnombrereserva.Name = "LBnombrereserva";
            this.LBnombrereserva.Size = new System.Drawing.Size(149, 17);
            this.LBnombrereserva.TabIndex = 2;
            this.LBnombrereserva.Text = "Nombre de la reserva:";
            // 
            // BTguardar
            // 
            this.BTguardar.Enabled = false;
            this.BTguardar.Location = new System.Drawing.Point(500, 283);
            this.BTguardar.Name = "BTguardar";
            this.BTguardar.Size = new System.Drawing.Size(75, 31);
            this.BTguardar.TabIndex = 3;
            this.BTguardar.Text = "Guardar";
            this.BTguardar.UseVisualStyleBackColor = true;
            this.BTguardar.Click += new System.EventHandler(this.BTguardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 1003);
            this.Controls.Add(this.BTguardar);
            this.Controls.Add(this.LBnombrereserva);
            this.Controls.Add(this.TBnombrereserva);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "ALSA: reserva de billetes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox TBnombrereserva;
        private System.Windows.Forms.Label LBnombrereserva;
        private System.Windows.Forms.Button BTguardar;
        private System.Windows.Forms.ColumnHeader Reserva;
        private System.Windows.Forms.ColumnHeader Asientos;
    }
}

