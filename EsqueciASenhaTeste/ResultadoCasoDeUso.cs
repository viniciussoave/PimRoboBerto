using Aplicação.RespostaPadrao;
using Dominio.Entidades;

namespace EsqueciASenhaTeste
{
    internal class ResultadoCasoDeUso : RespostaPadrao<Usuario>
    {
        public ResultadoCasoDeUso(bool procede, string mensagem, Usuario dados) : base(procede, mensagem, dados)
        {
        }

        public bool Procede { get; set; }
    }
}