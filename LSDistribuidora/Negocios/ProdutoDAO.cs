using LSDistribuidora.Suporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using LSDistribuidora.Mapeamento;

namespace LSDistribuidora.Negocios
{
    public class ProdutoDAO : Conexao
    {
        // Função para Adicionar Nova Cidade
        public void Adicionar(string nome, string categoria, int quantidade, float valor)
        {
            conexao.Execute("INSERT INTO Produtos (Nome, Categoria, Quantidade, Valor) VALUES (@Nome, @Categoria, @Quantidade, @Valor)",
                new { nome, categoria, quantidade, valor });
        }

        public void Adicionar1(string nome, string login, string senha)
        {
            conexao.Execute("INSERT INTO Usuarios (Nome, Login, Senha) VALUES (@Nome, @Login, @Senha)",
                new { nome, login, senha });
        }

        // Função para Atualizar um Produto
        public void Atualizar(int id, string nome, string categoria, int quantidade, float valor)
        {
            conexao.Execute("UPDATE Produtos SET Nome=@Nome, Categoria=@Categoria,Quantidade=@Quantidade,Valor=@Valor WHERE ID=@ID",
                new { nome, categoria, quantidade, valor, id });
        }

       internal List<Produto> Listar()
        {
            // Código para listar os objetos desejados e retornar a lista
            List<Produto> lista = new List<Produto>();

            // Adicione os objetos à lista conforme necessário

            return lista;
        }

        // Função para Excluir um Produto
        public void Excluir(int id)
        {
            conexao.Execute("DELETE FROM Produtos WHERE ID=@ID",
               new { id });
        }

        // Função para Buscar um Produto pelo ID
        public Produto Buscar(int id)
        {
            return conexao.Query<Produto>("SELECT * FROM Produtos WHERE ID=@ID",
                new { id }).SingleOrDefault();
        }

        // Função para Listar Todos os Produto (foi modificado para ficar no padrão
        public List<Produto> ListarTodas()
        {
            return conexao.Query<Produto>("SELECT * FROM Produtos order by Nome").ToList();
        }
    }
}
