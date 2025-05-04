namespace Aplicação.DTOs
{
    public class MensagemDTO
    {
        public Guid UsuarioId { get; set; }
        public Guid ChamadoId { get; set; }
        public string Conteudo { get; set; }

        public MensagemDTO()
        {
        }
    }


}
