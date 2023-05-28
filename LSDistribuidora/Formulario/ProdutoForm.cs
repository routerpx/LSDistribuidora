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
    public partial class ProdutoForm : Form
    {
        public ProdutoForm()
        {
            InitializeComponent();
            Text = "Novo Produto";
            idTextBox.Text = "Automático";
            idTextBox.ReadOnly = true;
            nomeTextBox.Focus();

            //lista os estados
            ListarProdutos();

        }
        public ProdutoForm(int id)
        {
            InitializeComponent();
            var produto = new ProdutoDAO().Buscar(id);

            Text = "Alteração de Produto";
            idTextBox.Text = produto.ID.ToString();
            idTextBox.ReadOnly = true;

            nomeTextBox.Text = produto.Nome;
            nomeTextBox.Focus();

            //lista os estados
            ListarProdutos();

            Application.DoEvents();

            listComboBox.SelectedValue = produto.Categoria;
        }
        void ListarProdutos()
        {
            var lista = new ProdutoDAO().Listar();
            listComboBox.DisplayMember = "Nome";//informação que vai aparecer
            listComboBox.ValueMember = "Categoria";//informação que ficará interna
            listComboBox.DataSource = lista;
        }

        private void ProdutoForm_Load(object sender, EventArgs e)
        {

        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if (Text == "Novo Produto")
            {
                // Faz a inclusão
                string nome = nomeTextBox.Text;
                string categoria = categoriaTextBox.Text;
                int quantidade;
                float valor;

                if (int.TryParse(quantidadeTextBox.Text, out quantidade) && float.TryParse(valorTextBox.Text, out valor))
                {
                    new ProdutoDAO().Adicionar(nome, categoria, quantidade, valor);

                    MessageBox.Show("Produto adicionado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                else
                {
                    MessageBox.Show("Por favor, insira valores válidos para quantidade e valor.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Faz a alteração
                int id = Convert.ToInt32(idTextBox.Text);
                string nome = nomeTextBox.Text;
                string categoria = categoriaTextBox.Text;
                int quantidade;
                float valor;

                if (int.TryParse(quantidadeTextBox.Text, out quantidade) && float.TryParse(valorTextBox.Text, out valor))
                {
                    new ProdutoDAO().Atualizar(id, nome, categoria, quantidade, valor);

                    MessageBox.Show("Produto alterado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                else
                {
                    MessageBox.Show("Por favor, insira valores válidos para quantidade e valor.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
