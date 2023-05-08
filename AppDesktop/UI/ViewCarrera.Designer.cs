namespace AppDesktop
{
    partial class ViewCarrera
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
            this.listViewCarreras = new System.Windows.Forms.ListView();
            this.Nombre = new System.Windows.Forms.ColumnHeader();
            this.Duracion = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listViewCarreras
            // 
            this.listViewCarreras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Duracion});
            this.listViewCarreras.Location = new System.Drawing.Point(12, 12);
            this.listViewCarreras.Name = "listViewCarreras";
            this.listViewCarreras.Size = new System.Drawing.Size(421, 355);
            this.listViewCarreras.TabIndex = 0;
            this.listViewCarreras.UseCompatibleStateImageBehavior = false;
            this.listViewCarreras.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre Carrera";
            this.Nombre.Width = 250;
            // 
            // Duracion
            // 
            this.Duracion.Text = "Duracion";
            this.Duracion.Width = 150;
            // 
            // ViewCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 373);
            this.Controls.Add(this.listViewCarreras);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(615, 497);
            this.MinimizeBox = false;
            this.Name = "ViewCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Carreras";
            this.Load += new System.EventHandler(this.ViewSede_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listViewCarreras;
        private ColumnHeader Nombre;
        private ColumnHeader Duracion;
    }
}