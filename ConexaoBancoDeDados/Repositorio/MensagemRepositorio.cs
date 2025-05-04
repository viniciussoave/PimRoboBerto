using Dominio.Entidades;
using Dominio.Interface_Repositorios;
using Dominio.Interface_conexao_banco_de_dados;
using Npgsql;
using System;
using System.Collections.Generic;

namespace ConexaoBancoDeDados.Repositorio
{
    public class MensagemRepositorio : IMensagemRepositorio
    {
        private readonly IPostgresAdaptador _adaptador;

        public MensagemRepositorio(IPostgresAdaptador adaptador)
        {
            _adaptador = adaptador;
        }

        public void Adicionar(Mensagem mensagem)
        {
            using var conexao = _adaptador.ObterConexao();
            conexao.Open();

            string sql = @"INSERT INTO mensagem (id, datacriacao, usuarioid, chamadoid, conteudo)
                           VALUES (@id, @dataCriacao, @usuarioId, @chamadoId, @conteudo)";

            using var cmd = new NpgsqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", mensagem.Id);
            cmd.Parameters.AddWithValue("@dataCriacao", mensagem.DataCriacao);
            cmd.Parameters.AddWithValue("@usuarioId", mensagem.UsuarioId);
            cmd.Parameters.AddWithValue("@chamadoId", mensagem.ChamadoId);
            cmd.Parameters.AddWithValue("@conteudo", mensagem.Conteudo);
            cmd.ExecuteNonQuery();
        }

        public List<Mensagem> ObterPorChamado(Guid chamadoId)
        {
            var lista = new List<Mensagem>();
            using var conexao = _adaptador.ObterConexao();
            conexao.Open();

            string sql = "SELECT * FROM mensagem WHERE chamadoid = @chamadoId";

            using var cmd = new NpgsqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@chamadoId", chamadoId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var id = Guid.Parse(reader["id"].ToString());
                var dataCriacao = Convert.ToDateTime(reader["datacriacao"]);
                var usuarioId = Guid.Parse(reader["usuarioid"].ToString());
                var conteudo = reader["conteudo"].ToString();

                var mensagem = Mensagem.CriarModeloDoBanco(id, dataCriacao, conteudo, usuarioId, chamadoId);
                lista.Add(mensagem);
            }

            return lista;
        }
    }
}
