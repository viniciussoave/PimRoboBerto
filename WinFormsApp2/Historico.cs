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
        private bool _estaTrocandoTela = false;
        public Historico()
        {
            InitializeComponent();
        }

        private void PanelMsgs_Paint(object sender, PaintEventArgs e)
        {

        }



        private void ChatVoltar_Click(object sender, EventArgs e)
        {

            this.Close();
            FormChat chat2 = new FormChat();
            chat2.StartPosition = FormStartPosition.Manual;
            chat2.Location = this.Location;
            chat2.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicio Inicio = new FormInicio();
            Inicio.StartPosition = FormStartPosition.Manual;
            Inicio.Location = this.Location;
            Inicio.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
