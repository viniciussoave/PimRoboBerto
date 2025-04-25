using Dominio.Entidades;
using Dominio.Interface_Repositorios;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2;

namespace ConexaoBancoDeDados.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public void Adicionar(Usuario usuario)
        {

            using (var conexao = connectionDB.ObterConexao())
            {

                conexao.Open();

                string sql = "Insert into Usuario (id, dataCriacao, nome, senha, email) values (@id, @dataCriacao, @nome, @senha, @email)";

                using (var cmd = new NpgsqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", usuario.Id);
                    cmd.Parameters.AddWithValue("@dataCriacao", usuario.DataCriacao);
                    cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                    cmd.Parameters.AddWithValue("@email", usuario.Email);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
