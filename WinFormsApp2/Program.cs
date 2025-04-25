using Aplicação.Casos_de_Uso;
using Aplicação.Interfaces_Caso_De_Uso;
using ConexaoBancoDeDados.Repositorio;
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
            services.AddTransient<IRegistrarUsuarioUseCase,RegistrarUsuarioUseCase>();


            services.AddTransient<FormInicio>();
            services.AddTransient<FormRegistrar>();


            return services.BuildServiceProvider();

        }
    }
}