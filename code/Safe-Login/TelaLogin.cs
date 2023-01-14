using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safe_Login
{
    public partial class TelaLogin : Form
    {
        Login login = new Login();
        global::Config config = new global::Config();

        public TelaLogin()
        {
            InitializeComponent();        
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void CarregaDados()
        {
            comboBoxCargo.Items.Clear();
            foreach (string aux in config.cargo)
            {
                comboBoxCargo.Items.Add(aux);
            }

            AutoCompleteStringCollection dadosTextBoxUsuario = new AutoCompleteStringCollection();
            foreach (string aux in config.nomesUsuario)
            {
                dadosTextBoxUsuario.Add(aux);
            }
            textBoxUsuario.AutoCompleteCustomSource = dadosTextBoxUsuario;
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            if (config.Admin(textBoxUsuario.Text, textBoxSenha.Text)) {
                TelaConfig telaConfig = new TelaConfig();
                                
                MessageBox.Show("Bem-vindo administrador");
                telaConfig.Show();
                telaConfig.NomeTitulo(textBoxUsuario.Text);

            } else if (login.Entra(textBoxUsuario.Text, textBoxSenha.Text, Convert.ToString(comboBoxCargo.SelectedItem)))
            {
                config.SetAcessosSystemLogs(login.Usuario.NomeCompleto + ";" + login.Usuario.NomeUsuario);

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }        

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            textBoxUsuario.BackColor = Color.Green;
        }

        private void buttonEntrar_MouseLeave(object sender, EventArgs e)
        {
            var cor = Color.FromArgb(0, 0, 21);
            buttonEntrar.BackColor = cor;
        }

        private void buttonEntrar_MouseEnter(object sender, EventArgs e)
        {
            buttonEntrar.BackColor = Color.Black;           
        }

        private void buttonEntrar_MouseDown(object sender, MouseEventArgs e)
        {
            var cor = Color.FromArgb(140, 19, 67);
            buttonEntrar.BackColor = cor;
        }

        private void checkBoxSenha_Click(object sender, EventArgs e)
        {
            if (checkBoxSenha.Checked == true)
                textBoxSenha.UseSystemPasswordChar = false;
            else textBoxSenha.UseSystemPasswordChar = true;
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

        private void labelCadastra_Click(object sender, EventArgs e)
        {
            TelaCadastro cadastro = new TelaCadastro();            
            cadastro.Show();            
        }

        private void labelEsqueciSenha_Click(object sender, EventArgs e)
        {            
        }        

        private void comboBoxCargo_Click(object sender, EventArgs e)
        {                        
        }

        private void comboBoxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCargo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}