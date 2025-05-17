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
            PanelMsgs.Location = new Point(158, 263);
            PanelMsgs.Margin = new Padding(3, 2, 3, 2);
            PanelMsgs.Name = "PanelMsgs";
            PanelMsgs.Size = new Size(306, 230);
            PanelMsgs.TabIndex = 13;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(44, 164);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.MaxLength = 50;
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(218, 21);
            textBoxEmail.TabIndex = 22;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(43, 76);
            textBoxSenha.Margin = new Padding(3, 2, 3, 2);
            textBoxSenha.MaxLength = 20;
            textBoxSenha.Multiline = true;
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(218, 21);
            textBoxSenha.TabIndex = 18;
            textBoxSenha.TextChanged += textBoxSenha_TextChanged;
            // 
            // labelConfirmarSenha
            // 
            labelConfirmarSenha.AutoSize = true;
            labelConfirmarSenha.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelConfirmarSenha.Location = new Point(48, 94);
            labelConfirmarSenha.Name = "labelConfirmarSenha";
            labelConfirmarSenha.Size = new Size(191, 29);
            labelConfirmarSenha.TabIndex = 21;
            labelConfirmarSenha.Text = "Confirmar senha";
            labelConfirmarSenha.Click += labelConfirmarSenha_Click;
            // 
            // textBoxConfirmarSenha
            // 
            textBoxConfirmarSenha.Location = new Point(43, 121);
            textBoxConfirmarSenha.Margin = new Padding(3, 2, 3, 2);
            textBoxConfirmarSenha.MaxLength = 20;
            textBoxConfirmarSenha.Multiline = true;
            textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            textBoxConfirmarSenha.PasswordChar = '*';
            textBoxConfirmarSenha.Size = new Size(218, 21);
            textBoxConfirmarSenha.TabIndex = 20;
            textBoxConfirmarSenha.TextChanged += textBoxConfirmarSenha_TextChanged;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(249, 239, 168);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ImageAlign = ContentAlignment.TopCenter;
            btnVoltar.Location = new Point(43, 190);
            btnVoltar.Margin = new Padding(1);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(93, 30);
            btnVoltar.TabIndex = 12;
            btnVoltar.TabStop = false;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(43, 31);
            textBoxUsuario.Margin = new Padding(3, 2, 3, 2);
            textBoxUsuario.MaxLength = 20;
            textBoxUsuario.Multiline = true;
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(218, 21);
            textBoxUsuario.TabIndex = 11;
            textBoxUsuario.TextChanged += textBoxUsuario_TextChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(249, 239, 168);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ImageAlign = ContentAlignment.TopCenter;
            btnRegistrar.Location = new Point(158, 190);
            btnRegistrar.Margin = new Padding(1);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(104, 30);
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
            labelSenha.Location = new Point(110, 49);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(78, 29);
            labelSenha.TabIndex = 17;
            labelSenha.Text = "Senha";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(100, 5);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(97, 29);
            labelUsuario.TabIndex = 14;
            labelUsuario.Text = "Usuario";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(107, 140);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(85, 29);
            labelEmail.TabIndex = 25;
            labelEmail.Text = "E-mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 226);
            label1.Name = "label1";
            label1.Size = new Size(292, 38);
            label1.TabIndex = 15;
            label1.Text = "RoboBerto ChatBot";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(201, 30);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 188);
            panel2.TabIndex = 14;
            // 
            // FormRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(621, 511);
            Controls.Add(PanelMsgs);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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