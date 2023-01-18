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
    public partial class TelaRegistroUsuarios : Form
    {
        Login login = new Login();
        private DataTable dt = new DataTable();
        public TelaRegistroUsuarios()
        {
            InitializeComponent();
            ConfigurarTabela();            
        }

        private void TelaRegistroUsuarios_Load(object sender, EventArgs e)
        {
            AtualizaTabela();
        }
        
        private void AtualizaTabela()
        {
            var pilha = login.GetListar();
            foreach (Conta conta in pilha)
            {
                AdicionarLinha(conta);
            }
        }
        private void AdicionarLinha(Conta obj)
        {
            DataRow linha = dt.NewRow();
            linha["Status"] = obj.Status;
            linha["Nome completo"] = obj.NomeCompleto;
            linha["E-mail"] = obj.Email;
            linha["Cargo"] = obj.Cargo;
            linha["Nome de usuário"] = obj.NomeUsuario;
            linha["Senha"] = obj.Senha;
            linha["Palavra passe"] = obj.PalavraPasse;

            dt.Rows.Add(linha);
        }
        
        private void ConfigurarTabela()
        {
            dt.Columns.Add("ID", typeof(Int32));
            dt.Columns["ID"].AutoIncrement = true;
            dt.Columns["ID"].AutoIncrementSeed = 1;

            dt.Columns.Add("Status", typeof(string));            
            dt.Columns.Add("Nome completo", typeof(string));            
            dt.Columns.Add("E-mail", typeof(string));
            dt.Columns.Add("Cargo", typeof(string));
            dt.Columns.Add("Nome de usuário", typeof(string));
            dt.Columns.Add("Senha", typeof(string));
            dt.Columns.Add("Palavra passe", typeof(string));                                    
            dt.CaseSensitive = true;            
            dataGridViewRegistro.DataSource = dt;
        }

        private void iconToolStripButtonAdicionar_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
        }

        private void iconSplitButtonRecarregar_ButtonClick(object sender, EventArgs e)
        {            
            
            dt.Clear();
            login.AtualizaRegistros();
            AtualizaTabela();
        }
    }
}
