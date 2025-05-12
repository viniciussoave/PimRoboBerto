using Dominio.Entidades;
using Dominio.Interface_InfraEstrutura;
using Dominio.Interface_Repositorios;
using Npgsql;


namespace Infraestrutura.Repositorio
{
    public class ServicoRepositorio : IServicoRepositorio
    {
        private readonly IPostgresAdaptador _adaptador;

        public ServicoRepositorio(IPostgresAdaptador adaptador)
        {
            _adaptador = adaptador;
        }

        public List<Servico> ObterTodos()
        {
            using var conexao = _adaptador.ObterConexao();
            conexao.Open();

            var servicos = new Dictionary<Guid, Servico>();

            string sql = @"SELECT id, datacriacao, nome, idpai FROM servico";

            using var cmd = new NpgsqlCommand(sql, conexao);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var id = Guid.Parse(reader["id"].ToString());
                var dataCriacao = Convert.ToDateTime(reader["datacriacao"]);
                var nome = reader["nome"].ToString();
                var servicoPaiId = reader["idpai"] == DBNull.Value ? (Guid?)null : Guid.Parse(reader["idpai"].ToString());

                var servico = Servico.CriarModeloDoBanco(id, dataCriacao, nome, servicoPaiId);
                servicos[id] = servico;
            }

            // Reorganiza hierarquia (pai e filhos)
            foreach (var servico in servicos.Values)
            {
                if (servico.ServicoPaiId != null && servicos.ContainsKey(servico.ServicoPaiId.Value))
                {
                    var pai = servicos[servico.ServicoPaiId.Value];
                    pai.AdicionarFilho(servico); // Adiciona o filho ao pai
                }
            }

            // Retorna todos os serviços, não apenas os pais
            return servicos.Values.ToList();
        }
    }

}