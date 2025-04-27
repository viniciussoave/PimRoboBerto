using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interface_conexao_banco_de_dados
{
    public interface IPostgresAdaptador
    {
        public NpgsqlConnection ObterConexao();
    }
}
