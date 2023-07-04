namespace AppDesktop
{
    partial class ViewSede
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
            this.listViewSedes = new System.Windows.Forms.ListView();
            this.Nombre = new System.Windows.Forms.ColumnHeader();
            this.Direccion = new System.Windows.Forms.ColumnHeader();
            this.Ciudad = new System.Windows.Forms.ColumnHeader();
            this.Correo = new System.Windows.Forms.ColumnHeader();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // listViewSedes
            // 
            this.listViewSedes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Direccion,
            this.Ciudad,
            this.Correo});
            this.listViewSedes.FullRowSelect = true;
            this.listViewSedes.Location = new System.Drawing.Point(12, 12);
            this.listViewSedes.Name = "listViewSedes";
            this.listViewSedes.Size = new System.Drawing.Size(575, 355);
            this.listViewSedes.TabIndex = 0;
            this.listViewSedes.UseCompatibleStateImageBehavior = false;
            this.listViewSedes.View = System.Windows.Forms.View.Details;
            this.listViewSedes.SelectedIndexChanged += new System.EventHandler(this.listViewSedes_SelectedIndexChanged);
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre Sede";
            this.Nombre.Width = 150;
            // 
            // Direccion
            // 
            this.Direccion.Text = "Direccion";
            this.Direccion.Width = 150;
            // 
            // Ciudad
            // 
            this.Ciudad.Text = "Ciudad";
            this.Ciudad.Width = 100;
            // 
            // Correo
            // 
            this.Correo.Text = "Correo";
            this.Correo.Width = 150;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(374, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(211, 56);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ViewSede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listViewSedes);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(615, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(615, 497);
            this.Name = "ViewSede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewSede";
            this.Load += new System.EventHandler(this.ViewSede_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listViewSedes;
        private ColumnHeader Nombre;
        private ColumnHeader Direccion;
        private ColumnHeader Ciudad;
        private ColumnHeader Correo;
        private FontAwesome.Sharp.IconButton btnDelete;
    }
}