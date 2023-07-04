using AppDesktop.Model;
using Microsoft.IdentityModel.Tokens;


namespace AppDesktop
{
    public partial class AddDocenteAlumno : Form
    {
        public AddDocenteAlumno()
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
                            Duracion = txtApellido.Text,

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
            if (txtApellido.Text.IsNullOrEmpty()
                || txtNombre.Text.IsNullOrEmpty())
            {
                return false;
            }
            else return true;
        }
    }
}
