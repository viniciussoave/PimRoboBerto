using Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace Aplicacao.Servicos
{
    public static class ServicoPredefinidoFabrica
    {
        public static List<Servico> ObterServicos()
        {
            var lista = new List<Servico>();

            // PAI: Internet
            var internet = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Acesso à Internet", null);
            var internet1 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Indisponível para navegação", internet.Id);
            var internet2 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Lentidão", internet.Id);
            internet.AdicionarFilho(internet1);
            internet.AdicionarFilho(internet2);

            // PAI: Backup
            var backup = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Backup", null);
            var backup1 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Problemas com backup", backup.Id);
            var backup2 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Restauração de backup", backup.Id);
            backup.AdicionarFilho(backup1);
            backup.AdicionarFilho(backup2);

            // PAI: CFTV
            var cftv = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "CFTV", null);
            var cftv1 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Recuperação de Gravações", cftv.Id);
            cftv.AdicionarFilho(cftv1);

            // PAI: Impressora e Scanner
            var impressora = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Impressora e scanner", null);
            var impressora1 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Configuração de impressoras", impressora.Id);
            var impressora2 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Problemas na impressora", impressora.Id);
            impressora.AdicionarFilho(impressora1);
            impressora.AdicionarFilho(impressora2);

            // PAI: Software
            var software = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Instalação de software", null);
            var software1 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Antivírus", software.Id);
            var software2 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Atualização de softwares", software.Id);
            software.AdicionarFilho(software1);
            software.AdicionarFilho(software2);

            // PAI: Hardware
            var hardware = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Problema de hardware", null);
            var hardware1 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Equipamento não liga", hardware.Id);
            var hardware2 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Identificação de problema", hardware.Id);
            var hardware3 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Lentidão e Travamento", hardware.Id);
            var hardware4 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Montagem de computador", hardware.Id);
            hardware.AdicionarFilho(hardware1);
            hardware.AdicionarFilho(hardware2);
            hardware.AdicionarFilho(hardware3);
            hardware.AdicionarFilho(hardware4);

            // PAI: Estação de trabalho
            var estacao = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Problemas na estação de trabalho", null);
            var estacao1 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Computador não conecta na rede", estacao.Id);
            var estacao2 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Configuração de computador", estacao.Id);
            var estacao3 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Pouco armazenamento na máquina", estacao.Id);
            var estacao4 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Problemas em abrir arquivos", estacao.Id);
            var estacao5 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Problemas em acessar usuário do Windows", estacao.Id);
            var estacao6 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Reinstalação de sistema operacional", estacao.Id);
            estacao.AdicionarFilho(estacao1);
            estacao.AdicionarFilho(estacao2);
            estacao.AdicionarFilho(estacao3);
            estacao.AdicionarFilho(estacao4);
            estacao.AdicionarFilho(estacao5);
            estacao.AdicionarFilho(estacao6);

            // PAI: E-mail
            var email = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Suporte ao serviço de e-mail", null);
            var email1 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Gerenciamento de grupo de e-mail", email.Id);
            var email2 = Servico.CriarModeloDoBanco(Guid.NewGuid(), DateTime.Now, "Problemas no envio de e-mail", email.Id);
            email.AdicionarFilho(email1);
            email.AdicionarFilho(email2);

            lista.AddRange(new[] {
                internet, backup, cftv, impressora, software, hardware, estacao, email
            });

            return lista;
        }
    }
}
