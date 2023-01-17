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
    public partial class TelaConfig : Form
    {        
        public TelaConfig()
        {
            InitializeComponent();            
        }

        private void TelaConfig_Load(object sender, EventArgs e)
        {
         
        }

        private void AbrirFormulario(object form)
        {
            if (panelContentor.Controls.Count>0)          
                panelContentor.Controls.RemoveAt(0);

                Form fh = form as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                panelContentor.Controls.Add(fh);
                panelContentor.Tag = fh;
                fh.Show();
            
        }
        public void NomeTitulo(string nomeTitulo)
        {
            labelTitulo.Text = "Olá, " + nomeTitulo;
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
            AbrirFormulario(new TelaGeral());
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

        private void iconButtonUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new TelaRegistroUsuarios());
        }
    }
}
