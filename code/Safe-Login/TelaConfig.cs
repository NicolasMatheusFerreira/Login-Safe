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

        public TelaConfig(Login obj)
        {
            InitializeComponent();
            login = obj;
        }

        private void TelaConfig_Load(object sender, EventArgs e)
        {
            labelTitulo.Text = "Olá "+TelaLogin.textBoxu;
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
            TelaGeral telaGeral = new TelaGeral();
            AbrirFormulario(telaGeral);
        }

        private void iconButtonSobre_MouseHover(object sender, EventArgs e)
        {
            iconButtonSobre.BackColor = Color.FromArgb(254, 121, 14);
        }

        private void iconButtonSobre_MouseLeave(object sender, EventArgs e)
        {
            iconButtonSobre.BackColor = Color.FromArgb(0, 0, 21);
        }

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
            TelaRegistroUsuarios telaRegistros = new TelaRegistroUsuarios(login);            
            AbrirFormulario(telaRegistros);
        }

        private void iconButtonEstatisticas_MouseHover(object sender, EventArgs e)
        {
            iconButtonEstatisticas.BackColor = Color.FromArgb(254, 121, 14);
        }

        private void iconButtonEstatisticas_MouseLeave(object sender, EventArgs e)
        {
            iconButtonEstatisticas.BackColor = Color.FromArgb(0, 0, 21);
        }

        private void iconButtonAparencia_MouseHover(object sender, EventArgs e)
        {
            iconButtonAparencia.BackColor = Color.FromArgb(254, 121, 14);
        }

        private void iconButtonAparencia_MouseLeave(object sender, EventArgs e)
        {
            iconButtonAparencia.BackColor = Color.FromArgb(0, 0, 21);
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogImportar.ShowDialog() == DialogResult.OK)
            {
                login.ImportaCadastro(openFileDialogImportar.FileName);
            }
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro(login);
            telaCadastro.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelContentor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonAparencia_Click(object sender, EventArgs e)
        {
            TelaAparencia telaAparencia = new TelaAparencia();
            AbrirFormulario(telaAparencia);
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void editarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaEditar telaEditar = new TelaEditar();
            telaEditar.Show();
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
