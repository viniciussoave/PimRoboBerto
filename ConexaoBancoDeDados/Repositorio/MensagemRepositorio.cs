using Dominio.Entidades;
using Dominio.Interface_Repositorios;
using Npgsql;
using System;
using System.Collections.Generic;
using Dominio.Interface_InfraEstrutura;

namespace Infraestrutura.Repositorio
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

            string sql = @"INSERT INTO mensagem (id, datacriacao, usuarioid, chamadoid, conteudo, nummensagem)
                           VALUES (@id, @dataCriacao, @usuarioId, @chamadoId, @conteudo, @numMensagem)";

            using var cmd = new NpgsqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", mensagem.Id);
            cmd.Parameters.AddWithValue("@dataCriacao", mensagem.DataCriacao);
            cmd.Parameters.AddWithValue("@usuarioId", mensagem.UsuarioId);
            cmd.Parameters.AddWithValue("@chamadoId", mensagem.ChamadoId);
            cmd.Parameters.AddWithValue("@conteudo", mensagem.Conteudo);
            cmd.Parameters.AddWithValue("@numMensagem", mensagem.NumMensagem);
            cmd.ExecuteNonQuery();
        }

        public List<Mensagem> ObterPorChamado(Guid chamadoId)
        {
            var lista = new List<Mensagem>();
            using var conexao = _adaptador.ObterConexao();
            conexao.Open();

            string sql = @"SELECT * FROM mensagem 
                           WHERE chamadoid = @chamadoId 
                           ORDER BY nummensagem ASC";

            using var cmd = new NpgsqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@chamadoId", chamadoId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var id = Guid.Parse(reader["id"].ToString());
                var dataCriacao = Convert.ToDateTime(reader["datacriacao"]);
                var usuarioId = Guid.Parse(reader["usuarioid"].ToString());
                var conteudo = reader["conteudo"].ToString();
                var numMensagem = Convert.ToInt32(reader["nummensagem"]);

                var mensagem = Mensagem.CriarModeloDoBanco(id, dataCriacao, usuarioId, chamadoId, conteudo, numMensagem);
                lista.Add(mensagem);
            }

            return lista;
        }
    }
}
