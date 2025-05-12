// Camada: Infraestrutura (Adaptador de Saída)
// Local: Aplicação.Servicos
using Dominio.Interface_InfraEstrutura;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Aplicação.Servicos
{
    public class EnviarEmailServico : IEnviarEmailServico
    {
        private readonly SmtpConfig _config;

        public EnviarEmailServico(SmtpConfig config)
        {
            _config = config;
        }

        public async Task<bool> EnviarEmail(string destinatario, string assunto, string corpo)
        {
            try
            {
                using (var client = new SmtpClient(_config.Servidor, _config.Porta))
                {
                    client.Credentials = new NetworkCredential(_config.Usuario, _config.Senha);
                    client.EnableSsl = _config.Ssl;

                    var message = new MailMessage
                    {
                        From = new MailAddress(_config.Remetente),
                        Subject = assunto,
                        Body = corpo,
                        IsBodyHtml = true
                    };

                    message.To.Add(destinatario);

                    await client.SendMailAsync(message);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }

    // Configuração SMTP (pode ser injetada via DI)
    public class SmtpConfig
    {
        public string Servidor { get; set; } = "email-ssl.com.br";  // Servidor SMTP (ex: Gmail, Outlook)
        public int Porta { get; set; } = 587;                     // Porta do SMTP
        public string Usuario { get; set; }                       // Email DO SISTEMA (ex: suporte@suaempresa.com)
        public string Senha { get; set; }                         // Senha DO SISTEMA
        public string Remetente { get; set; }                     // Email que aparece como "De:"
        public bool Ssl { get; set; } = true;
    }
}