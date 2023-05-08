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
    public partial class AddCarreraSede : Form
    {
        public AddCarreraSede()
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
    
        private Boolean validarInputs()
        {
            return false;
        }

        private void AddCarreraSede_Load(object sender, EventArgs e)
        {
            //Llenar los ComboBox

            using (var context = new AppDbContext())
            {
                var Sedes = context.tblSedes.ToList();
                var Carreras = context.tblCarreras.ToList();

                cbSedes.DataSource = Sedes;
                cbCarreras.DataSource = Carreras;

                cbSedes.ValueMember = "Id";
                cbSedes.DisplayMember = "Name";

                cbCarreras.ValueMember = "Id";
                cbCarreras.DisplayMember = "Name";
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
