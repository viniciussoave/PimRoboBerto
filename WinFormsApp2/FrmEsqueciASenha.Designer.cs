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
            btnChat = new Button();
            panel2 = new Panel();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(344, 65);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(225, 27);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // BtnEnviarConfirmacao
            // 
            BtnEnviarConfirmacao.Location = new Point(344, 109);
            BtnEnviarConfirmacao.Name = "BtnEnviarConfirmacao";
            BtnEnviarConfirmacao.Size = new Size(225, 29);
            BtnEnviarConfirmacao.TabIndex = 1;
            BtnEnviarConfirmacao.Text = "Enviar código no email";
            BtnEnviarConfirmacao.UseVisualStyleBackColor = true;
            BtnEnviarConfirmacao.Click += BtnEnviarConfirmacao_Click;
            // 
            // lblInsiraEmail
            // 
            lblInsiraEmail.AutoSize = true;
            lblInsiraEmail.Location = new Point(344, 42);
            lblInsiraEmail.Name = "lblInsiraEmail";
            lblInsiraEmail.Size = new Size(101, 20);
            lblInsiraEmail.TabIndex = 2;
            lblInsiraEmail.Text = "Insira o email:";
            // 
            // btnChat
            // 
            btnChat.BackColor = Color.FromArgb(249, 239, 168);
            btnChat.FlatStyle = FlatStyle.Flat;
            btnChat.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChat.ImageAlign = ContentAlignment.TopCenter;
            btnChat.Location = new Point(31, 301);
            btnChat.Margin = new Padding(1);
            btnChat.Name = "btnChat";
            btnChat.Size = new Size(250, 40);
            btnChat.TabIndex = 21;
            btnChat.TabStop = false;
            btnChat.Text = "Chat";
            btnChat.TextImageRelation = TextImageRelation.TextAboveImage;
            btnChat.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(31, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 251);
            panel2.TabIndex = 20;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(249, 239, 168);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ImageAlign = ContentAlignment.TopCenter;
            btnVoltar.Location = new Point(43, 471);
            btnVoltar.Margin = new Padding(1);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(106, 40);
            btnVoltar.TabIndex = 22;
            btnVoltar.TabStop = false;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // FrmEsqueciASenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 681);
            Controls.Add(btnVoltar);
            Controls.Add(btnChat);
            Controls.Add(panel2);
            Controls.Add(lblInsiraEmail);
            Controls.Add(BtnEnviarConfirmacao);
            Controls.Add(txtEmail);
            Name = "FrmEsqueciASenha";
            Text = "FrmEsqueciASenha";
            Load += FrmEsqueciASenha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Button BtnEnviarConfirmacao;
        private Label lblInsiraEmail;
        public Button btnChat;
        private Panel panel2;
        public Button btnVoltar;
    }
}