using System.Windows.Forms;

namespace Safe_Login
{
    public partial class TelaGeral : Form
    {
        Login login;
        Admin admin;
        Config config;

        public TelaGeral(Login login, Admin admin, Config config)
        {
            InitializeComponent();
            this.login = login;
            this.admin = admin;
            this.config = config;           
        }               

        private void TelaGeral_Load(object sender, System.EventArgs e)
        {
            textBoxUsuarioAdmin.Text = admin.UsuarioAdmin;
            textBoxSenhaAdmin.Text = admin.SenhaAdmin;
        }    

        private void checkBoxSenha_Click(object sender, System.EventArgs e)
        {
            if (checkBoxSenha.Checked == true)
                textBoxSenhaAdmin.UseSystemPasswordChar = false;
            else textBoxSenhaAdmin.UseSystemPasswordChar = true;
        }

        private void ButtonRegistrar_Click(object sender, System.EventArgs e)
        {
            admin.UsuarioAdmin = textBoxUsuarioAdmin.Text;
            admin.SenhaAdmin = textBoxUsuarioAdmin.Text;

            config.ExportaConfiguracoes();            
        }
    }
}
