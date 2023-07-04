﻿using AppDesktop.Model;
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
    public partial class ViewSede : Form
    {
        public ViewSede()
        {
            InitializeComponent();
        }

        private void ViewSede_Load(object sender, EventArgs e)
        {
            llenarLista();
        }

        private void listViewSedes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var sedeName = listViewSedes.SelectedItems[0].Text;
                var sede = context.tblSedes.FirstOrDefault(x => x.Name.Equals(sedeName));
                context.Remove(sede);
                context.SaveChanges();
                llenarLista();
            }
        }

        void llenarLista()
        {
            listViewSedes.Items.Clear();
            using (var context = new AppDbContext())
            {
                var Sedes = context.tblSedes.ToList();
                foreach (var sede in Sedes)
                {
                    var Item = new ListViewItem();
                    Item.Text = sede.Name;
                    Item.SubItems.Add(sede.Direccion);
                    Item.SubItems.Add(sede.Ciudad);
                    Item.SubItems.Add(sede.Email);
                    listViewSedes.Items.Add(Item);
                }
            }
        }
    }
}
