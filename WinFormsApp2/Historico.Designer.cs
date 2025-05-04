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
            BtnFeedback = new Button();
            btnAtendente = new Button();
            btnReinicio = new Button();
            PanelChat = new Panel();
            button1 = new Button();
            btnVoltar = new Button();
            panel2.SuspendLayout();
            PanelChat.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(btnHistorico);
            panel2.Location = new Point(42, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 251);
            panel2.TabIndex = 2;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.FromArgb(249, 239, 168);
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistorico.ImageAlign = ContentAlignment.TopCenter;
            btnHistorico.Location = new Point(42, 295);
            btnHistorico.Margin = new Padding(1);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(250, 40);
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
            ChatVoltar.Location = new Point(42, 295);
            ChatVoltar.Margin = new Padding(1);
            ChatVoltar.Name = "ChatVoltar";
            ChatVoltar.Size = new Size(250, 40);
            ChatVoltar.TabIndex = 8;
            ChatVoltar.TabStop = false;
            ChatVoltar.Text = "Chat";
            ChatVoltar.TextImageRelation = TextImageRelation.TextAboveImage;
            ChatVoltar.UseVisualStyleBackColor = false;
            ChatVoltar.Click += ChatVoltar_Click;
            // 
            // BtnFeedback
            // 
            BtnFeedback.BackColor = Color.FromArgb(249, 239, 168);
            BtnFeedback.FlatStyle = FlatStyle.Flat;
            BtnFeedback.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFeedback.ImageAlign = ContentAlignment.TopCenter;
            BtnFeedback.Location = new Point(42, 349);
            BtnFeedback.Margin = new Padding(1);
            BtnFeedback.Name = "BtnFeedback";
            BtnFeedback.Size = new Size(250, 40);
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
            btnAtendente.Location = new Point(42, 401);
            btnAtendente.Margin = new Padding(1);
            btnAtendente.Name = "btnAtendente";
            btnAtendente.Size = new Size(250, 40);
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
            btnReinicio.Location = new Point(42, 461);
            btnReinicio.Margin = new Padding(1);
            btnReinicio.Name = "btnReinicio";
            btnReinicio.Size = new Size(250, 40);
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
            PanelChat.Location = new Point(343, 12);
            PanelChat.Name = "PanelChat";
            PanelChat.Size = new Size(353, 657);
            PanelChat.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Georgia", 23.8F);
            button1.Location = new Point(21, 20);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(321, 100);
            button1.TabIndex = 0;
            button1.Text = "Historico";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(249, 239, 168);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ImageAlign = ContentAlignment.TopCenter;
            btnVoltar.Location = new Point(42, 607);
            btnVoltar.Margin = new Padding(1);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(106, 40);
            btnVoltar.TabIndex = 14;
            btnVoltar.TabStop = false;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Historico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 681);
            Controls.Add(btnVoltar);
            Controls.Add(PanelChat);
            Controls.Add(btnReinicio);
            Controls.Add(btnAtendente);
            Controls.Add(BtnFeedback);
            Controls.Add(ChatVoltar);
            Controls.Add(panel2);
            Location = new Point(37, 221);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Historico";
            Text = "Historico";
            Load += Historico_Load;
            panel2.ResumeLayout(false);
            PanelChat.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        public Button btnHistorico;
        public Button ChatVoltar;
        public Button BtnFeedback;
        public Button btnAtendente;
        public Button btnReinicio;
        private Panel PanelChat;
        public Button btnVoltar;
        private Button button1;
    }
}