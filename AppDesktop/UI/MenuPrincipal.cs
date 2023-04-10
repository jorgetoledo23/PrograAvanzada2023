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
    public partial class MenuPrincipal : Form
    {
        private Usuario _User { get; set; }
        public MenuPrincipal(Usuario User)
        {
            InitializeComponent();
            _User = User;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            //Bienvenido {Correo}
            this.Text = $"Bienvenido {_User.Email}";
        }

        private void agregarNuevaSedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSede addSede = new AddSede();
            addSede.ShowDialog();
        }

        private void verTodasLasSedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSede viewSede = new ViewSede();
            viewSede.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
