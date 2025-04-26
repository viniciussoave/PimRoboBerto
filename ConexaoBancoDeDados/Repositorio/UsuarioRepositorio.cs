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

        public bool ExisteEmail(string email)
        {
            using (var conexao = connectionDB.ObterConexao())
            {
                conexao.Open();

                string sql = "select count(*) from usuario where email = @email";
                using (var cmd = new NpgsqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    int count = Convert.ToInt16(cmd.ExecuteScalar());
                    if (count > 0) return true;
                    return false;
                }
            }
        }

        public bool NomeUsuarioExiste(string nomeUsuario)
        {
            using (var conexao = connectionDB.ObterConexao())
            {
                conexao.Open();

                string sql = "select count(*) from usuario where nome = @nome";
                using (var cmd = new NpgsqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", nomeUsuario);
                    int count = Convert.ToInt16(cmd.ExecuteScalar());
                    if (count > 0) return true;
                    return false;
                }
            }
        }
        public Usuario RecuperarPorNome(string nome)
        {
            using (var conexao = connectionDB.ObterConexao())
            {
                conexao.Open();

                string sql = "SELECT * from usuario where nome = @nome";
                using (var cmd = new NpgsqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var id = Guid.Parse(reader["id"].ToString());
                            var email = reader["email"].ToString();
                            var dataCriacao = Convert.ToDateTime(reader["datacriacao"]);
                            var _nome = reader["nome"].ToString();
                            var senha = reader["senha"].ToString();
                            return Usuario.CriarModeloDoBanco(id, dataCriacao, nome, senha, email);
                        }
                    }
                }
            }
            return null;
        }

    }
}
