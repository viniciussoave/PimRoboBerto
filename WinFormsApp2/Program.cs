using Aplicação.Casos_de_Uso;
using Aplicacao.CasosDeUso;
using Aplicação.Interfaces_Caso_De_Uso;
using Aplicação.Interfaces_Caso_De_Uso_e_Servicos;
using Aplicação.Servicos;
using Aplicacao.Servicos;
using ConexaoBancoDeDados.Repositorio;
using Dominio.Interface_conexao_banco_de_dados;
using Dominio.Interface_Repositorios;
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

            services.AddSingleton<IUsuarioRepositorio,UsuarioRepositorio>();

            services.AddSingleton<UsuarioContexto>();
            services.AddTransient<IRegistrarUsuarioUseCase,RegistrarUsuarioUseCase>();
            services.AddTransient<IRealizarLoginUseCase, RealizarLoginUseCase>();
            services.AddTransient<IRecuperarSenhaUseCase, RecuperarSenhaUseCase>();
            services.AddTransient<IConfirmarCodigoVerificacaoUseCase, ConfirmarCodigoVerificacaoUseCase>();
            services.AddTransient<IRegistrarChamadoUseCase, RegistrarChamadoUseCase>();

            services.AddSingleton<IServicoRepositorio, ServicoRepositorio>();
            services.AddSingleton<IChamadoRepositorio, ChamadoRepositorio>();
            services.AddSingleton<ISolucaoRepositorio, SolucaoRepositorio>();

            services.AddTransient<ICodigoVerificacaoServico, CodigoVerificacaoServico>();
            services.AddScoped<IEnviarEmailServico, EnviarEmailServico>();



            services.AddTransient<FormInicio>();
            services.AddTransient<FormChat>();
            services.AddTransient<FormRegistrar>();
            services.AddTransient<FormLogin>();
            services.AddTransient<Historico>();
            services.AddTransient<FrmEsqueciASenha>();
            services.AddScoped<IPostgresAdaptador, PostgresAdaptador>();


            return services.BuildServiceProvider();

        }
    }
}