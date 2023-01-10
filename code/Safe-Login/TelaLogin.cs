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
        public TelaLogin()
        {
            InitializeComponent();           
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.Entra(textBoxUsuario.Text, textBoxSenha.Text))
            {
                this.Dispose();
            }
            else
            {
                labelSaida.Visible = true;
                labelSaida.Text = "Nome de usuário ou senha incorretos.\n\nTente novamente!";
                Console.Beep();
                Console.Beep();
                textBoxUsuario.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
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
            var cor = Color.FromArgb(235, 103, 27);
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
                if (texto.Equals("Nicolas"))
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
                if (texto.Equals("33900643"))
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
            TelaEsqueciSenha esqueciSenha = new TelaEsqueciSenha();
            esqueciSenha.Show();
        }
    }
}