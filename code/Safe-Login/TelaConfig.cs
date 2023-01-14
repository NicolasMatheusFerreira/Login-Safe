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

        public void NomeTitulo(string nomeTitulo)
        {
            labelTitulo.Text = "Olá, " + nomeTitulo;
        }

        
    }
}
