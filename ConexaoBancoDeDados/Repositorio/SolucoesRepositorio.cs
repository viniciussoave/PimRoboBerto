using Dominio.Entidades;
using Dominio.Interface_conexao_banco_de_dados;
using Dominio.Interface_Repositorios;
using Npgsql;
using System;
using System.Collections.Generic;

public class SolucaoRepositorio : ISolucaoRepositorio
{
    private readonly IPostgresAdaptador _adaptador;

    public SolucaoRepositorio(IPostgresAdaptador adaptador)
    {
        _adaptador = adaptador;
    }

    public void Inserir(Solucao solucao)
    {
        using var conexao = _adaptador.ObterConexao();
        conexao.Open();

        const string sql = @"
            INSERT INTO solucoes (id, solucao, idservicopai, datacriacao)
            VALUES (@id, @descricao, @idservicopai, @datacriacao);
        ";

        using var cmd = new NpgsqlCommand(sql, conexao);
        cmd.Parameters.AddWithValue("id", solucao.Id);
        cmd.Parameters.AddWithValue("descricao", solucao.Descricao);
        cmd.Parameters.AddWithValue("idservicopai", solucao.ServicoPaiId);
        cmd.Parameters.AddWithValue("datacriacao", solucao.DataCriacao);

        cmd.ExecuteNonQuery();
    }

    public List<Solucao> ObterPorServicoPai(Guid servicoPaiId)
    {
        using var conexao = _adaptador.ObterConexao();
        conexao.Open();

        const string sql = @"
            SELECT id, datacriacao, solucao, idservicopai
            FROM solucoes
            WHERE idservicopai = @idservicopai;
        ";

        using var cmd = new NpgsqlCommand(sql, conexao);
        cmd.Parameters.AddWithValue("idservicopai", servicoPaiId);

        var lista = new List<Solucao>();
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            var id = Guid.Parse(reader["id"].ToString());
            var dataCriacao = Convert.ToDateTime(reader["datacriacao"]);
            var descricao = reader["solucao"].ToString();
            var idServicoPai = Guid.Parse(reader["idservicopai"].ToString());

            var solucao = Solucao.CriarModeloDoBanco(id, dataCriacao, descricao, idServicoPai);
            lista.Add(solucao);
        }

        return lista;
    }
}
