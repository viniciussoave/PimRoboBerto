using Aplicação.Interfaces_Caso_De_Uso;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormInicio : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private FormRegistrar _formRegistrar;
        private FormLogin _formLogin;
        private IServiceProvider @object;

        public FormInicio()
        {
        }

        public FormInicio(IServiceProvider @object)
        {
            this.@object = @object;
        }

        public FormInicio(IRealizarLoginUseCase realizarLoginUseCase, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            _formLogin = _serviceProvider.GetRequiredService<FormLogin>();
            _formLogin.StartPosition = FormStartPosition.Manual;
            _formLogin.Location = this.Location;
            _formLogin.Show();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide(); // escondo o formulario anterior 
            _formRegistrar = _serviceProvider.GetRequiredService<FormRegistrar>(); // chamo a instancia
            _formRegistrar.ShowDialog(); // mostro o novo
        }
        private void FormInicio_Load(object sender, EventArgs e)
        {
        }

        private void PanelMsgs_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
