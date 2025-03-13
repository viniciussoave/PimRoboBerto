namespace WinFormsApp2
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
            SuspendLayout();
            // 
            // PanelMsgs
            // 
            PanelMsgs.BackColor = Color.FromArgb(237, 235, 191);
            PanelMsgs.BorderStyle = BorderStyle.FixedSingle;
            PanelMsgs.Location = new Point(182, 364);
            PanelMsgs.Name = "PanelMsgs";
            PanelMsgs.Size = new Size(350, 200);
            PanelMsgs.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(230, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 250);
            panel2.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(249, 239, 168);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ImageAlign = ContentAlignment.TopCenter;
            btnLogin.Location = new Point(230, 402);
            btnLogin.Margin = new Padding(1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 40);
            btnLogin.TabIndex = 8;
            btnLogin.TabStop = false;
            btnLogin.Text = "Login";
            btnLogin.TextImageRelation = TextImageRelation.TextAboveImage;
            btnLogin.UseVisualStyleBackColor = false;
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
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(710, 681);
            Controls.Add(btnRegistrar);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(PanelMsgs);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormInicio";
            Text = "FormInicio";
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMsgs;
        private Panel panel2;
        public Button btnLogin;
        public Button btnRegistrar;
    }
}