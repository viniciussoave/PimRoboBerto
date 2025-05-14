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
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(31, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 251);
            panel2.TabIndex = 20;
            // 
            // FrmEsqueciASenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 681);
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
        private Panel panel2;
    }
}