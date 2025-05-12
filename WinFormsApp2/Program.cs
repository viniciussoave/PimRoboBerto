using Aplicação.Casos_de_Uso;
using Aplicacao.CasosDeUso;
using Aplicação.Interfaces_Caso_De_Uso;
using Aplicação.Interfaces_Caso_De_Uso_e_Servicos;
using Aplicação.Servicos;
using Aplicacao.Servicos;
using Dominio.Interface_InfraEstrutura;
using Dominio.Interface_Repositorios;
using Infraestrutura.Repositorio;
using Infraestrutura;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace WinFormsApp2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var serviceProvider = ConfigureServices();

            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<FormInicio>());

        }

        private static ServiceProvider ConfigureServices()
        {


            var services = new ServiceCollection();
            // No Program.cs
            var smtpConfig = new SmtpConfig
            {
                Servidor = "email-ssl.com.br",
                Porta = 587,
                Usuario = "vinicius.soave@scti.com.br", // Seu e-mail de envio
                Senha = ",[R>)%A2.V+kNF<P",      // Senha específica para aplicativos
                Remetente = "vinicius.soave@scti.com.br",
                Ssl = true
            };

            services.AddSingleton(smtpConfig);

            services.AddSingleton<IUsuarioRepositorio,UsuarioRepositorio>();

            services.AddSingleton<UsuarioContexto>();
            services.AddTransient<IRegistrarUsuarioUseCase,RegistrarUsuarioUseCase>();
            services.AddTransient<IRealizarLoginUseCase, RealizarLoginUseCase>();
            services.AddTransient<IRecuperarSenhaUseCase, RecuperarSenhaUseCase>();
            services.AddTransient<IConfirmarCodigoVerificacaoUseCase, ConfirmarCodigoVerificacaoUseCase>();
            services.AddTransient<IRegistrarChamadoUseCase, RegistrarChamadoUseCase>();
            services.AddTransient<IListarChamadosAbertosUseCase,ListarChamadosAbertosUseCase>();

            services.AddSingleton<IServicoRepositorio, ServicoRepositorio>();
            services.AddSingleton<IChamadoRepositorio, ChamadoRepositorio>();
            services.AddSingleton<ISolucaoRepositorio, SolucaoRepositorio>();


            services.AddTransient<ICodigoVerificacaoServico, CodigoVerificacaoServico>();
            services.AddScoped<IEnviarEmailServico, EnviarEmailServico>();



            services.AddTransient<FormInicio>();
            services.AddTransient<FormChat>();
            services.AddTransient<FormRegistrar>();
            services.AddTransient<FormLogin>();
            services.AddTransient<FormInicio2>();
            services.AddTransient<FrmEsqueciASenha>();
            services.AddTransient<FormChamadosAbertos>();

            services.AddScoped<IPostgresAdaptador, PostgresAdaptador>();


            return services.BuildServiceProvider();

        }
    }
}