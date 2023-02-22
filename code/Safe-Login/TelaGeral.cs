using System.Windows;
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

        private void ButtonRegistrar_Click(object sender, System.EventArgs e)
        {
            admin.UsuarioAdmin = textBoxUsuarioAdmin.Text;
            admin.SenhaAdmin = textBoxSenhaAdmin.Text;

            config.ExportaConfiguracoes();
            System.Windows.MessageBox.Show("Dados atualizados com sucesso!");
        }

        // 1. Credenciais de acesso
        private void checkBoxCredenciais_Click(object sender, System.EventArgs e)
        {
            if (checkBoxCredenciais.Checked == true)
            {
                textBoxUsuarioAdmin.UseSystemPasswordChar = false;
                textBoxSenhaAdmin.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxUsuarioAdmin.UseSystemPasswordChar = true;
                textBoxSenhaAdmin.UseSystemPasswordChar = true;
            }
        }

        private void iconButtonReset_Click(object sender, System.EventArgs e)
        {
            admin.ResetAdmin();
            textBoxUsuarioAdmin.Text = admin.UsuarioAdmin;
            textBoxSenhaAdmin.Text = admin.SenhaAdmin;            
            System.Windows.MessageBox.Show("Padrões restaurados com sucesso!");
        }                     
    }
}
