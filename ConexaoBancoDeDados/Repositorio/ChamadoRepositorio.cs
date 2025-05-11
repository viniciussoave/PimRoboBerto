using Dominio.Entidades;
using Dominio.Interface_conexao_banco_de_dados;
using Dominio.Interface_Repositorios;
using Npgsql;
using System;
using System.Collections.Generic;

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

        string sql = @"
            INSERT INTO chamado 
                (id, idservico, titulo, status, numerochamado, datacriacao, dataatualizacao, idusuario)
            VALUES 
                (@id, @idservico, @titulo, @status, @numerochamado, @datacriacao, @dataatualizacao, @idusuario)";

        using var cmd = new NpgsqlCommand(sql, conexao);
        cmd.Parameters.AddWithValue("@id", chamado.Id);
        cmd.Parameters.AddWithValue("@idservico", chamado.idservice);
        cmd.Parameters.AddWithValue("@titulo", chamado.titulo);
        cmd.Parameters.AddWithValue("@status", chamado.status);
        cmd.Parameters.AddWithValue("@numerochamado", chamado.numerochamado);
        cmd.Parameters.AddWithValue("@datacriacao", chamado.DataCriacao);
        cmd.Parameters.AddWithValue("@dataatualizacao", chamado.dataatualizacao);
        cmd.Parameters.AddWithValue("@idusuario", chamado.idusuario);

        cmd.ExecuteNonQuery();
    }

    public List<Chamado> ObterPorUsuario(Guid idusuario)
    {
        return ExecutarConsulta(
            "SELECT * FROM chamado WHERE idusuario = @idusuario",
            cmd => cmd.Parameters.AddWithValue("@idusuario", idusuario)
        );
    }

    private List<Chamado> ExecutarConsulta(string sql, Action<NpgsqlCommand> configurador)
    {
        var lista = new List<Chamado>();

        using var conexao = _adaptador.ObterConexao();
        conexao.Open();

        using var cmd = new NpgsqlCommand(sql, conexao);
        configurador(cmd);

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            lista.Add(Chamado.CriarModeloDoBanco(
                id: Guid.Parse(reader["id"].ToString()),
                idservice: Guid.Parse(reader["idservico"].ToString()),
                titulo: reader["titulo"].ToString(),
                status: reader["status"].ToString(),
                numerochamado: Convert.ToInt32(reader["numerochamado"]),
                datacriacao: Convert.ToDateTime(reader["datacriacao"]),
                dataatualizacao: Convert.ToDateTime(reader["dataatualizacao"]),
                idusuario: Guid.Parse(reader["idusuario"].ToString())
            ));
        }

        return lista;
    }

    public Chamado ObterPorId(Guid id)
    {
        var lista = ExecutarConsulta(
            "SELECT * FROM chamado WHERE id = @id",
            cmd => cmd.Parameters.AddWithValue("@id", id)
        );

        return lista.Count > 0 ? lista[0] : null;
    }

    public int? ObterUltimoNumeroChamado()
    {
        using var conexao = _adaptador.ObterConexao();
        conexao.Open();

        string sql = "SELECT MAX(numerochamado) FROM chamado";
        using var cmd = new NpgsqlCommand(sql, conexao);
        var result = cmd.ExecuteScalar();
        return result != DBNull.Value ? (int?)Convert.ToInt32(result) : null;
    }
}