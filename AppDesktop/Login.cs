using AppDesktop.Model;

namespace AppDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string pass = txtPass.Text;

            using (var context = new AppDbContext())
            {
                //Select * from usuario where Email = 'asdasd';
                var user = context.tblUsuarios.FirstOrDefault(x => x.Email.Equals(correo));
                if(user != null)
                {
                    if (user.Pass.Equals(pass))
                    {
                        //Login OK
                        MenuPrincipal Mp = new MenuPrincipal(user);
                        Mp.ShowDialog();
                    }
                    else
                    {
                        MessageBox
                        .Show("Password Incorrecta"
                        , "Error"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox
                        .Show("Correo No Encontrado"
                        , "Error"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }

            }



            
        }
    }
}