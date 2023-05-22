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
            try
            {

                //validar que no esten vinculadas
                using (var context = new AppDbContext())
                {
                    CarreraSede cs = new CarreraSede();
                    cs.CarreraId = (int)cbCarreras.SelectedValue;
                    cs.SedeId = (int)cbSedes.SelectedValue;


                    var existeVinculo = context.tblCarreraSede
                        .Where(x => x.SedeId == cs.SedeId && x.CarreraId == cs.CarreraId)
                        .FirstOrDefault();

                    if (existeVinculo != null)
                    {
                        MessageBox.Show("Sede y Carrera ya estan Vinculados!");
                        
                    }
                    else
                    {
                        context.Add(cs);
                        context.SaveChanges();

                        MessageBox
                                .Show("Carrera Agregada a la Sede"
                                , "Informacion"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                        this.Close();
                    }

                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

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
    }
}
