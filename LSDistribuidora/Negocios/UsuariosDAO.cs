﻿using Dapper;
using LSDistribuidora.Mapeamento;
using LSDistribuidora.Suporte;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LSDistribuidora.Negocios
{
    public class UsuariosDAO : Conexao
    {
        /// <summary>
        /// Método que realiza o login.
        /// </summary>
        /// <param name="login">Login do usuário</param>
        /// <param name="senha">Senha do usuário</param>
        /// <returns>Retorna um usuário ou null caso não encontre</returns>
        public Usuario Login(string login, string senha)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Usuarios WHERE Login=@pLogin AND Senha=@pSenha";
            using (SqlCommand command = new SqlCommand(sql, conexao))
            {
                command.Parameters.AddWithValue("@pLogin", login);
                command.Parameters.AddWithValue("@pSenha", senha);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            //converte a pesquisa em um objeto
            Usuario usuario = null;
            //caso tenha encontrado apenas um registro com o usuário e senha 
            if (dt.Rows.Count == 1)
            {
                usuario = new Usuario();
                //converte cada valor para seu tipo correto
                usuario.ID = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
                usuario.Nome = dt.Rows[0]["Nome"].ToString();
                usuario.Login = dt.Rows[0]["Login"].ToString();
                usuario.Senha = "A senha não é mostrada pro segurança";
                usuario.Nivel = Convert.ToInt32(dt.Rows[0]["Nivel"].ToString());
                usuario.Ativo = Convert.ToBoolean(dt.Rows[0]["Ativo"].ToString());
            }
            //retorna o objeto
            return usuario;
        }

        /// <summary>
        /// Método que realiza o login com dapper
        /// 
        /// </summary>
        /// <param name="login">Login do usuário</param>
        /// <param name="senha">Senha do usuário</param>
        /// <returns>Retorna um usuário ou null caso não encontre</returns>
        public Usuario Login2(string login, string senha)
        {
            return conexao.Query<Usuario>("SELECT * FROM Usuarios WHERE Login=@pLogin AND Senha=@pSenha",
            new
            {
                @pLogin = login,
                @pSenha = senha
            }).SingleOrDefault();
        }
    }
}
