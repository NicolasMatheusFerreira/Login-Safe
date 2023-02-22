using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Safe_Login
{
    public partial class TelaRegistroUsuarios : Form
    {
        Login login;
        Admin admin;
        Config config;

        
        
        private DataTable dt = new DataTable();

        public TelaRegistroUsuarios(Login login, Admin admin, Config config)
        {
            InitializeComponent();
            this.login = login;
            this.admin = admin;
            this.config = config;
        }

        private void TelaRegistroUsuarios_Load(object sender, EventArgs e)
        {
            ConfigurarTabela();
            AtualizaTabela();
        }

        private void AtualizaTabela()
        {
            Queue<Conta> fila = login.GetListar();
            foreach (Conta i in fila)
            {
                AdicionarLinha(i);
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
            linha["Ultimo acesso"] = obj.AcessosSystem;

            dt.Rows.Add(linha);
            dataGridViewRegistro.DataSource = dt;
        }

        private void ConfigurarTabela()
        {
            dt.Columns.Add("ID", typeof(Int32));
            dt.Columns["ID"].AutoIncrement = true;
            dt.Columns["ID"].AutoIncrementSeed = 1;

            dt.Columns.Add("Status", typeof(Boolean));
            dt.Columns.Add("Nome completo", typeof(string));
            dt.Columns.Add("E-mail", typeof(string));
            dt.Columns.Add("Cargo", typeof(string));
            dt.Columns.Add("Nome de usuário", typeof(string));
            dt.Columns.Add("Senha", typeof(string));
            dt.Columns.Add("Palavra passe", typeof(string));
            dt.Columns.Add("Ultimo acesso", typeof(string));
            dt.CaseSensitive = true;
            dataGridViewRegistro.DataSource = dt;
        }

        private void iconToolStripButtonAdicionar_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro(login, admin, config);
            telaCadastro.Show();
        }

        private void iconSplitButtonRecarregar_ButtonClick(object sender, EventArgs e)
        {
            dt.Clear();
            AtualizaTabela();
        }
    }
}
