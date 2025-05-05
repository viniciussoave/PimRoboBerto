using Dominio.Entidades;
using Dominio.Interface_Repositorios;
using Dominio.Interface_conexao_banco_de_dados;
using Npgsql;
using System;
using System.Collections.Generic;

namespace ConexaoBancoDeDados.Repositorio
{
    public class ChamadoRepositorio : IChamadoRepositorio
    {
        private readonly IPostgresAdaptador _adaptador;

        public ChamadoRepositorio(IPostgresAdaptador adaptador)
        {
            _adaptador = adaptador;
        }

        public void Adicionar(Chamado chamado)
        {
            using var conexao = _adaptador.ObterConexao();
            conexao.Open();

            string sql = @"INSERT INTO chamado (id, datacriacao, usuarioid, servicoid, titulo, status, numerochamado)
                           VALUES (@id, @dataCriacao, @usuarioId, @servicoId, @titulo, @status, @numeroChamado)";

            using var cmd = new NpgsqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", chamado.Id);
            cmd.Parameters.AddWithValue("@dataCriacao", chamado.DataCriacao);
            cmd.Parameters.AddWithValue("@usuarioId", chamado.UsuarioId);
            cmd.Parameters.AddWithValue("@servicoId", chamado.ServicoId);
            cmd.Parameters.AddWithValue("@titulo", chamado.Titulo);
            cmd.Parameters.AddWithValue("@status", chamado.Status);
            cmd.Parameters.AddWithValue("@numeroChamado", chamado.NumeroChamado);
            cmd.ExecuteNonQuery();
        }

        public List<Chamado> ObterPorUsuario(Guid usuarioId)
        {
            var lista = new List<Chamado>();
            using var conexao = _adaptador.ObterConexao();
            conexao.Open();

            string sql = "SELECT * FROM chamado WHERE usuarioid = @usuarioId";

            using var cmd = new NpgsqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@usuarioId", usuarioId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var id = Guid.Parse(reader["id"].ToString());
                var dataCriacao = Convert.ToDateTime(reader["datacriacao"]);
                var servicoId = Guid.Parse(reader["servicoid"].ToString());
                var titulo = reader["titulo"].ToString();
                var status = reader["status"].ToString();
                var numeroChamado = Convert.ToInt32(reader["numerochamado"]);

                var chamado = Chamado.CriarModeloDoBanco(id, dataCriacao, usuarioId, servicoId, titulo, status, numeroChamado);
                lista.Add(chamado);
            }

            return lista;
        }

        public Chamado ObterPorId(Guid id)
        {
            using var conexao = _adaptador.ObterConexao();
            conexao.Open();

            string sql = "SELECT * from chamado WHERE id = @id";

            using var cmd = new NpgsqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var dataCriacao = Convert.ToDateTime(reader["datacriacao"]);
                var usuarioId = Guid.Parse(reader["usuarioid"].ToString());
                var servicoId = Guid.Parse(reader["servicoid"].ToString());
                var titulo = reader["titulo"].ToString();
                var status = reader["status"].ToString();
                var numeroChamado = Convert.ToInt32(reader["numerochamado"]);

                return Chamado.CriarModeloDoBanco(id, dataCriacao, usuarioId, servicoId, titulo, status, numeroChamado);
            }

            return null;
        }

        public int? ObterUltimoNumeroChamado()
        {
            using var conexao = _adaptador.ObterConexao();
            conexao.Open();

            string sql = "select max(numerochamado) FROM chamado";

            using var cmd = new NpgsqlCommand(sql, conexao);
            var result = cmd.ExecuteScalar();

            return result != DBNull.Value ? (int?)result : null;
        }
    }
}
