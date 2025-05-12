using Aplicacao.DTOs;
using Aplicação.Interfaces_Caso_De_Uso_e_Servicos;
using Dominio.Interface_Repositorios;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação.Casos_de_Uso
{
    public class ListarChamadosAbertosUseCase : IListarChamadosAbertosUseCase
    {
        private readonly IChamadoRepositorio _chamadoRepositorio;

        public ListarChamadosAbertosUseCase(IChamadoRepositorio chamadoRepositorio)
        {
            _chamadoRepositorio = chamadoRepositorio;
        }

        public List<ChamadoDTO> Executar()
        {
            try
            {
                var listaChamadosAbertos = _chamadoRepositorio.ListarTodos();
                var listaChamadosDto = listaChamadosAbertos.Select(a => new ChamadoDTO
                {
                    ServicoId = a.idservice,
                    Status = a.status,
                    Titulo = a.titulo,
                    UsuarioId = a.idusuario,
                    NumeroChamado = a.numerochamado.ToString("D4")
                });

                return listaChamadosDto.ToList();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Erro ao realizar consulta no banco de dados");
            }

            return null;

        }

    }
}
