﻿namespace AppDesktop
{
    partial class AddSede
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtDir);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtCiudad);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(0, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(116, 246);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(381, 55);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDir
            // 
            this.txtDir.Font = new System.Drawing.Font("Raleway Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDir.Location = new System.Drawing.Point(116, 90);
            this.txtDir.Name = "txtDir";
            this.txtDir.PlaceholderText = "Direccion";
            this.txtDir.Size = new System.Drawing.Size(381, 31);
            this.txtDir.TabIndex = 4;
            this.txtDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Raleway Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCorreo.Location = new System.Drawing.Point(116, 186);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PlaceholderText = "Correo Electronico";
            this.txtCorreo.Size = new System.Drawing.Size(381, 31);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Raleway Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCiudad.Location = new System.Drawing.Point(116, 138);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.PlaceholderText = "Ciudad";
            this.txtCiudad.Size = new System.Drawing.Size(381, 31);
            this.txtCiudad.TabIndex = 2;
            this.txtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Raleway Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(116, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre Sede";
            this.txtNombre.Size = new System.Drawing.Size(381, 31);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 54);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(240, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Agregar SEDE";
            // 
            // AddSede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(414, 383);
            this.Name = "AddSede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Sede";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDir;
        private TextBox txtCorreo;
        private TextBox txtCiudad;
        private TextBox txtNombre;
        private Panel panel1;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnAgregar;
    }
}