using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Safe_Login
{
    public partial class TelaConfig : Form
    {
        Stack<Conta> pilha;

        Login login;
        Admin admin;
        Config config;

        public TelaConfig(Login login, Admin admin, Config config)
        {
            InitializeComponent();
            this.login = login;
            this.admin = admin;
            this.config = config;            
        }

        private void TelaConfig_Load(object sender, EventArgs e)
        {            
            labelTitulo.Text = "Olá, "+admin.UsuarioAdmin;            
        }
        
        private void AbrirFormulario(Form form)
        {
            if (panelContentor.Controls.Count > 0)
                panelContentor.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelContentor.Controls.Add(form);
            panelContentor.Tag = form;
            form.Show();
        }


        // --- Painel lateral ---
        // Botão de geral
        private void iconButtonGeral_MouseHover(object sender, EventArgs e)
        {
            iconButtonGeral.BackColor = Color.FromArgb(254, 121, 14);
        }
        private void iconButtonGeral_MouseLeave(object sender, EventArgs e)
        {
            iconButtonGeral.BackColor = Color.FromArgb(0, 0, 21);
        }
        private void iconButtonGeral_Click(object sender, EventArgs e)
        {
            TelaGeral telaGeral = new TelaGeral(login, admin, config);
            AbrirFormulario(telaGeral);
        }

        // Botão de usuários
        private void iconButtonUsuarios_MouseHover(object sender, EventArgs e)
        {
            iconButtonUsuarios.BackColor = Color.FromArgb(254, 121, 14);
        }
        private void iconButtonUsuarios_MouseLeave(object sender, EventArgs e)
        {
            iconButtonUsuarios.BackColor = Color.FromArgb(0, 0, 21);
        }
        private void iconButtonUsuarios_Click(object sender, EventArgs e)
        {
            TelaRegistroUsuarios telaRegistros = new TelaRegistroUsuarios(login, admin, config);
            AbrirFormulario(telaRegistros);
        }

        // Botão de estátisticas
        private void iconButtonEstatisticas_MouseHover(object sender, EventArgs e)
        {
            iconButtonEstatisticas.BackColor = Color.FromArgb(254, 121, 14);
        }
        private void iconButtonEstatisticas_MouseLeave(object sender, EventArgs e)
        {
            iconButtonEstatisticas.BackColor = Color.FromArgb(0, 0, 21);
        }
        private void iconButtonEstatisticas_Click(object sender, EventArgs e)
        {
            TelaEstatistica telaEstatistica = new TelaEstatistica(login, admin, config);
            AbrirFormulario(telaEstatistica);
        }

        // Botão de aparência
        private void iconButtonAparencia_MouseHover(object sender, EventArgs e)
        {
            iconButtonAparencia.BackColor = Color.FromArgb(254, 121, 14);
        }
        private void iconButtonAparencia_MouseLeave(object sender, EventArgs e)
        {
            iconButtonAparencia.BackColor = Color.FromArgb(0, 0, 21);
        }
        private void iconButtonAparencia_Click(object sender, EventArgs e)
        {
            TelaAparencia telaAparencia = new TelaAparencia(login, admin, config);
            AbrirFormulario(telaAparencia);
        }

        // Botão de sobre
        private void iconButtonSobre_MouseHover(object sender, EventArgs e)
        {
            iconButtonSobre.BackColor = Color.FromArgb(254, 121, 14);
        }
        private void iconButtonSobre_MouseLeave(object sender, EventArgs e)
        {
            iconButtonSobre.BackColor = Color.FromArgb(0, 0, 21);
        }
        private void iconButtonSobre_Click(object sender, EventArgs e)
        {

        }

        // --- Barra de ferramentas ---

        // 1. Arquivo
        private void ToolStripMenuItemArquivo_MouseHover(object sender, EventArgs e)
        {            
            ToolStripMenuItemArquivo.ForeColor = Color.White;

        }
        private void ToolStripMenuItemArquivo_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItemArquivo.ForeColor = Color.Silver;
        }
        // 1. Arquivo -> 1.1 Importar       
        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogImportar.ShowDialog() == DialogResult.OK)
            {
                login.ImportaCadastro(openFileDialogImportar.FileName);
            }
        }
        // 1. Arquivo ->  1.2 Salvar
        
        // 1. Arquivo ->  1.3 Exportar        

        // 1. Arquivo ->  1.4 Sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 2. Novo -> 2.1 Cadastrar usuário        
        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro(login, admin, config);
            telaCadastro.Show();
        }
        // 3. Editar -> 3.1 Edita usuário
        private void editarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaEditar telaEditar = new TelaEditar();
            telaEditar.Show();
        }        



        // 4. Tema ->

        // 5. Relatório ->

        // 6. Ferramentas ->

        // 7. Sobre ->

        // 8. Ajuda ->               
    }
}
