using AppDesktop.Model;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class AddSede : Form
    {
        public AddSede()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validarInputs())
            {
                MessageBox.Show("Todos los campos son Obligatorios!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (var context = new AppDbContext())
                    {
                        Sede nuevaSede = new Sede()
                        {
                            Name = txtNombre.Text,
                            Direccion = txtDir.Text,
                            Email = txtCorreo.Text,
                            Ciudad = txtCiudad.Text
                        };
                        context.Add(nuevaSede);
                        context.SaveChanges();

                        MessageBox
                                .Show("Sede Agregada"
                                , "Informacion"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                        this.Close();

                    }
                }

                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            

        }
    
        private bool validarInputs()
        {
            if (txtDir.Text.IsNullOrEmpty()
                || txtNombre.Text.IsNullOrEmpty()
                || txtCiudad.Text.IsNullOrEmpty()
                || txtCorreo.Text.IsNullOrEmpty())
            {
                return false;
            }
            else return true;
        }
    }
}
