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
    public partial class Historico : Form
    {

        private FormInicio _frmInicio;
        private FormChat _frmChat;
        private Historico _frmHistorico;
        private FormChamadosAbertos _frmChamadosAbertos;
        private readonly IServiceProvider _serviceProvider;
        private bool _estaTrocandoTela = false;

        public Historico(FormInicio frmInicio, IServiceProvider serviceProvider)
        {
            _frmInicio = frmInicio;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void PanelMsgs_Paint(object sender, PaintEventArgs e)
        {

        }


        private void ChatVoltar_Click(object sender, EventArgs e)
        {

            this.Close();
            _frmChat = _serviceProvider.GetRequiredService<FormChat>();
            _frmChat.StartPosition = FormStartPosition.Manual;
            _frmChat.Location = this.Location;
            _frmChat.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmInicio = _serviceProvider.GetRequiredService<FormInicio>();
            _frmInicio.StartPosition = FormStartPosition.Manual;
            _frmInicio.Location = this.Location;
            _frmInicio.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Historico_Load(object sender, EventArgs e)
        {

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
    }
}
