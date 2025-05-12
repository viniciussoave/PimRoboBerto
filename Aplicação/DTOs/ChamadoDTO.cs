namespace Aplicacao.DTOs
{
    public class ChamadoDTO
    {
        public Guid UsuarioId { get; set; }
        public Guid ServicoId { get; set; }
        public string Titulo { get; set; }
        public string Status { get; set; }

        public string NumeroChamado { get; set; }
        public ChamadoDTO()
        {
        }
    }
}
