using AppDesktop.Model;
using Microsoft.EntityFrameworkCore;
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
    public partial class ViewCarreraSede : Form
    {
        public ViewCarreraSede()
        {
            InitializeComponent();
        }

        private void ViewSede_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var Sedes = context.tblSedes.ToList();
               

                cbSedes.DataSource = Sedes;
                

                cbSedes.ValueMember = "Id";
                cbSedes.DisplayMember = "Name";

            }
        }

        private void cbSedes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSedes.SelectedValue.GetType() == typeof(int))
            {
                listViewCarreras.Items.Clear();
                using (var context = new AppDbContext())
                {
                    int sedeId = (int)cbSedes.SelectedValue;

                    var CarrerasSedes = context.tblCarreraSede.Where(x => x.Sede.Id == sedeId)
                        .Include(x => x.Sede)
                        .Include(x => x.Carrera)
                        .ToList();

                    foreach (var c in CarrerasSedes)
                    {
                        var Item = new ListViewItem();
                        Item.Text = c.Carrera.Name;
                        Item.SubItems.Add(c.Carrera.Duracion);
                        listViewCarreras.Items.Add(Item);
                    }
                }
            }

        }
    }
}
