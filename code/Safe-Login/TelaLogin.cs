using System;
using System.Drawing;
using System.Windows.Forms;

namespace Safe_Login
{
    public partial class TelaLogin : Form
    {
        Login login;
        Admin admin;
        Config config;

        public TelaLogin()
        {
            InitializeComponent();
            login = new Login();
            admin = new Admin();
            config = new Config(login, admin);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void CarregaDados()
        {            
            foreach (string aux in config.getCargos())
            {
                comboBoxCargo.Items.Add(aux);
            }
            /*
            AutoCompleteStringCollection dadosTextBoxUsuario = new AutoCompleteStringCollection();
            foreach (string aux in config.nomesUsuario)
            {
                dadosTextBoxUsuario.Add(aux);
            }
            textBoxUsuario.AutoCompleteCustomSource = dadosTextBoxUsuario;*/
        }

        private void textBoxUsuario_TextChanged_1(object sender, EventArgs e)
        {
            string texto = textBoxUsuario.Text;
            if (texto.Length > 0)
                if (!login.CheckEspacosBrancos(texto))
                {
                    textBoxUsuario.BackColor = Color.FromArgb(34, 177, 76);
                    labelSaida.Visible = false;
                }
                else
                {
                    textBoxUsuario.BackColor = Color.FromArgb(213, 17, 27);
                    labelSaida.Text = "Campo ou campos de entrada inválidos!";
                    labelSaida.Visible = true;
                }
            else
            {
                textBoxUsuario.BackColor = Color.FromArgb(1, 0, 9);
                labelSaida.Visible = false;
            }
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            string texto = textBoxSenha.Text;

            if (texto.Length > 0)
                if (!login.CheckEspacosBrancos(texto))
                {
                    textBoxSenha.BackColor = Color.FromArgb(34, 177, 76);
                    labelSaida.Visible = false;
                }
                else
                {
                    textBoxSenha.BackColor = Color.FromArgb(213, 17, 27);
                    labelSaida.Text = "Campo ou campos de entrada inválidos!";
                    labelSaida.Visible = true;
                }
            else
            {
                textBoxSenha.BackColor = Color.FromArgb(1, 0, 9);
                labelSaida.Visible = false;
            }
        }

        private void checkBoxSenha_Click(object sender, EventArgs e)
        {
            if (checkBoxSenha.Checked == true)
                textBoxSenha.UseSystemPasswordChar = false;
            else textBoxSenha.UseSystemPasswordChar = true;
        }

        // Botão entrar
        private void buttonEntrar_MouseEnter(object sender, EventArgs e)
        {
            buttonEntrar.BackColor = Color.Black;
        }
        private void buttonEntrar_MouseLeave(object sender, EventArgs e)
        {
            var cor = Color.FromArgb(0, 0, 21);
            buttonEntrar.BackColor = cor;
        }
        private void buttonEntrar_MouseDown(object sender, MouseEventArgs e)
        {
            var cor = Color.FromArgb(140, 19, 67);
            buttonEntrar.BackColor = cor;
        }
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            if (admin.EntraAdmin(textBoxUsuario.Text, textBoxSenha.Text))
            {
                TelaConfig telaConfig = new TelaConfig(login, admin, config);
                MessageBox.Show("Bem-vindo administrador");
                telaConfig.Show();
            }
            else if (login.Entra(textBoxUsuario.Text, textBoxSenha.Text, Convert.ToString(comboBoxCargo.SelectedItem)))
            {/*
                config.SetAcessosSystemLogs(login.Sessao.NomeCompleto + ";" + login.Sessao.NomeUsuario);
                */
                MessageBox.Show($"Bem-vindo {textBoxUsuario.Text}");
                this.Dispose();
            }
            else
            {
                Console.Beep();
                Console.Beep();
                labelSaida.Visible = true;
                labelSaida.Text = "Nome de usuário ou senha incorretos.\n\nTente novamente!";
                textBoxUsuario.Focus();
            }
        }              

        private void labelCadastra_Click(object sender, EventArgs e)
        {
            TelaCadastro cadastro = new TelaCadastro(login, admin, config);
            cadastro.Show();
        }
        private void labelCadastra_MouseHover(object sender, EventArgs e)
        {
            labelCadastra.ForeColor = Color.FromArgb(234, 0, 152);
        }
        private void labelCadastra_MouseLeave(object sender, EventArgs e)
        {
            labelCadastra.ForeColor = Color.White;
        }

        private void labelEsqueciSenha_MouseHover(object sender, EventArgs e)
        {
            labelEsqueciSenha.ForeColor = Color.FromArgb(234, 0, 152);
        }
        private void labelEsqueciSenha_MouseLeave(object sender, EventArgs e)
        {
            labelEsqueciSenha.ForeColor = Color.White;
        }
    }
}