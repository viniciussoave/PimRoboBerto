using Aplicação.Interfaces_Caso_De_Uso;
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
        private FormRegistrar _frmRegistrar;

        private readonly IRegistrarUsuarioUseCase _registrarUsuarioUseCase;
        private readonly IRealizarLoginUseCase _realizarLoginUsecase;

        public FormInicio(IRegistrarUsuarioUseCase registrarUsuarioUseCase, IRealizarLoginUseCase realizarLoginUseCase)
        {
            _realizarLoginUsecase = realizarLoginUseCase;
            _registrarUsuarioUseCase = registrarUsuarioUseCase;
            InitializeComponent();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin(_realizarLoginUsecase);
            login.StartPosition = FormStartPosition.Manual;
            login.Location = this.Location;
            login.Show();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmRegistrar = new FormRegistrar(_registrarUsuarioUseCase,_realizarLoginUsecase);
            _frmRegistrar.ShowDialog();
        }
        private void FormInicio_Load(object sender, EventArgs e)
        {
        }
    }
}
