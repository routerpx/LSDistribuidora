using LSDistribuidora.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSDistribuidora.Formulario
{
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {

        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            string nome = nomeUsuarioTextBox.Text;
            string login = loginCadastroTextBox.Text;
            string senha = senhaCadastroTextBox.Text;




            new ProdutoDAO().Adicionar1(nome, login, senha);
           
            MessageBox.Show("Usuário cadastrado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
