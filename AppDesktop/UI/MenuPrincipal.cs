using AppDesktop.Model;

namespace AppDesktop
{
    public partial class MenuPrincipal : Form
    {
        private Usuario _User { get; set; }
        private string SelectedMenu { get; set; }
        public MenuPrincipal(Usuario User)
        {
            InitializeComponent();
            _User = User;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            //Bienvenido {Correo}
            this.Text = $"Bienvenido {_User.Email}";
            //this.ControlBox = false;
        }

        private void agregarNuevaSedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddSede addSede = new AddSede();
            //addSede.ShowDialog();
            PanelSubMenu.Visible = true;
            SelectedMenu = "SEDE";
        }

        private void verTodasLasSedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSede viewSede = new ViewSede();
            viewSede.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (SelectedMenu)
            {
                case "SEDE":
                    AddSede addSede = new AddSede();
                    addSede.ShowDialog();
                    break;
                case "CARRERA":
                    AddCarrera addCarrera = new AddCarrera();
                    addCarrera.ShowDialog();
                    break;
                case "CARRERASEDE":
                    AddCarreraSede cs = new AddCarreraSede();
                    cs.ShowDialog();
                    break;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            switch (SelectedMenu)
            {
                case "SEDE":
                    ViewSede vs = new ViewSede();
                    vs.ShowDialog();
                    break;
                case "CARRERA":
                    ViewCarrera vc = new ViewCarrera();
                    vc.ShowDialog();
                    break;
                case "CARRERASEDE":
                    AddCarreraSede cs = new AddCarreraSede();
                    cs.ShowDialog();
                    break;
            }
        }

        private void PanelSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            PanelSubMenu.Visible = true;
            SelectedMenu = "CARRERA";
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            PanelSubMenu.Visible = true;
            SelectedMenu = "CARRERASEDE";
        }
    }
}
