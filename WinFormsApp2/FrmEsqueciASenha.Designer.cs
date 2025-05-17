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
            txtEmail.Location = new Point(12, 104);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(276, 23);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // BtnEnviarConfirmacao
            // 
            BtnEnviarConfirmacao.BackColor = Color.FromArgb(249, 239, 168);
            BtnEnviarConfirmacao.FlatStyle = FlatStyle.Flat;
            BtnEnviarConfirmacao.Location = new Point(159, 195);
            BtnEnviarConfirmacao.Margin = new Padding(0);
            BtnEnviarConfirmacao.Name = "BtnEnviarConfirmacao";
            BtnEnviarConfirmacao.Size = new Size(130, 22);
            BtnEnviarConfirmacao.TabIndex = 1;
            BtnEnviarConfirmacao.Text = "Enviar";
            BtnEnviarConfirmacao.UseVisualStyleBackColor = false;
            BtnEnviarConfirmacao.Click += BtnEnviarConfirmacao_Click;
            // 
            // lblInsiraEmail
            // 
            lblInsiraEmail.AutoSize = true;
            lblInsiraEmail.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInsiraEmail.Location = new Point(14, 86);
            lblInsiraEmail.Name = "lblInsiraEmail";
            lblInsiraEmail.Size = new Size(132, 18);
            lblInsiraEmail.TabIndex = 2;
            lblInsiraEmail.Text = "Insira o seu email:";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(201, 39);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 188);
            panel2.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 229);
            label1.Name = "label1";
            label1.Size = new Size(292, 38);
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
            PanelMsgs.Location = new Point(160, 274);
            PanelMsgs.Margin = new Padding(3, 2, 3, 2);
            PanelMsgs.Name = "PanelMsgs";
            PanelMsgs.Size = new Size(306, 228);
            PanelMsgs.TabIndex = 21;
            PanelMsgs.Paint += PanelMsgs_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(249, 239, 168);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(14, 195);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(130, 22);
            button1.TabIndex = 27;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 41);
            label3.Name = "label3";
            label3.Size = new Size(264, 36);
            label3.TabIndex = 26;
            label3.Text = "Informe seu e-mail e enviaremos uma\r\nnova senha para você.";
            label3.Click += label3_Click;
            // 
            // LabelEsqueciSenha
            // 
            LabelEsqueciSenha.AutoSize = true;
            LabelEsqueciSenha.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelEsqueciSenha.Location = new Point(14, 10);
            LabelEsqueciSenha.Name = "LabelEsqueciSenha";
            LabelEsqueciSenha.Size = new Size(251, 27);
            LabelEsqueciSenha.TabIndex = 25;
            LabelEsqueciSenha.Text = "Esqueceu sua senha?";
            // 
            // FrmEsqueciASenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(621, 511);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(PanelMsgs);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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