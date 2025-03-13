using System.Drawing.Drawing2D;

namespace WinFormsApp2
{
    public partial class FormChat : Form
    {
        private bool _estaTrocandoTela = false;
        public FormChat()
        {
            InitializeComponent();
        }

        private void adsadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelMsgs.AutoScroll = true;
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            Panel BoxMsg = new Panel();
            Label EnvText = new Label();
            Label MsgText = new Label();

            if (TextBoxMsg.Text.Length == 0)
            {
                //Faz nada porque não tem nada na parte da msg
            }
            else
            {
                EnvText.Text = "Robo";
                EnvText.Location = new Point(0, 0);
                MsgText.Text = TextBoxMsg.Text;
                MsgText.AutoSize = true;
                //Fazer a porra do paneil do chat mudar o tamanho dependendo da msg
                var maxWidth = 344;
                var minWidth = 50;
                if (TextBoxMsg.Text.Length < 5)
                {
                    BoxMsg.Size = new Size(minWidth, 50);
                }
                else
                {
                    if (TextBoxMsg.Text.Length >= 30)
                    {
                        BoxMsg.Size = new Size(maxWidth, 50);
                    }
                    else
                    {
                        BoxMsg.Size = new Size(10 * TextBoxMsg.Text.Length, 50);
                    }
                }

                MsgText.Location = new Point(0, 20);
                TextBoxMsg.Text = "";
                BoxMsg.Location = new Point(0, 55 * PanelMsgs.Controls.Count);
                BoxMsg.BackColor = Color.White;
                BoxMsg.Controls.Add(EnvText);
                BoxMsg.Controls.Add(MsgText);
                PanelMsgs.Controls.Add(BoxMsg);
                //PanelMsgs.Controls.Add(MsgText);
            }
        }

        private void FormChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_estaTrocandoTela)
            {
                Application.Exit();
            } else
            {
                _estaTrocandoTela = false;
            }
        }
    }
}
