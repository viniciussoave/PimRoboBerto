namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            btnAjuda = new Button();
            BtnFeedback = new Button();
            btnAtendente = new Button();
            btnReinicio = new Button();
            btnHistorico = new Button();
            PanelChat = new Panel();
            PanelMsgs = new Panel();
            BtnEnviar = new Button();
            TextBoxMsg = new RichTextBox();
            PanelChat.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(42, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 250);
            panel2.TabIndex = 1;
            // 
            // btnAjuda
            // 
            btnAjuda.BackColor = Color.FromArgb(249, 239, 168);
            btnAjuda.FlatStyle = FlatStyle.Flat;
            btnAjuda.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjuda.ImageAlign = ContentAlignment.TopCenter;
            btnAjuda.Location = new Point(42, 348);
            btnAjuda.Margin = new Padding(1);
            btnAjuda.Name = "btnAjuda";
            btnAjuda.Size = new Size(250, 40);
            btnAjuda.TabIndex = 3;
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
            BtnFeedback.Location = new Point(42, 400);
            BtnFeedback.Margin = new Padding(1);
            BtnFeedback.Name = "BtnFeedback";
            BtnFeedback.Size = new Size(250, 40);
            BtnFeedback.TabIndex = 4;
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
            btnAtendente.Location = new Point(42, 452);
            btnAtendente.Margin = new Padding(1);
            btnAtendente.Name = "btnAtendente";
            btnAtendente.Size = new Size(250, 40);
            btnAtendente.TabIndex = 5;
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
            btnReinicio.Location = new Point(42, 504);
            btnReinicio.Margin = new Padding(1);
            btnReinicio.Name = "btnReinicio";
            btnReinicio.Size = new Size(250, 40);
            btnReinicio.TabIndex = 6;
            btnReinicio.TabStop = false;
            btnReinicio.Text = "Reinicio";
            btnReinicio.TextImageRelation = TextImageRelation.TextAboveImage;
            btnReinicio.UseVisualStyleBackColor = false;
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
            btnHistorico.TabIndex = 7;
            btnHistorico.TabStop = false;
            btnHistorico.Text = "Historico";
            btnHistorico.TextImageRelation = TextImageRelation.TextAboveImage;
            btnHistorico.UseVisualStyleBackColor = false;
            // 
            // PanelChat
            // 
            PanelChat.BackColor = Color.FromArgb(237, 235, 191);
            PanelChat.BorderStyle = BorderStyle.FixedSingle;
            PanelChat.Controls.Add(PanelMsgs);
            PanelChat.Controls.Add(BtnEnviar);
            PanelChat.Controls.Add(TextBoxMsg);
            PanelChat.Location = new Point(345, 12);
            PanelChat.Name = "PanelChat";
            PanelChat.Size = new Size(353, 657);
            PanelChat.TabIndex = 0;
            // 
            // PanelMsgs
            // 
            PanelMsgs.Location = new Point(3, 3);
            PanelMsgs.Name = "PanelMsgs";
            PanelMsgs.Size = new Size(344, 595);
            PanelMsgs.TabIndex = 2;
            // 
            // BtnEnviar
            // 
            BtnEnviar.FlatStyle = FlatStyle.Flat;
            BtnEnviar.ForeColor = Color.FromArgb(237, 235, 191);
            BtnEnviar.Image = (Image)resources.GetObject("BtnEnviar.Image");
            BtnEnviar.Location = new Point(320, 607);
            BtnEnviar.Name = "BtnEnviar";
            BtnEnviar.Size = new Size(27, 26);
            BtnEnviar.TabIndex = 1;
            BtnEnviar.UseVisualStyleBackColor = true;
            BtnEnviar.Click += BtnEnviar_Click;
            // 
            // TextBoxMsg
            // 
            TextBoxMsg.BackColor = Color.White;
            TextBoxMsg.BorderStyle = BorderStyle.FixedSingle;
            TextBoxMsg.Location = new Point(15, 604);
            TextBoxMsg.MaxLength = 36;
            TextBoxMsg.Name = "TextBoxMsg";
            TextBoxMsg.Size = new Size(300, 38);
            TextBoxMsg.TabIndex = 0;
            TextBoxMsg.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(710, 681);
            Controls.Add(btnHistorico);
            Controls.Add(btnReinicio);
            Controls.Add(btnAtendente);
            Controls.Add(BtnFeedback);
            Controls.Add(btnAjuda);
            Controls.Add(panel2);
            Controls.Add(PanelChat);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Chat";
            Load += Form1_Load;
            PanelChat.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        public Button btnAjuda;
        public Button BtnFeedback;
        public Button btnAtendente;
        public Button btnReinicio;
        public Button btnHistorico;
        private Panel PanelChat;
        private RichTextBox TextBoxMsg;
        private Button BtnEnviar;
        private Panel PanelMsgs;
    }
}
