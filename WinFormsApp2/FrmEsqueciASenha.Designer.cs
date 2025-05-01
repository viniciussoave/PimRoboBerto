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
            txtEmail = new TextBox();
            BtnEnviarConfirmacao = new Button();
            lblInsiraEmail = new Label();
            lblInsiraCodigo = new Label();
            btnConfirmarCódigo = new Button();
            txtCodigo = new TextBox();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(33, 64);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(225, 27);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // BtnEnviarConfirmacao
            // 
            BtnEnviarConfirmacao.Location = new Point(33, 108);
            BtnEnviarConfirmacao.Name = "BtnEnviarConfirmacao";
            BtnEnviarConfirmacao.Size = new Size(225, 29);
            BtnEnviarConfirmacao.TabIndex = 1;
            BtnEnviarConfirmacao.Text = "Enviar Confirmação no email";
            BtnEnviarConfirmacao.UseVisualStyleBackColor = true;
            BtnEnviarConfirmacao.Click += BtnEnviarConfirmacao_Click;
            // 
            // lblInsiraEmail
            // 
            lblInsiraEmail.AutoSize = true;
            lblInsiraEmail.Location = new Point(33, 41);
            lblInsiraEmail.Name = "lblInsiraEmail";
            lblInsiraEmail.Size = new Size(101, 20);
            lblInsiraEmail.TabIndex = 2;
            lblInsiraEmail.Text = "Insira o email:";
            // 
            // lblInsiraCodigo
            // 
            lblInsiraCodigo.AutoSize = true;
            lblInsiraCodigo.Location = new Point(33, 161);
            lblInsiraCodigo.Name = "lblInsiraCodigo";
            lblInsiraCodigo.Size = new Size(208, 20);
            lblInsiraCodigo.TabIndex = 5;
            lblInsiraCodigo.Text = "Insira o código de verificação:";
            lblInsiraCodigo.Click += lblInsiraCodigo_Click;
            // 
            // btnConfirmarCódigo
            // 
            btnConfirmarCódigo.Location = new Point(33, 228);
            btnConfirmarCódigo.Name = "btnConfirmarCódigo";
            btnConfirmarCódigo.Size = new Size(225, 29);
            btnConfirmarCódigo.TabIndex = 4;
            btnConfirmarCódigo.Text = "Confirmar Código";
            btnConfirmarCódigo.UseVisualStyleBackColor = true;
            btnConfirmarCódigo.Click += btnConfirmarCódigo_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(33, 184);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(225, 27);
            txtCodigo.TabIndex = 3;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // FrmEsqueciASenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 453);
            Controls.Add(lblInsiraCodigo);
            Controls.Add(btnConfirmarCódigo);
            Controls.Add(txtCodigo);
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
        private Label lblInsiraCodigo;
        private Button btnConfirmarCódigo;
        private TextBox txtCodigo;
    }
}