namespace WinFormsApp2
{
    partial class FormInicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio2));
            panel2 = new Panel();
            btnHistorico = new Button();
            ChatVoltar = new Button();
            btnChamadosAbertos = new Button();
            PanelChat = new Panel();
            btnVoltar = new Button();
            panel2.SuspendLayout();
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
            // btnChamadosAbertos
            // 
            btnChamadosAbertos.BackColor = Color.FromArgb(249, 239, 168);
            btnChamadosAbertos.FlatStyle = FlatStyle.Flat;
            btnChamadosAbertos.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChamadosAbertos.ImageAlign = ContentAlignment.TopCenter;
            btnChamadosAbertos.Location = new Point(42, 349);
            btnChamadosAbertos.Margin = new Padding(1);
            btnChamadosAbertos.Name = "btnChamadosAbertos";
            btnChamadosAbertos.Size = new Size(250, 40);
            btnChamadosAbertos.TabIndex = 11;
            btnChamadosAbertos.TabStop = false;
            btnChamadosAbertos.Text = "Chamados abertos";
            btnChamadosAbertos.TextImageRelation = TextImageRelation.TextAboveImage;
            btnChamadosAbertos.UseVisualStyleBackColor = false;
            btnChamadosAbertos.Click += btnChamadosAbertos_Click;
            // 
            // PanelChat
            // 
            PanelChat.BackColor = Color.FromArgb(237, 235, 191);
            PanelChat.BorderStyle = BorderStyle.FixedSingle;
            PanelChat.Location = new Point(343, 12);
            PanelChat.Name = "PanelChat";
            PanelChat.Size = new Size(353, 657);
            PanelChat.TabIndex = 13;
            PanelChat.Paint += PanelChat_Paint;
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
            BackColor = Color.White;
            ClientSize = new Size(710, 681);
            Controls.Add(btnVoltar);
            Controls.Add(PanelChat);
            Controls.Add(btnChamadosAbertos);
            Controls.Add(ChatVoltar);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(37, 221);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Historico";
            Text = "Historico";
            Load += Historico_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        public Button btnHistorico;
        public Button ChatVoltar;
        public Button btnChamadosAbertos;
        private Panel PanelChat;
        public Button btnVoltar;
    }
}