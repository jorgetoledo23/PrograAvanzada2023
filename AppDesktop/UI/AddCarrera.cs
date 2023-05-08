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
    public partial class AddCarrera : Form
    {
        public AddCarrera()
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
                        Carrera nuevaCarrera = new Carrera()
                        {
                            Name = txtNombre.Text,
                            Duracion = txtDuracion.Text,

                        };
                        context.Add(nuevaCarrera);
                        context.SaveChanges();

                        MessageBox
                                .Show("Carrera Agregada"
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
            if (txtDuracion.Text.IsNullOrEmpty()
                || txtNombre.Text.IsNullOrEmpty())
            {
                return false;
            }
            else return true;
        }
    }
}
