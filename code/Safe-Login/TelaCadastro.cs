using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace Safe_Login
{
    public partial class TelaCadastro : Form
    {
        Login login = new Login();
        Config config = new Config();

        public TelaCadastro()
        {
            InitializeComponent();
            CarregaDados();

        }
        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
        
        private void CarregaDados()
        {
            comboBoxCargo.Items.Clear();
            foreach (string aux in config.cargo)
            {
                comboBoxCargo.Items.Add(aux);
            }
        }

        private bool VerificaCampos(Conta obj)
        {
            if (obj.NomeCompleto.Length > 0 && obj.Email.Length > 0 && obj.Cargo.Length > 0 && obj.Senha.Length > 0)
                return true;                        
            return false;
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            textBoxEmail.Clear();
            comboBoxCargo.Text = "Selecione";
            textBoxUsuario.Clear();
            textBoxSenha.Clear();
            textBoxConfirmeSenha.Clear();
            textBoxPalavraPasse.Clear();
            textBoxSenhaAdm.Clear();            

            textBoxNome.Focus();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();         

            string aux, senhaAdm;

            conta.NomeCompleto = textBoxNome.Text;
            conta.Email = textBoxEmail.Text;
            conta.Cargo = Convert.ToString(comboBoxCargo.SelectedItem);
            conta.NomeUsuario = textBoxUsuario.Text;
            conta.Senha = textBoxSenha.Text;
            aux = textBoxConfirmeSenha.Text;
            conta.PalavraPasse = textBoxPalavraPasse.Text;
            senhaAdm = textBoxSenhaAdm.Text;

            if (!VerificaCampos(conta))
                MessageBox.Show("Campos vazios!");
            else
            {
                if (login.ValidaSenha(conta.Senha, aux))
                {
                    if (senhaAdm.Length > 0)
                    {
                        if (config.AdminCadastro(senhaAdm))
                        {
                            if (!login.RegistrosDuplicados(conta))
                            {
                                login.Cadastra(conta);
                                MessageBox.Show("Usuário cadastrado com sucesso!");
                                LimparCampos();
                            } else MessageBox.Show("Nome de usuário já cadastrado! Tente outro usuário.");
                        }
                        else
                        {
                            // Mostrar mensagem senha administrador inválida!
                            MessageBox.Show("Senha Administrador inválida. Tente novamente!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Campo de senha de administrador inválido!");
                        textBoxSenhaAdm.Focus();
                    }
                }
                else
                {
                    // Mostrar mensagem de senhas não correspondente
                    MessageBox.Show("Senhas não correspondem!");
                }
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;

            if (email.Length>0)
                for(int i = 0; i<email.Length; i++)
                {
                    if (email[i]=='@')
                    {
                        if (email[email.Length-1]=='m' && email[email.Length - 2] == 'o' && email[email.Length - 3] == 'c' && email[email.Length - 4] == '.')
                        {
                            textBoxEmail.BackColor = Color.FromArgb(34, 177, 76);
                        } else textBoxEmail.BackColor = Color.FromArgb(1, 0, 9);
                    }
                }
            else textBoxEmail.BackColor = Color.FromArgb(1, 0, 9);
        }

        private void textBoxConfirmeSenha_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSenha.Text.Length > 0 && textBoxConfirmeSenha.Text.Length > 0) { 
                if (!login.ValidaSenha(textBoxSenha.Text, textBoxConfirmeSenha.Text))
                {
                    textBoxSenha.BackColor = Color.FromArgb(213, 17, 27);
                    textBoxConfirmeSenha.BackColor = Color.FromArgb(213, 17, 27);
                    labelCadastroSenha.Text = "Senhas não se correspondem. Digite novamente!";
                    labelCadastroSenha.Visible = true;
                } else
                {
                    textBoxSenha.BackColor = Color.FromArgb(1, 0, 9);
                    textBoxConfirmeSenha.BackColor = Color.FromArgb(1, 0, 9);
                    labelCadastroSenha.Visible = false;
                }
            } else {
                    textBoxSenha.BackColor = Color.FromArgb(1, 0, 9);
                    textBoxConfirmeSenha.BackColor = Color.FromArgb(1, 0, 9);
                    labelCadastroSenha.Visible = false;
            }                
        }

        private void labelCadastroSenha_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            labelCadastroSenha.Visible = true;
            if (login.CheckSenha(textBoxSenha.Text)==3)
            {
                labelCadastroSenha.Text = "Senha forte";
            } else if (login.CheckSenha(textBoxSenha.Text) == 2)
            {
                labelCadastroSenha.Text = "Senha boa";
            } else if (login.CheckSenha(textBoxSenha.Text) == 1)
            {
                labelCadastroSenha.Text = "Senha média";
            } else labelCadastroSenha.Text = "Senha fraca";
        }

        private void checkBoxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSenha.Checked==true)
            {
                textBoxSenha.UseSystemPasswordChar = false;
                textBoxConfirmeSenha.UseSystemPasswordChar = false;
            } else
            {
                textBoxSenha.UseSystemPasswordChar = true;
                textBoxConfirmeSenha.UseSystemPasswordChar = true;
            }
        }

        private void checkBoxSenhaAdm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSenhaAdm.Checked == true)
                textBoxSenhaAdm.UseSystemPasswordChar = false;
            else textBoxSenhaAdm.UseSystemPasswordChar = true;
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            if (login.CheckNumeros(textBoxNome.Text))
                textBoxNome.Text = "";
        }        
        
        private void iconButtonLogar_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            this.Close();            
        }

        private void comboBoxCargo_Click(object sender, EventArgs e)
        {
            //fefwefewfwefwe
        }

        private void textBoxSenha_Enter(object sender, EventArgs e)
        {
            iconButtonChave.Visible = true;
        }

        private void textBoxSenha_Leave(object sender, EventArgs e)
        {
            iconButtonChave.Visible = false;
        }

        private void iconButtonChave_Click(object sender, EventArgs e)
        {
            string senha = login.SugereSenha();            

            textBoxSenha.Text = senha;            
            textBoxConfirmeSenha.Text = senha;

            textBoxSenha.BackColor = Color.FromArgb(238, 227, 134);
            textBoxConfirmeSenha.BackColor = Color.FromArgb(238, 227, 134);

            labelCadastroSenha.Visible = true;

            if (login.CheckSenha(senha) == 3)
            {
                labelCadastroSenha.Text = "Senha forte";
            }
            else if (login.CheckSenha(senha) == 2)
            {
                labelCadastroSenha.Text = "Senha boa";
            }
            else if (login.CheckSenha(senha) == 1)
            {
                labelCadastroSenha.Text = "Senha média";
            }
            else labelCadastroSenha.Text = "Senha fraca";
        }

        private void comboBoxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButtonChave_MouseEnter(object sender, EventArgs e)
        {
            iconButtonChave.IconColor = Color.FromArgb(127, 127, 127);
        }

        private void iconButtonChave_MouseLeave(object sender, EventArgs e)
        {
            iconButtonChave.IconColor = Color.White;
        }

        private void textBoxPalavraPasse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
