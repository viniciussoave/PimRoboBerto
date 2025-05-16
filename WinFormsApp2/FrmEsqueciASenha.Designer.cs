namespace WinFormsApp2
{
    partial class FrmEsqueciASenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEsqueciASenha));
            txtEmail = new TextBox();
            BtnEnviarConfirmacao = new Button();
            lblInsiraEmail = new Label();
            panel2 = new Panel();
            label1 = new Label();
            PanelMsgs = new Panel();
            button1 = new Button();
            label3 = new Label();
            LabelEsqueciSenha = new Label();
            PanelMsgs.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(14, 139);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(315, 27);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // BtnEnviarConfirmacao
            // 
            BtnEnviarConfirmacao.BackColor = Color.FromArgb(249, 239, 168);
            BtnEnviarConfirmacao.FlatStyle = FlatStyle.Flat;
            BtnEnviarConfirmacao.Location = new Point(182, 260);
            BtnEnviarConfirmacao.Margin = new Padding(0);
            BtnEnviarConfirmacao.Name = "BtnEnviarConfirmacao";
            BtnEnviarConfirmacao.Size = new Size(149, 29);
            BtnEnviarConfirmacao.TabIndex = 1;
            BtnEnviarConfirmacao.Text = "Enviar";
            BtnEnviarConfirmacao.UseVisualStyleBackColor = false;
            BtnEnviarConfirmacao.Click += BtnEnviarConfirmacao_Click;
            // 
            // lblInsiraEmail
            // 
            lblInsiraEmail.AutoSize = true;
            lblInsiraEmail.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInsiraEmail.Location = new Point(16, 115);
            lblInsiraEmail.Name = "lblInsiraEmail";
            lblInsiraEmail.Size = new Size(157, 21);
            lblInsiraEmail.TabIndex = 2;
            lblInsiraEmail.Text = "Insira o seu email:";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(230, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 251);
            panel2.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 305);
            label1.Name = "label1";
            label1.Size = new Size(367, 46);
            label1.TabIndex = 22;
            label1.Text = "RoboBerto ChatBot";
            // 
            // PanelMsgs
            // 
            PanelMsgs.BackColor = Color.FromArgb(237, 235, 191);
            PanelMsgs.BorderStyle = BorderStyle.FixedSingle;
            PanelMsgs.Controls.Add(button1);
            PanelMsgs.Controls.Add(label3);
            PanelMsgs.Controls.Add(LabelEsqueciSenha);
            PanelMsgs.Controls.Add(BtnEnviarConfirmacao);
            PanelMsgs.Controls.Add(lblInsiraEmail);
            PanelMsgs.Controls.Add(txtEmail);
            PanelMsgs.Location = new Point(183, 365);
            PanelMsgs.Name = "PanelMsgs";
            PanelMsgs.Size = new Size(349, 304);
            PanelMsgs.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(249, 239, 168);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(16, 260);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(149, 29);
            button1.TabIndex = 27;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 55);
            label3.Name = "label3";
            label3.Size = new Size(313, 42);
            label3.TabIndex = 26;
            label3.Text = "Informe seu e-mail e enviaremos uma\r\nnova senha para você.";
            // 
            // LabelEsqueciSenha
            // 
            LabelEsqueciSenha.AutoSize = true;
            LabelEsqueciSenha.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelEsqueciSenha.Location = new Point(16, 14);
            LabelEsqueciSenha.Name = "LabelEsqueciSenha";
            LabelEsqueciSenha.Size = new Size(315, 32);
            LabelEsqueciSenha.TabIndex = 25;
            LabelEsqueciSenha.Text = "Esqueceu sua senha?";
            // 
            // FrmEsqueciASenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(710, 681);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(PanelMsgs);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmEsqueciASenha";
            Text = "Esqueci a senha - RoboBerto ChatBot";
            Load += FrmEsqueciASenha_Load;
            PanelMsgs.ResumeLayout(false);
            PanelMsgs.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label lblInsiraEmail;
        private Panel panel2;
        private Label label1;
        private Panel PanelMsgs;
        private Label label3;
        private Label LabelEsqueciSenha;
        public Button BtnEnviarConfirmacao;
        public Button button1;
    }
}