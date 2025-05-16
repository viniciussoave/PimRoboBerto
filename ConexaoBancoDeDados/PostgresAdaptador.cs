
using Dominio.Interface_InfraEstrutura;

using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class PostgresAdaptador : IPostgresAdaptador
    {

  //    public NpgsqlConnection connection = new NpgsqlConnection//("Host=localhost;Port=5432;Username=postgres;Password=1234;Database=roboberto");
  //    public NpgsqlCommand command = new NpgsqlCommand();
        
 
        public NpgsqlConnection ObterConexao()
        {

            string conexao ="Host=localhost;Port=5432;Username=postgres;Password=!to5ebrc;Database=roboberto";
            NpgsqlConnection conn = new NpgsqlConnection(conexao);
            return conn;
        }

    //  public void openConnection()
    //  {
    //      if (connection.State == System.Data.ConnectionState.Closed)
    //          connection.Open();
    //  }
    //  public void closeConnection()
    //  {
    //      if (connection.State == System.Data.ConnectionState.Open)
    //          connection.Close();
    //  }
    //  public NpgsqlConnection getConnection()
    //  {
    //      return connection;
    //  }
    //
    //  public void insert(string query)
    //  {
    //      command.CommandText = query;
    //      command.Connection = connection;
    //      command.ExecuteNonQuery();
    //  }
    //
    //  public void select(List<string> results, string query)
    //  {
    //      command.CommandText = query;
    //      command.Connection = connection;
    //
    //      using (NpgsqlDataReader reader = command.ExecuteReader())
    //      {
    //          while (reader.Read())
    //          {
    //              for (int i = 0; i < reader.FieldCount; i++)
    //              {
    //                  results.Add(reader[i].ToString());
    //              }
    //          }
    //      }
    //  }
    }
}
