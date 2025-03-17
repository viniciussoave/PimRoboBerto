namespace WinFormsApp2
{
    partial class Historico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historico));
            panel2 = new Panel();
            btnHistorico = new Button();
            ChatVoltar = new Button();
            btnAjuda = new Button();
            BtnFeedback = new Button();
            btnAtendente = new Button();
            btnReinicio = new Button();
            PanelChat = new Panel();
            btnVoltar = new Button();
            button1 = new Button();
            panel2.SuspendLayout();
            PanelChat.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(btnHistorico);
            panel2.Location = new Point(37, 9);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 188);
            panel2.TabIndex = 2;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.FromArgb(249, 239, 168);
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistorico.ImageAlign = ContentAlignment.TopCenter;
            btnHistorico.Location = new Point(37, 221);
            btnHistorico.Margin = new Padding(1);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(219, 30);
            btnHistorico.TabIndex = 8;
            btnHistorico.TabStop = false;
            btnHistorico.Text = "Historico";
            btnHistorico.TextImageRelation = TextImageRelation.TextAboveImage;
            btnHistorico.UseVisualStyleBackColor = false;
            // 
            // ChatVoltar
            // 
            ChatVoltar.BackColor = Color.FromArgb(249, 239, 168);
            ChatVoltar.FlatStyle = FlatStyle.Flat;
            ChatVoltar.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChatVoltar.ImageAlign = ContentAlignment.TopCenter;
            ChatVoltar.Location = new Point(37, 221);
            ChatVoltar.Margin = new Padding(1);
            ChatVoltar.Name = "ChatVoltar";
            ChatVoltar.Size = new Size(219, 30);
            ChatVoltar.TabIndex = 8;
            ChatVoltar.TabStop = false;
            ChatVoltar.Text = "Chat";
            ChatVoltar.TextImageRelation = TextImageRelation.TextAboveImage;
            ChatVoltar.UseVisualStyleBackColor = false;
            ChatVoltar.Click += ChatVoltar_Click;
            // 
            // btnAjuda
            // 
            btnAjuda.BackColor = Color.FromArgb(249, 239, 168);
            btnAjuda.FlatStyle = FlatStyle.Flat;
            btnAjuda.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjuda.ImageAlign = ContentAlignment.TopCenter;
            btnAjuda.Location = new Point(37, 261);
            btnAjuda.Margin = new Padding(1);
            btnAjuda.Name = "btnAjuda";
            btnAjuda.Size = new Size(219, 30);
            btnAjuda.TabIndex = 9;
            btnAjuda.TabStop = false;
            btnAjuda.Text = "Ajuda";
            btnAjuda.TextImageRelation = TextImageRelation.TextAboveImage;
            btnAjuda.UseVisualStyleBackColor = false;
            // 
            // BtnFeedback
            // 
            BtnFeedback.BackColor = Color.FromArgb(249, 239, 168);
            BtnFeedback.FlatStyle = FlatStyle.Flat;
            BtnFeedback.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFeedback.ImageAlign = ContentAlignment.TopCenter;
            BtnFeedback.Location = new Point(37, 300);
            BtnFeedback.Margin = new Padding(1);
            BtnFeedback.Name = "BtnFeedback";
            BtnFeedback.Size = new Size(219, 30);
            BtnFeedback.TabIndex = 10;
            BtnFeedback.TabStop = false;
            BtnFeedback.Text = "Feedback";
            BtnFeedback.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnFeedback.UseVisualStyleBackColor = false;
            // 
            // btnAtendente
            // 
            btnAtendente.BackColor = Color.FromArgb(249, 239, 168);
            btnAtendente.FlatStyle = FlatStyle.Flat;
            btnAtendente.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtendente.ImageAlign = ContentAlignment.TopCenter;
            btnAtendente.Location = new Point(37, 339);
            btnAtendente.Margin = new Padding(1);
            btnAtendente.Name = "btnAtendente";
            btnAtendente.Size = new Size(219, 30);
            btnAtendente.TabIndex = 11;
            btnAtendente.TabStop = false;
            btnAtendente.Text = "Atendente";
            btnAtendente.TextImageRelation = TextImageRelation.TextAboveImage;
            btnAtendente.UseVisualStyleBackColor = false;
            // 
            // btnReinicio
            // 
            btnReinicio.BackColor = Color.FromArgb(249, 239, 168);
            btnReinicio.FlatStyle = FlatStyle.Flat;
            btnReinicio.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReinicio.ImageAlign = ContentAlignment.TopCenter;
            btnReinicio.Location = new Point(37, 378);
            btnReinicio.Margin = new Padding(1);
            btnReinicio.Name = "btnReinicio";
            btnReinicio.Size = new Size(219, 30);
            btnReinicio.TabIndex = 12;
            btnReinicio.TabStop = false;
            btnReinicio.Text = "Reinicio";
            btnReinicio.TextImageRelation = TextImageRelation.TextAboveImage;
            btnReinicio.UseVisualStyleBackColor = false;
            // 
            // PanelChat
            // 
            PanelChat.BackColor = Color.FromArgb(237, 235, 191);
            PanelChat.BorderStyle = BorderStyle.FixedSingle;
            PanelChat.Controls.Add(button1);
            PanelChat.Location = new Point(300, 9);
            PanelChat.Margin = new Padding(3, 2, 3, 2);
            PanelChat.Name = "PanelChat";
            PanelChat.Size = new Size(309, 493);
            PanelChat.TabIndex = 13;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(249, 239, 168);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ImageAlign = ContentAlignment.TopCenter;
            btnVoltar.Location = new Point(37, 455);
            btnVoltar.Margin = new Padding(1);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(93, 30);
            btnVoltar.TabIndex = 14;
            btnVoltar.TabStop = false;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Georgia", 23.8F);
            button1.Location = new Point(18, 15);
            button1.Name = "button1";
            button1.Size = new Size(281, 75);
            button1.TabIndex = 0;
            button1.Text = "Historico";
            button1.UseVisualStyleBackColor = true;
            // 
            // Historico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 511);
            Controls.Add(btnVoltar);
            Controls.Add(PanelChat);
            Controls.Add(btnReinicio);
            Controls.Add(btnAtendente);
            Controls.Add(BtnFeedback);
            Controls.Add(btnAjuda);
            Controls.Add(ChatVoltar);
            Controls.Add(panel2);
            Location = new Point(37, 221);
            Name = "Historico";
            Text = "Historico";
            panel2.ResumeLayout(false);
            PanelChat.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        public Button btnHistorico;
        public Button ChatVoltar;
        public Button btnAjuda;
        public Button BtnFeedback;
        public Button btnAtendente;
        public Button btnReinicio;
        private Panel PanelChat;
        public Button btnVoltar;
        private Button button1;
    }
}