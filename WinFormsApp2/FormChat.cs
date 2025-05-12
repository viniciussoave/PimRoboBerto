using Aplicacao.CasosDeUso;
using Dominio.Entidades;
using Dominio.Interface_Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormChat : Form
    {
        private bool _estaTrocandoTela = false;
        private bool _aguardandoConfirmacaoChamado = false;
        private FormInicio _frmInicio;
        private FormInicio2 _frmHistorico;
        private FormChamadosAbertos _frmChamadosAbertos;
        private readonly IServiceProvider _serviceProvider;
        private FlowLayoutPanel _flowPanel;
        private readonly ISolucaoRepositorio _solucaoRepositorio;
        private readonly IChamadoRepositorio _chamadoRepositorio;
        private readonly IRegistrarChamadoUseCase _registrarChamadoUseCase;



        private readonly IServicoRepositorio _servicoRepositorio;
        private List<Dominio.Entidades.Servico> _servicosCarregados;

        public FormChat(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _servicoRepositorio = _serviceProvider.GetRequiredService<IServicoRepositorio>();
            _solucaoRepositorio = _serviceProvider.GetRequiredService<ISolucaoRepositorio>();
            _chamadoRepositorio = _serviceProvider.GetRequiredService<IChamadoRepositorio>();
            _registrarChamadoUseCase = _serviceProvider.GetRequiredService<IRegistrarChamadoUseCase>();

            InitializeComponent();
            InitializeChatPanel();
            this.Load += FormChat_Load;
        }
        private void InitializeChatPanel()
        {
            // Configuração do painel de mensagens
            _flowPanel = new FlowLayoutPanel
            {
                Name = "flowPanel",
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = Color.WhiteSmoke,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(10),
                Margin = new Padding(0)
            };

            PanelMsgs.Controls.Add(_flowPanel);
        }

        private void FormChat_Load(object sender, EventArgs e)
        {

            // Anti scroll horizontal
            PanelMsgs.HorizontalScroll.Enabled = false;
            PanelMsgs.HorizontalScroll.Visible = false;
            PanelMsgs.HorizontalScroll.Maximum = 0;
            PanelMsgs.AutoScroll = true;

            // Mensagem inicial do bot com serviços do banco
            var servicos = _servicoRepositorio.ObterTodos();
            var servicosPrincipais = servicos.Where(s => s.ServicoPaiId == null).ToList();

            string mensagemInicial = "👋 Olá! Sou o RobôBerto! Seu assistente virtual de TI. Como posso ajudar?\n\nPor favor, escolha uma opção:\n";
            for (int i = 0; i < servicosPrincipais.Count; i++)
            {
                mensagemInicial += $"{i + 1}. {servicosPrincipais[i].Nome}\n";
            }

            AdicionarMensagemBot(mensagemInicial);
            _servicosCarregados = servicos;
        }


        private void AdicionarMensagemUsuario(string mensagem)
        {
            AdicionarMensagem(mensagem, "Você", Color.LightBlue, true);
        }

        private void AdicionarMensagemBot(string mensagem)
        {
            AdicionarMensagem(mensagem, "RobôBerto", Color.LightGray, false);
        }

        private void AdicionarMensagem(string texto, string remetente, Color corFundo, bool alinhamentoDireita)
        {
            var panelMsg = new Panel
            {
                BackColor = corFundo,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                MaximumSize = new Size(_flowPanel.Width - 40, 0),
                Margin = new Padding(5),
                Padding = new Padding(10),
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };

            var lblRemetente = new Label
            {
                Text = remetente,
                Font = new Font("Arial", 8, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.DarkSlateGray,
                Location = new Point(10, 5)
            };

            var lblConteudo = new Label
            {
                Text = texto,
                Font = new Font("Arial", 10),
                AutoSize = true,
                MaximumSize = new Size(panelMsg.MaximumSize.Width - 20, 0),
                Location = new Point(10, lblRemetente.Bottom + 5)
            };

            // Cálculo preciso da altura
            using (var g = panelMsg.CreateGraphics())
            {
                var textSize = g.MeasureString(texto, lblConteudo.Font, lblConteudo.MaximumSize.Width);
                lblConteudo.Height = (int)textSize.Height + 10;
                panelMsg.Height = lblConteudo.Bottom + 15;
            }

            panelMsg.Controls.Add(lblRemetente);
            panelMsg.Controls.Add(lblConteudo);

            // Alinhamento e margens
            if (alinhamentoDireita)
            {
                panelMsg.Margin = new Padding(100, 5, 20, 5);
                panelMsg.BackColor = Color.LightSteelBlue;
            }
            else
            {
                panelMsg.Margin = new Padding(20, 5, 100, 5);
            }

            _flowPanel.Controls.Add(panelMsg);
            _flowPanel.ScrollControlIntoView(panelMsg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxMsg.Text))
            {
                AdicionarMensagemUsuario(TextBoxMsg.Text);
                ProcessarRespostaUsuario(TextBoxMsg.Text);
                TextBoxMsg.Clear();
                TextBoxMsg.Focus();
            }
        }

        // Variáveis para controlar o estado
        private bool _emEscolhaFilho = false;
        private Servico _servicoPaiAtual = null;

        private void ProcessarRespostaUsuario(string resposta)
        {
            if (_aguardandoConfirmacaoChamado && resposta.Trim() == "0")
            {
                try
                {
                    // Verifica se o serviço pai está selecionado
                    if (_servicoPaiAtual == null)
                    {
                        AdicionarMensagemBot("⚠️ Erro: Nenhum serviço selecionado.");
                        return;
                    }

                    // Obtém o ID do serviço corretamente (usando a propriedade do domínio)
                    Guid idservice = _servicoPaiAtual.Id;

                    // Chama o caso de uso com os parâmetros CORRETOS
                    var resultado = _registrarChamadoUseCase.Executar(
                        idservice,
                        _servicoPaiAtual.Nome,
                        "Aberto"
                    );

                    // Exibe a mensagem de sucesso/erro
                    if (resultado.Procede)
                    {
                        // Acessa o número do chamado como int (sem formatação)
                        AdicionarMensagemBot($"✅ Chamado {resultado.Dados.numerochamado} registrado!");
                    }
                    else
                    {
                        AdicionarMensagemBot($"❌ Erro: {resultado.Mensagem}");
                    }
                }
                catch (Exception ex)
                {
                    AdicionarMensagemBot($"⚠️ Erro crítico: {ex.Message}");
                }

                // Reseta o estado
                _aguardandoConfirmacaoChamado = false;
                _servicoPaiAtual = null;
                MostrarMenuPrincipal();
                return;
            }

            // ... (restante do método permanece igual)

            if (int.TryParse(resposta.Trim(), out int numero))
            {
                // Opção 0 para voltar ao menu anterior (mantido original)
                if (numero == 0)
                {
                    MostrarMenuPrincipal();
                    _emEscolhaFilho = false;
                    _servicoPaiAtual = null;
                    return;
                }

                // Se estiver em estado de escolha de filhos (mantido original)
                if (_emEscolhaFilho)
                {
                    var servicoSelecionadoFilho = _servicoPaiAtual.Filhos.ElementAtOrDefault(numero - 1);

                    if (servicoSelecionadoFilho != null)
                    {
                        var solucoes = _solucaoRepositorio.ObterPorServicoPai(servicoSelecionadoFilho.ServicoPaiId.Value);

                        if (solucoes.Any())
                        {
                            string msgSolucoes = $"💡 Soluções para {servicoSelecionadoFilho.Nome}:\n\n";
                            for (int i = 0; i < solucoes.Count; i++)
                            {
                                msgSolucoes += $"{i + 1}. {solucoes[i].Descricao}\n";
                            }

                            // → Alterado mensagem final
                            msgSolucoes += "\nDigite 0 para abrir um chamado técnico.";

                            AdicionarMensagemBot(msgSolucoes);

                            // → Atualiza estados para próximo passo
                            _servicoPaiAtual = servicoSelecionadoFilho;
                            _emEscolhaFilho = false;
                            _aguardandoConfirmacaoChamado = true; // → NOVO estado
                        }
                        else
                        {
                            // → Alterado para criar chamado automaticamente
                            AdicionarMensagemBot("📩 Nenhuma solução encontrada. Registrando chamado...");
                            _aguardandoConfirmacaoChamado = true;
                            ProcessarRespostaUsuario("0"); // → Chama o próprio método com '0'
                        }
                        return;
                    }
                }

                // Restante do código original mantido igual ↓
                var servicoSelecionado = _servicosCarregados
                    .Where(s => s.ServicoPaiId == null)
                    .ElementAtOrDefault(numero - 1);

                if (servicoSelecionado != null)
                {
                    var filhos = servicoSelecionado.Filhos.ToList();
                    if (filhos.Any())
                    {
                        string mensagemFilhos = $"🔎 {servicoSelecionado.Nome}:\n\n";
                        for (int i = 0; i < filhos.Count; i++)
                        {
                            mensagemFilhos += $"{i + 1}. {filhos[i].Nome}\n";
                        }
                        mensagemFilhos += "0. Voltar para o menu anterior\n";
                        mensagemFilhos += "\nDigite o número correspondente ao seu problema.";
                        AdicionarMensagemBot(mensagemFilhos);
                        _emEscolhaFilho = true;
                        _servicoPaiAtual = servicoSelecionado;
                    }
                    else
                    {
                        AdicionarMensagemBot("📩 Sua solicitação foi registrada!\nUm técnico entrará em contato.");
                    }
                }
                else
                {
                    AdicionarMensagemBot("⚠️ Opção não reconhecida. Por favor:\n\n" +
                                         "1. Escolha uma opção numérica válida\n" +
                                         "2. Descreva seu problema\n" +
                                         "3. Digite 'ajuda' para ver as opções novamente");
                }
            }
            else
            {
                AdicionarMensagemBot("⚠️ Entrada inválida. Por favor, digite um número inteiro para selecionar.");
            }
        }



        private void MostrarMenuPrincipal()
        {
            // Aqui você pode chamar a lista de serviços principais novamente
            string mensagemMenuPrincipal = "🔧 Selecione o tipo de serviço:\n";
            var servicosPrincipais = _servicosCarregados
                .Where(s => s.ServicoPaiId == null)  // Filtra apenas os serviços principais
                .ToList();

            for (int i = 0; i < servicosPrincipais.Count; i++)
            {
                mensagemMenuPrincipal += $"{i + 1}. {servicosPrincipais[i].Nome}\n";
            }

            mensagemMenuPrincipal += "Digite o número correspondente ao seu problema.";
            AdicionarMensagemBot(mensagemMenuPrincipal);
        }

        private void TextBoxMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnEnviar_Click(sender, e);
                e.Handled = true;
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _estaTrocandoTela = true;
            this.Close();
            _frmInicio = _serviceProvider.GetRequiredService<FormInicio>();
            _frmInicio.StartPosition = FormStartPosition.Manual;
            _frmInicio.Location = this.Location;
            _frmInicio.Show();
        }

        private void FormChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_estaTrocandoTela)
            {
                Application.Exit();
            }
            else
            {
                _estaTrocandoTela = false;
            }
        }

        private void PanelMsgs_Paint(object sender, PaintEventArgs e)
        {
            // Desenha borda estilizada
            using (var pen = new Pen(Color.Silver, 1))
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, PanelMsgs.Width - 1, PanelMsgs.Height - 1));
            }
        }

        private void TextBoxMsg_TextChanged(object sender, EventArgs e)
        {
            // Pode adicionar lógica de sugestões aqui
        }

        private void PanelChat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChamadosAbertos_Click(object sender, EventArgs e)
        {
            _estaTrocandoTela = true;
            this.Close();
            _frmChamadosAbertos = _serviceProvider.GetRequiredService<FormChamadosAbertos>();
            _frmChamadosAbertos.StartPosition = FormStartPosition.Manual;
            _frmChamadosAbertos.Location = this.Location;
            _frmChamadosAbertos.Show();
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            // 1. Limpa todas as mensagens do chat
            _flowPanel.Controls.Clear();

            // 2. Reseta todas as variáveis de estado
            _emEscolhaFilho = false;
            _aguardandoConfirmacaoChamado = false;
            _servicoPaiAtual = null;

            // 3. Recarrega os serviços do banco de dados
            _servicosCarregados = _servicoRepositorio.ObterTodos();

            // 4. Mostra a mensagem inicial novamente
            var servicosPrincipais = _servicosCarregados.Where(s => s.ServicoPaiId == null).ToList();
            string mensagemInicial = "👋 Olá! Sou o RobôBerto! Seu assistente virtual de TI. Como posso ajudar?\n\nPor favor, escolha uma opção:\n";

            for (int i = 0; i < servicosPrincipais.Count; i++)
            {
                mensagemInicial += $"{i + 1}. {servicosPrincipais[i].Nome}\n";
            }

            AdicionarMensagemBot(mensagemInicial);
        }
    }
}
