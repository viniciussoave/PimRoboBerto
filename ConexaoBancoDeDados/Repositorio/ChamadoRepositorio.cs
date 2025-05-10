using Dominio.Entidades;
using Dominio.Interface_conexao_banco_de_dados;
using Dominio.Interface_Repositorios;
using Npgsql;

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
        return ExecutarConsulta("SELECT * FROM chamado WHERE usuarioid = @usuarioId", cmd =>
        {
            cmd.Parameters.AddWithValue("@usuarioId", usuarioId);
        });
    }

    public Chamado ObterPorId(Guid id)
    {
        var lista = ExecutarConsulta("SELECT * FROM chamado WHERE id = @id", cmd =>
        {
            cmd.Parameters.AddWithValue("@id", id);
        });

        return lista.Count > 0 ? lista[0] : null;
    }

    public int? ObterUltimoNumeroChamado()
    {
        using var conexao = _adaptador.ObterConexao();
        conexao.Open();

        string sql = "SELECT MAX(numerochamado) FROM chamado";

        using var cmd = new NpgsqlCommand(sql, conexao);
        var result = cmd.ExecuteScalar();
        return result != DBNull.Value ? (int?)result : null;
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
            var chamado = Chamado.CriarModeloDoBanco(
                id: Guid.Parse(reader["id"].ToString()),
                dataCriacao: Convert.ToDateTime(reader["datacriacao"]),
                usuarioId: Guid.Parse(reader["usuarioid"].ToString()),
                servicoId: Guid.Parse(reader["servicoid"].ToString()),
                titulo: reader["titulo"].ToString(),
                status: reader["status"].ToString(),
                numeroChamado: Convert.ToInt32(reader["numerochamado"])
            );

            lista.Add(chamado);
        }

        return lista;
    }
}
