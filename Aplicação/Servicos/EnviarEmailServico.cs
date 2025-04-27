using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Aplicação.Servicos.EnviarEmailServico;
using SendGrid.Helpers.Mail;
using System.Globalization;
using SendGrid;
using Aplicação.Interfaces_Caso_De_Uso_e_Servicos;

namespace Aplicação.Servicos
{
    public class EnviarEmailServico : IEnviarEmailServico
    {
        public async Task<bool> EnviarEmail(string emailDestino, string emailOrigem, string assunto, string corpo)
        {
            var apiKey = PegarApiKey();
            var client = new SendGridClient(apiKey);

            var origem = new EmailAddress(emailOrigem);
            var para = new EmailAddress(emailDestino);
            var mensagem = MailHelper.CreateSingleEmail(origem, para, assunto, corpo, corpo);

            try
            {
                var resposta = await client.SendEmailAsync(mensagem);

                if (resposta.StatusCode == System.Net.HttpStatusCode.Accepted)
                {
                    return true; // E-mail enviado com sucesso
                }
            }
            catch (Exception ex)
            {
                // Tratamento de erro
            }

            return false;
        }

        private string PegarApiKey()
        {
            string caminhoConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");

            if (!File.Exists(caminhoConfig))
            {
                return string.Empty;  // Retorna uma chave vazia se o arquivo não for encontrado
            }

            string[] linhas = File.ReadAllLines(caminhoConfig);
            foreach (var linha in linhas)
            {
                if (linha.StartsWith("SendGridApiKey"))
                {
                    return linha.Split('=')[1].Trim();  // Extrai a chave da linha do arquivo
                }
            }

            return string.Empty;  // Retorna vazia caso não encontre a chave
        }
    }
}
