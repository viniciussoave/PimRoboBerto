using Dominio.Entidades;
using Dominio.Interface_Repositorios;
using Dominio.Interface_conexao_banco_de_dados;
using Npgsql;
using System;
using System.Collections.Generic;

namespace ConexaoBancoDeDados.Repositorio
{
    public class ServicoRepositorio : IServicoRepositorio
    {
        private readonly IPostgresAdaptador _adaptador;

        public ServicoRepositorio(IPostgresAdaptador adaptador)
        {
            _adaptador = adaptador;
        }

        public Servico ObterPorId(Guid id)
        {
            using var conexao = _adaptador.ObterConexao();
            conexao.Open();

            string sql = "SELECT * FROM servico WHERE id = @id";

            using var cmd = new NpgsqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var nome = reader["nome"].ToString();
                var dataCriacao = Convert.ToDateTime(reader["datacriacao"]);
                Guid? paiId = reader["servico_pai_id"] is DBNull ? null : Guid.Parse(reader["servico_pai_id"].ToString());

                return Servico.CriarModeloDoBanco(id, dataCriacao, nome, paiId);
            }

            return null;
        }

        public List<Servico> ObterTodos()
        {
            var lista = new List<Servico>();
            using var conexao = _adaptador.ObterConexao();
            conexao.Open();

            string sql = "SELECT * FROM servico";

            using var cmd = new NpgsqlCommand(sql, conexao);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var id = Guid.Parse(reader["id"].ToString());
                var nome = reader["nome"].ToString();
                var dataCriacao = Convert.ToDateTime(reader["datacriacao"]);
                Guid? paiId = reader["servico_pai_id"] is DBNull ? null : Guid.Parse(reader["servico_pai_id"].ToString());

                var servico = Servico.CriarModeloDoBanco(id, dataCriacao, nome, paiId);
                lista.Add(servico);
            }

            return lista;
        }
    }
}
