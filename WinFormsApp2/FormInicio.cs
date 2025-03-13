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
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Transfere o usuario da tela inicial para a tela de login
            this.Hide();
            FormLogin login = new FormLogin();
            login.StartPosition = FormStartPosition.Manual;
            login.Location = this.Location;
            login.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Transfere o usuario da tela inicial para a tela de registro
            this.Hide();
            FormRegistrar registro = new FormRegistrar();
            registro.StartPosition = FormStartPosition.Manual;
            registro.Location = this.Location;
            registro.Show();

        }
    }
}
