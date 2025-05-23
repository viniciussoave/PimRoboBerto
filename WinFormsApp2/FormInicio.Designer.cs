﻿namespace WinFormsApp2
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            PanelMsgs = new Panel();
            panel2 = new Panel();
            btnLogin = new Button();
            btnRegistrar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // PanelMsgs
            // 
            PanelMsgs.BackColor = Color.FromArgb(237, 235, 191);
            PanelMsgs.BorderStyle = BorderStyle.FixedSingle;
            PanelMsgs.Location = new Point(182, 364);
            PanelMsgs.Name = "PanelMsgs";
            PanelMsgs.Size = new Size(349, 199);
            PanelMsgs.TabIndex = 3;
            PanelMsgs.Paint += PanelMsgs_Paint;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(230, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 251);
            panel2.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(249, 239, 168);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ImageAlign = ContentAlignment.TopCenter;
            btnLogin.Location = new Point(230, 403);
            btnLogin.Margin = new Padding(1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 40);
            btnLogin.TabIndex = 8;
            btnLogin.TabStop = false;
            btnLogin.Text = "Login";
            btnLogin.TextImageRelation = TextImageRelation.TextAboveImage;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(249, 239, 168);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ImageAlign = ContentAlignment.TopCenter;
            btnRegistrar.Location = new Point(230, 481);
            btnRegistrar.Margin = new Padding(1);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(250, 40);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.TabStop = false;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 304);
            label1.Name = "label1";
            label1.Size = new Size(367, 46);
            label1.TabIndex = 11;
            label1.Text = "RoboBerto ChatBot";
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(710, 681);
            Controls.Add(label1);
            Controls.Add(btnRegistrar);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(PanelMsgs);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormInicio";
            Text = "Inicio - RoboBerto ChatBot";
            FormClosed += FormInicio_FormClosed;
            Load += FormInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Isso faz com que caso esse fomulario seja fechado o aplicativo inteiro vai ser encerrado
            Application.Exit(); 
        }

        #endregion

        private Panel PanelMsgs;
        private Panel panel2;
        public Button btnLogin;
        public Button btnRegistrar;
        private Label label1;
    }
}