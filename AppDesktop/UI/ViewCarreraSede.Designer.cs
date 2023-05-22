namespace AppDesktop
{
    partial class ViewCarreraSede
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
            this.cbSedes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewCarreras = new System.Windows.Forms.ListView();
            this.Nombre = new System.Windows.Forms.ColumnHeader();
            this.Duracion = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // cbSedes
            // 
            this.cbSedes.FormattingEnabled = true;
            this.cbSedes.Location = new System.Drawing.Point(96, 21);
            this.cbSedes.Name = "cbSedes";
            this.cbSedes.Size = new System.Drawing.Size(458, 28);
            this.cbSedes.TabIndex = 1;
            this.cbSedes.SelectedIndexChanged += new System.EventHandler(this.cbSedes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sede";
            // 
            // listViewCarreras
            // 
            this.listViewCarreras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Duracion});
            this.listViewCarreras.Location = new System.Drawing.Point(28, 83);
            this.listViewCarreras.Name = "listViewCarreras";
            this.listViewCarreras.Size = new System.Drawing.Size(541, 355);
            this.listViewCarreras.TabIndex = 3;
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
            // ViewCarreraSede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.listViewCarreras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSedes);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(615, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(615, 497);
            this.Name = "ViewCarreraSede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewSede";
            this.Load += new System.EventHandler(this.ViewSede_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cbSedes;
        private Label label1;
        private ListView listViewCarreras;
        private ColumnHeader Nombre;
        private ColumnHeader Duracion;
    }
}