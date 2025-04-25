namespace WinFormsApp2
{
    partial class FormRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrar));
            PanelMsgs = new Panel();
            textBoxEmail = new TextBox();
            textBoxSenha = new TextBox();
            labelConfirmarSenha = new Label();
            textBoxConfirmarSenha = new TextBox();
            btnVoltar = new Button();
            textBoxUsuario = new TextBox();
            btnRegistrar = new Button();
            labelSenha = new Label();
            labelUsuario = new Label();
            labelEmail = new Label();
            label1 = new Label();
            panel2 = new Panel();
            PanelMsgs.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMsgs
            // 
            PanelMsgs.BackColor = Color.FromArgb(237, 235, 191);
            PanelMsgs.BorderStyle = BorderStyle.FixedSingle;
            PanelMsgs.Controls.Add(textBoxEmail);
            PanelMsgs.Controls.Add(textBoxSenha);
            PanelMsgs.Controls.Add(labelConfirmarSenha);
            PanelMsgs.Controls.Add(textBoxConfirmarSenha);
            PanelMsgs.Controls.Add(btnVoltar);
            PanelMsgs.Controls.Add(textBoxUsuario);
            PanelMsgs.Controls.Add(btnRegistrar);
            PanelMsgs.Controls.Add(labelSenha);
            PanelMsgs.Controls.Add(labelUsuario);
            PanelMsgs.Controls.Add(labelEmail);
            PanelMsgs.Location = new Point(181, 351);
            PanelMsgs.Name = "PanelMsgs";
            PanelMsgs.Size = new Size(349, 306);
            PanelMsgs.TabIndex = 13;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(50, 219);
            textBoxEmail.MaxLength = 50;
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(249, 27);
            textBoxEmail.TabIndex = 22;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(49, 101);
            textBoxSenha.MaxLength = 20;
            textBoxSenha.Multiline = true;
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(249, 27);
            textBoxSenha.TabIndex = 18;
            textBoxSenha.TextChanged += textBoxSenha_TextChanged;
            // 
            // labelConfirmarSenha
            // 
            labelConfirmarSenha.AutoSize = true;
            labelConfirmarSenha.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelConfirmarSenha.Location = new Point(55, 125);
            labelConfirmarSenha.Name = "labelConfirmarSenha";
            labelConfirmarSenha.Size = new Size(238, 35);
            labelConfirmarSenha.TabIndex = 21;
            labelConfirmarSenha.Text = "Confirmar senha";
            // 
            // textBoxConfirmarSenha
            // 
            textBoxConfirmarSenha.Location = new Point(49, 161);
            textBoxConfirmarSenha.MaxLength = 20;
            textBoxConfirmarSenha.Multiline = true;
            textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            textBoxConfirmarSenha.PasswordChar = '*';
            textBoxConfirmarSenha.Size = new Size(249, 27);
            textBoxConfirmarSenha.TabIndex = 20;
            textBoxConfirmarSenha.TextChanged += textBoxConfirmarSenha_TextChanged;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(249, 239, 168);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ImageAlign = ContentAlignment.TopCenter;
            btnVoltar.Location = new Point(49, 253);
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
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(49, 41);
            textBoxUsuario.MaxLength = 20;
            textBoxUsuario.Multiline = true;
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(249, 27);
            textBoxUsuario.TabIndex = 11;
            textBoxUsuario.TextChanged += textBoxUsuario_TextChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(249, 239, 168);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ImageAlign = ContentAlignment.TopCenter;
            btnRegistrar.Location = new Point(181, 253);
            btnRegistrar.Margin = new Padding(1);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(119, 40);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.TabStop = false;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSenha.Location = new Point(126, 65);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(98, 35);
            labelSenha.TabIndex = 17;
            labelSenha.Text = "Senha";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(114, 7);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(121, 35);
            labelUsuario.TabIndex = 14;
            labelUsuario.Text = "Usuario";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(122, 187);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(105, 35);
            labelEmail.TabIndex = 25;
            labelEmail.Text = "E-mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 301);
            label1.Name = "label1";
            label1.Size = new Size(367, 46);
            label1.TabIndex = 15;
            label1.Text = "RoboBerto ChatBot";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(230, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 251);
            panel2.TabIndex = 14;
            // 
            // FormRegistrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(710, 681);
            Controls.Add(PanelMsgs);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormRegistrar";
            Text = "Registro - RoboBerto ChatBot";
            FormClosing += FormRegistrar_FormClosing;
            Load += FormRegistrar_Load;
            PanelMsgs.ResumeLayout(false);
            PanelMsgs.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormRegistrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_estaTrocandoTela)
            {
                Application.Exit();
            }
            else
            {
                _estaTrocandoTela = false;
            }
        }

        #endregion

        private Panel PanelMsgs;
        private TextBox textBoxEmail;
        private TextBox textBoxSenha;
        private Label labelConfirmarSenha;
        private TextBox textBoxConfirmarSenha;
        private TextBox textBoxUsuario;
        private Label labelSenha;
        private Label labelUsuario;
        public Button btnVoltar;
        public Button btnRegistrar;
        private Label label1;
        private Panel panel2;
        private Label labelEmail;
    }
}