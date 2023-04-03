namespace AppDesktop
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevaSedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodasLasSedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sedesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sedesToolStripMenuItem
            // 
            this.sedesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevaSedeToolStripMenuItem,
            this.verTodasLasSedesToolStripMenuItem});
            this.sedesToolStripMenuItem.Name = "sedesToolStripMenuItem";
            this.sedesToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.sedesToolStripMenuItem.Text = "Sedes";
            // 
            // agregarNuevaSedeToolStripMenuItem
            // 
            this.agregarNuevaSedeToolStripMenuItem.Name = "agregarNuevaSedeToolStripMenuItem";
            this.agregarNuevaSedeToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.agregarNuevaSedeToolStripMenuItem.Text = "Agregar Nueva Sede";
            this.agregarNuevaSedeToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevaSedeToolStripMenuItem_Click);
            // 
            // verTodasLasSedesToolStripMenuItem
            // 
            this.verTodasLasSedesToolStripMenuItem.Name = "verTodasLasSedesToolStripMenuItem";
            this.verTodasLasSedesToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.verTodasLasSedesToolStripMenuItem.Text = "Ver Todas las Sedes";
            this.verTodasLasSedesToolStripMenuItem.Click += new System.EventHandler(this.verTodasLasSedesToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(29, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sedes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(253, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "Carreras";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sedesToolStripMenuItem;
        private ToolStripMenuItem agregarNuevaSedeToolStripMenuItem;
        private ToolStripMenuItem verTodasLasSedesToolStripMenuItem;
        private Button button1;
        private Button button2;
    }
}