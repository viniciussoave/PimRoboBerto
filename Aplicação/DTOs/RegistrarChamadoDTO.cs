namespace Aplicacao.DTOs
{
    public class RegistrarChamadoDTO
    {
        public Guid UsuarioId { get; set; }
        public Guid ServicoId { get; set; }
        public string Titulo { get; set; }
        public string Status { get; set; }


    }
}
