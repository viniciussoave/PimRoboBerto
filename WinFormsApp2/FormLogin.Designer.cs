namespace WinFormsApp2
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            btnEntrar = new Button();
            panel2 = new Panel();
            PanelMsgs = new Panel();
            textBoxSenha = new TextBox();
            textBoxUsuario = new TextBox();
            labelSenha = new Label();
            labelUsuario = new Label();
            btnVoltar = new Button();
            label1 = new Label();
            PanelMsgs.SuspendLayout();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(249, 239, 168);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ImageAlign = ContentAlignment.TopCenter;
            btnEntrar.Location = new Point(191, 165);
            btnEntrar.Margin = new Padding(1);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(106, 40);
            btnEntrar.TabIndex = 11;
            btnEntrar.TabStop = false;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(230, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 250);
            panel2.TabIndex = 10;
            // 
            // PanelMsgs
            // 
            PanelMsgs.BackColor = Color.FromArgb(237, 235, 191);
            PanelMsgs.BorderStyle = BorderStyle.FixedSingle;
            PanelMsgs.Controls.Add(textBoxSenha);
            PanelMsgs.Controls.Add(textBoxUsuario);
            PanelMsgs.Controls.Add(labelSenha);
            PanelMsgs.Controls.Add(labelUsuario);
            PanelMsgs.Controls.Add(btnVoltar);
            PanelMsgs.Controls.Add(btnEntrar);
            PanelMsgs.Location = new Point(180, 396);
            PanelMsgs.Name = "PanelMsgs";
            PanelMsgs.Size = new Size(350, 220);
            PanelMsgs.TabIndex = 9;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(50, 108);
            textBoxSenha.MaxLength = 29;
            textBoxSenha.Multiline = true;
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(248, 37);
            textBoxSenha.TabIndex = 18;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(49, 32);
            textBoxUsuario.MaxLength = 29;
            textBoxUsuario.Multiline = true;
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(248, 37);
            textBoxUsuario.TabIndex = 11;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSenha.Location = new Point(125, 73);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(98, 35);
            labelSenha.TabIndex = 17;
            labelSenha.Text = "Senha";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(114, -2);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(121, 35);
            labelUsuario.TabIndex = 14;
            labelUsuario.Text = "Usuario";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(249, 239, 168);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ImageAlign = ContentAlignment.TopCenter;
            btnVoltar.Location = new Point(47, 165);
            btnVoltar.Margin = new Padding(1);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(106, 40);
            btnVoltar.TabIndex = 12;
            btnVoltar.TabStop = false;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 314);
            label1.Name = "label1";
            label1.Size = new Size(367, 46);
            label1.TabIndex = 12;
            label1.Text = "RoboBerto ChatBot";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(710, 681);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(PanelMsgs);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            Text = "Login - RoboBerto ChatBot";
            FormClosing += FormLogin_FormClosing;
            Load += Form1_Load;
            PanelMsgs.ResumeLayout(false);
            PanelMsgs.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Isso faz uma verificação se o usuario esta trocando de tela ou se ele encerrou essa janela.
            if (!_estaTrocandoTela)
            {
                Application.Exit();
            } else
            {
                _estaTrocandoTela = false;
            }
        }

        #endregion

        public Button btnEntrar;
        private Panel panel2;
        private Panel PanelMsgs;
        public Button btnVoltar;
        private Label labelUsuario;
        private TextBox textBoxUsuario;
        private Label labelSenha;
        private TextBox textBoxSenha;
        private Label label1;
    }
}