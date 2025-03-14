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
            Application.Exit();
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
            textBoxSenha = new TextBox();
            textBoxUsuario = new TextBox();
            labelSenha = new Label();
            labelUsuario = new Label();
            btnVoltar = new Button();
            btnEntrar = new Button();
            label1 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            labelConfirmarSenha = new Label();
            textBox2 = new TextBox();
            labelEmail = new Label();
            PanelMsgs.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMsgs
            // 
            PanelMsgs.BackColor = Color.FromArgb(237, 235, 191);
            PanelMsgs.BorderStyle = BorderStyle.FixedSingle;
            PanelMsgs.Controls.Add(textBox2);
            PanelMsgs.Controls.Add(textBoxSenha);
            PanelMsgs.Controls.Add(labelConfirmarSenha);
            PanelMsgs.Controls.Add(textBox1);
            PanelMsgs.Controls.Add(btnVoltar);
            PanelMsgs.Controls.Add(textBoxUsuario);
            PanelMsgs.Controls.Add(btnEntrar);
            PanelMsgs.Controls.Add(labelSenha);
            PanelMsgs.Controls.Add(labelUsuario);
            PanelMsgs.Controls.Add(labelEmail);
            PanelMsgs.Location = new Point(180, 351);
            PanelMsgs.Name = "PanelMsgs";
            PanelMsgs.Size = new Size(350, 306);
            PanelMsgs.TabIndex = 13;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(49, 101);
            textBoxSenha.MaxLength = 29;
            textBoxSenha.Multiline = true;
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(248, 27);
            textBoxSenha.TabIndex = 18;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(49, 41);
            textBoxUsuario.MaxLength = 29;
            textBoxUsuario.Multiline = true;
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(248, 27);
            textBoxUsuario.TabIndex = 11;
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
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(249, 239, 168);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ImageAlign = ContentAlignment.TopCenter;
            btnEntrar.Location = new Point(180, 253);
            btnEntrar.Margin = new Padding(1);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(119, 40);
            btnEntrar.TabIndex = 11;
            btnEntrar.TabStop = false;
            btnEntrar.Text = "Registrar";
            btnEntrar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 302);
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
            panel2.Size = new Size(250, 250);
            panel2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 161);
            textBox1.MaxLength = 29;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(248, 27);
            textBox1.TabIndex = 20;
            // 
            // labelConfirmarSenha
            // 
            labelConfirmarSenha.AutoSize = true;
            labelConfirmarSenha.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelConfirmarSenha.Location = new Point(55, 126);
            labelConfirmarSenha.Name = "labelConfirmarSenha";
            labelConfirmarSenha.Size = new Size(238, 35);
            labelConfirmarSenha.TabIndex = 21;
            labelConfirmarSenha.Text = "Confirmar senha";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 219);
            textBox2.MaxLength = 29;
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(248, 27);
            textBox2.TabIndex = 22;
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
            Load += FormRegistrar_Load;
            PanelMsgs.ResumeLayout(false);
            PanelMsgs.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelMsgs;
        private TextBox textBox2;
        private TextBox textBoxSenha;
        private Label labelConfirmarSenha;
        private TextBox textBox1;
        private TextBox textBoxUsuario;
        private Label labelSenha;
        private Label labelUsuario;
        public Button btnVoltar;
        public Button btnEntrar;
        private Label label1;
        private Panel panel2;
        private Label labelEmail;
    }
}