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
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
        
        private void LimparCampos()
        {
            textBoxNome.Clear();
            textBoxEmail.Clear();
            textBoxUsuario.Clear();
            textBoxSenha.Clear();
            textBoxConfirmeSenha.Clear();
            textBoxSenhaAdm.Clear();
            comboBoxCargo.Text = "Selecione";
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            Login login = new Login();

            string aux, senhaAdm;

            conta.NomeCompleto = textBoxNome.Text;
            conta.Email = textBoxEmail.Text;
            conta.Cargo = comboBoxCargo.Text;
            conta.NomeUsuario = textBoxNome.Text;
            conta.Senha = textBoxSenha.Text;
            aux = textBoxConfirmeSenha.Text;
            senhaAdm = textBoxSenhaAdm.Text;

            if (login.ValidaSenha(conta.Senha, aux))
            {
                if (senhaAdm.Equals("12345678"))
                {
                    login.Cadastra(conta);
                    LimparCampos();                    
                }
                else
                {
                    // Mostrar mensagem senha administrador inválida!
                    MessageBox.Show("Senha Administrador inválida!");
                }
            }
            else
            {
                // Mostrar mensagem de senhas não correspondente
                MessageBox.Show("Senhas não correspondem!");
            }
            textBoxNome.Focus();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
