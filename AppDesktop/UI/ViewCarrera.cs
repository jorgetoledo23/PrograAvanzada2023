using AppDesktop.Model;
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
    public partial class ViewCarrera : Form
    {
        public ViewCarrera()
        {
            InitializeComponent();
        }

        private void ViewSede_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var Carreras = context.tblCarreras.ToList();
                foreach (var c in Carreras)
                {
                    var Item = new ListViewItem();
                    Item.Text = c.Name;
                    Item.SubItems.Add(c.Duracion);
                    listViewCarreras.Items.Add(Item);
                }
            }
        }
    }
}
