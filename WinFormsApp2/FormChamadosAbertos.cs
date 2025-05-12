using Aplicação.Interfaces_Caso_De_Uso_e_Servicos;
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
    public partial class FormChamadosAbertos : Form
    {
        bool _estaTrocandoTela = false;
        private readonly IListarChamadosAbertosUseCase _listarChamadosAbertosUseCase;
        private FormInicio _frmInicio;
        private FormChat _frmChat;
        private readonly IServiceProvider _serviceProvider;
        public FormChamadosAbertos(IListarChamadosAbertosUseCase listarChamadosAbertosUseCase, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _listarChamadosAbertosUseCase = listarChamadosAbertosUseCase;
            InitializeComponent();
            ConfigurarDataGrid();
        }


        private void dgvChamadosAbertos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConfigurarDataGrid()
        {
            dgvChamadosAbertos.DataSource = _listarChamadosAbertosUseCase.Executar();

            dgvChamadosAbertos.RowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White // Cor das linhas pares
            };

            // Mantendo o estilo original do cabeçalho
            dgvChamadosAbertos.EnableHeadersVisualStyles = false;
            dgvChamadosAbertos.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };

            // Configurações básicas de exibição (mantendo tamanho original)
            dgvChamadosAbertos.BorderStyle = BorderStyle.None;
            dgvChamadosAbertos.GridColor = Color.Gainsboro;

            // Remove a seleção padrão
            dgvChamadosAbertos.ClearSelection();
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

        private void FormChamadosAbertos_Load(object sender, EventArgs e)
        {

        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            _estaTrocandoTela = true;
            this.Close();
            _frmChat = _serviceProvider.GetRequiredService<FormChat>();
            _frmChat.StartPosition = FormStartPosition.Manual;
            _frmChat.Location = this.Location;
            _frmChat.Show();
        }
    }
}
