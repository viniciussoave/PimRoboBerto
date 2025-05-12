namespace WinFormsApp2
{
    partial class FormChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChat));
            panel2 = new Panel();
            btnChamadosAbertos = new Button();
            btnReinicio = new Button();
            PanelChat = new Panel();
            PanelMsgs = new Panel();
            BtnEnviar = new Button();
            TextBoxMsg = new RichTextBox();
            btnVoltar = new Button();
            PanelChat.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(42, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 251);
            panel2.TabIndex = 1;
            // 
            // btnChamadosAbertos
            // 
            btnChamadosAbertos.BackColor = Color.FromArgb(249, 239, 168);
            btnChamadosAbertos.FlatStyle = FlatStyle.Flat;
            btnChamadosAbertos.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChamadosAbertos.ImageAlign = ContentAlignment.TopCenter;
            btnChamadosAbertos.Location = new Point(42, 278);
            btnChamadosAbertos.Margin = new Padding(1);
            btnChamadosAbertos.Name = "btnChamadosAbertos";
            btnChamadosAbertos.Size = new Size(250, 40);
            btnChamadosAbertos.TabIndex = 5;
            btnChamadosAbertos.TabStop = false;
            btnChamadosAbertos.Text = "Chamados abertos";
            btnChamadosAbertos.TextImageRelation = TextImageRelation.TextAboveImage;
            btnChamadosAbertos.UseVisualStyleBackColor = false;
            btnChamadosAbertos.Click += btnChamadosAbertos_Click;
            // 
            // btnReinicio
            // 
            btnReinicio.BackColor = Color.FromArgb(249, 239, 168);
            btnReinicio.FlatStyle = FlatStyle.Flat;
            btnReinicio.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReinicio.ImageAlign = ContentAlignment.TopCenter;
            btnReinicio.Location = new Point(42, 331);
            btnReinicio.Margin = new Padding(1);
            btnReinicio.Name = "btnReinicio";
            btnReinicio.Size = new Size(250, 40);
            btnReinicio.TabIndex = 6;
            btnReinicio.TabStop = false;
            btnReinicio.Text = "Reinicio";
            btnReinicio.TextImageRelation = TextImageRelation.TextAboveImage;
            btnReinicio.UseVisualStyleBackColor = false;
            btnReinicio.Click += btnReinicio_Click;
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
            PanelChat.Paint += PanelChat_Paint;
            // 
            // PanelMsgs
            // 
            PanelMsgs.Location = new Point(3, 3);
            PanelMsgs.Name = "PanelMsgs";
            PanelMsgs.Size = new Size(344, 595);
            PanelMsgs.TabIndex = 2;
            PanelMsgs.Paint += PanelMsgs_Paint;
            // 
            // BtnEnviar
            // 
            BtnEnviar.FlatStyle = FlatStyle.Flat;
            BtnEnviar.ForeColor = Color.FromArgb(237, 235, 191);
            BtnEnviar.Image = (Image)resources.GetObject("BtnEnviar.Image");
            BtnEnviar.Location = new Point(320, 607);
            BtnEnviar.Name = "BtnEnviar";
            BtnEnviar.Size = new Size(27, 27);
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
            TextBoxMsg.Multiline = false;
            TextBoxMsg.Name = "TextBoxMsg";
            TextBoxMsg.Size = new Size(300, 39);
            TextBoxMsg.TabIndex = 0;
            TextBoxMsg.Text = "";
            TextBoxMsg.TextChanged += TextBoxMsg_TextChanged;
            TextBoxMsg.KeyPress += TextBoxMsg_KeyPress;
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
            btnVoltar.TabIndex = 13;
            btnVoltar.TabStop = false;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FormChat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(710, 681);
            Controls.Add(btnVoltar);
            Controls.Add(btnReinicio);
            Controls.Add(btnChamadosAbertos);
            Controls.Add(panel2);
            Controls.Add(PanelChat);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormChat";
            Text = "Chat";
            FormClosing += FormChat_FormClosing;
            Load += Form1_Load;
            PanelChat.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        public Button btnAjuda;
        public Button btnChamadosAbertos;
        public Button btnReinicio;
        private Panel PanelChat;
        private RichTextBox TextBoxMsg;
        private Button BtnEnviar;
        private Panel PanelMsgs;
        public Button btnVoltar;
    }
}
