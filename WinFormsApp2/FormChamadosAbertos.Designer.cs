namespace WinFormsApp2
{
    partial class FormChamadosAbertos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChamadosAbertos));
            dgvChamadosAbertos = new DataGridView();
            NumeroChamado = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            ServicoId = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            UsuarioId = new DataGridViewTextBoxColumn();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            btnVoltar = new Button();
            lblChamadosAbertos = new Label();
            panel2 = new Panel();
            btnChat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChamadosAbertos).BeginInit();
            SuspendLayout();
            // 
            // dgvChamadosAbertos
            // 
            dgvChamadosAbertos.AllowUserToAddRows = false;
            dgvChamadosAbertos.AllowUserToDeleteRows = false;
            dgvChamadosAbertos.BackgroundColor = Color.FromArgb(237, 235, 191);
            dgvChamadosAbertos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamadosAbertos.Columns.AddRange(new DataGridViewColumn[] { NumeroChamado, Titulo, ServicoId, Status, UsuarioId });
            dgvChamadosAbertos.Location = new Point(279, 44);
            dgvChamadosAbertos.Name = "dgvChamadosAbertos";
            dgvChamadosAbertos.ReadOnly = true;
            dgvChamadosAbertos.RowHeadersWidth = 51;
            dgvChamadosAbertos.Size = new Size(419, 582);
            dgvChamadosAbertos.TabIndex = 0;
            dgvChamadosAbertos.CellContentClick += dgvChamadosAbertos_CellContentClick;
            // 
            // NumeroChamado
            // 
            NumeroChamado.DataPropertyName = "NumeroChamado";
            NumeroChamado.HeaderText = "Numero";
            NumeroChamado.MinimumWidth = 6;
            NumeroChamado.Name = "NumeroChamado";
            NumeroChamado.ReadOnly = true;
            NumeroChamado.Width = 125;
            // 
            // Titulo
            // 
            Titulo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Titulo.DataPropertyName = "Titulo";
            Titulo.HeaderText = "Titulo";
            Titulo.MinimumWidth = 6;
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            // 
            // ServicoId
            // 
            ServicoId.DataPropertyName = "ServicoId";
            ServicoId.HeaderText = "ServicoId";
            ServicoId.MinimumWidth = 6;
            ServicoId.Name = "ServicoId";
            ServicoId.ReadOnly = true;
            ServicoId.Visible = false;
            ServicoId.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // UsuarioId
            // 
            UsuarioId.DataPropertyName = "UsuarioId";
            UsuarioId.HeaderText = "UsuarioId";
            UsuarioId.MinimumWidth = 6;
            UsuarioId.Name = "UsuarioId";
            UsuarioId.ReadOnly = true;
            UsuarioId.Visible = false;
            UsuarioId.Width = 125;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(249, 239, 168);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ImageAlign = ContentAlignment.TopCenter;
            btnVoltar.Location = new Point(27, 609);
            btnVoltar.Margin = new Padding(1);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(106, 40);
            btnVoltar.TabIndex = 14;
            btnVoltar.TabStop = false;
            btnVoltar.Text = "Sair";
            btnVoltar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblChamadosAbertos
            // 
            lblChamadosAbertos.AutoSize = true;
            lblChamadosAbertos.Location = new Point(282, 21);
            lblChamadosAbertos.Name = "lblChamadosAbertos";
            lblChamadosAbertos.Size = new Size(251, 20);
            lblChamadosAbertos.TabIndex = 15;
            lblChamadosAbertos.Text = "Lista de chamados abertos por você:";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(12, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 251);
            panel2.TabIndex = 16;
            // 
            // btnChat
            // 
            btnChat.BackColor = Color.FromArgb(249, 239, 168);
            btnChat.FlatStyle = FlatStyle.Flat;
            btnChat.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChat.ImageAlign = ContentAlignment.TopCenter;
            btnChat.Location = new Point(12, 293);
            btnChat.Margin = new Padding(1);
            btnChat.Name = "btnChat";
            btnChat.Size = new Size(250, 40);
            btnChat.TabIndex = 19;
            btnChat.TabStop = false;
            btnChat.Text = "Chat";
            btnChat.TextImageRelation = TextImageRelation.TextAboveImage;
            btnChat.UseVisualStyleBackColor = false;
            btnChat.Click += btnChat_Click;
            // 
            // FormChamadosAbertos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(710, 681);
            Controls.Add(btnChat);
            Controls.Add(panel2);
            Controls.Add(lblChamadosAbertos);
            Controls.Add(btnVoltar);
            Controls.Add(dgvChamadosAbertos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormChamadosAbertos";
            ShowIcon = false;
            Text = "Chamados Abertos";
            Load += FormChamadosAbertos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChamadosAbertos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvChamadosAbertos;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        public Button btnVoltar;
        private Label lblChamadosAbertos;
        private Panel panel2;
        public Button btnChat;
        private DataGridViewTextBoxColumn NumeroChamado;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn ServicoId;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn UsuarioId;
    }
}