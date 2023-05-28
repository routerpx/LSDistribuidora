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
    public partial class ProdutosListarForm : Form
    {
        public ProdutosListarForm()
        {
            InitializeComponent();
        }

        private void ProdutosListarForm_Load(object sender, EventArgs e)
        {

        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            //executa o método e coloca os dados na variável
            var dados = new ProdutoDAO().ListarTodas();
            //conta os registros e coloca no label
            quantidadeLabel.Text = $"Registros encontrados: {dados.Count}";
            //joga os dados no grid
            listaDataGridView.DataSource = dados;
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do Produto?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //pega o id da linha selecionada no grid
                int id = Convert.ToInt32(listaDataGridView.SelectedRows[0].Cells["idColumn"].Value);
                //executa a exclusão
                new ProdutoDAO().Excluir(id);
                //executa a busca novamente, como se tivesse clicado no botão
                buscarButton.PerformClick();
                //avisa o usuário
                MessageBox.Show("Produto excluído com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            //pega o id da linha selecionada no grid
            int id = Convert.ToInt32(listaDataGridView.SelectedRows[0].Cells["idColumn"].Value);
            //abre a tela passando a cidade selecionada
            new ProdutoForm(id).ShowDialog();
            //executa a busca novamente, como se tivesse clicado no botão
            buscarButton.PerformClick();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            // Abre a tela para um novo cadastro, sem passar nenhum ID como parâmetro
            new ProdutoForm().ShowDialog();

            // Executa a busca novamente, como se tivesse clicado no botão
            buscarButton.PerformClick();
        }
        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
