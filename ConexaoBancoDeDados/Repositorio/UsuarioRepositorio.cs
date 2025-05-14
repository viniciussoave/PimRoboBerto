using Dominio.Entidades;
using Dominio.Interface_InfraEstrutura;
using Dominio.Interface_Repositorios;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2;

namespace Infraestrutura.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly IPostgresAdaptador _postgresAdaptador;

        public UsuarioRepositorio(IPostgresAdaptador postgresAdaptador)
        {
           _postgresAdaptador = postgresAdaptador;
        }

        public void Adicionar(Usuario usuario)
        {

            using (var conexao = _postgresAdaptador.ObterConexao())
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
            using (var conexao = _postgresAdaptador.ObterConexao())
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
            using (var conexao = _postgresAdaptador.ObterConexao())
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

        public bool AtualizarSenha(string email, string novaSenha)
        {
            using (var conexao = _postgresAdaptador.ObterConexao())
            {
                conexao.Open();

                string sql = "UPDATE usuario SET senha = @senha WHERE email = @email";
                using (var cmd = new NpgsqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@senha", novaSenha);
                    cmd.Parameters.AddWithValue("@email", email);

                    int linhasAfetadas = cmd.ExecuteNonQuery();
                    return linhasAfetadas > 0;
                }
            }
        }

        public Usuario RecuperarPorEmail(string email)
        {
            using (var conexao = _postgresAdaptador.ObterConexao())
            {
                conexao.Open();

                string sql = "SELECT * from usuario where email = @email";
                using (var cmd = new NpgsqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var id = Guid.Parse(reader["id"].ToString());
                            var nome = reader["nome"].ToString();
                            var dataCriacao = Convert.ToDateTime(reader["datacriacao"]);
                            var senha = reader["senha"].ToString();
                            var _email = reader["email"].ToString();
                            return Usuario.CriarModeloDoBanco(id, dataCriacao, nome, senha, _email);
                        }
                    }
                }
            }
            return null;
        }

        public Usuario RecuperarPorNome(string nome)
        {
            using (var conexao = _postgresAdaptador.ObterConexao())
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
