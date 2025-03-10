namespace king_me
{
    partial class KingMe
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.infoGame = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.lblInputIdPartida = new System.Windows.Forms.Label();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtPartidas = new System.Windows.Forms.RichTextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.txtJogadores = new System.Windows.Forms.RichTextBox();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.lblIdJogadorInput = new System.Windows.Forms.Label();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.lblSenhaJogadorInput = new System.Windows.Forms.Label();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.txtPersonagensFav = new System.Windows.Forms.TextBox();
            this.lblPersonagensFav = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoGame
            // 
            this.infoGame.AutoSize = true;
            this.infoGame.Location = new System.Drawing.Point(969, 673);
            this.infoGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoGame.Name = "infoGame";
            this.infoGame.Size = new System.Drawing.Size(139, 16);
            this.infoGame.TabIndex = 0;
            this.infoGame.Text = "Alfaiates de Paris - 1.0";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomePartida.Location = new System.Drawing.Point(16, 31);
            this.txtNomePartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(133, 22);
            this.txtNomePartida.TabIndex = 2;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(16, 11);
            this.lblNomePartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(109, 16);
            this.lblNomePartida.TabIndex = 3;
            this.lblNomePartida.Text = "Nome da Partida";
            this.lblNomePartida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(16, 64);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(46, 16);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaPartida.Location = new System.Drawing.Point(16, 84);
            this.txtSenhaPartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(133, 22);
            this.txtSenhaPartida.TabIndex = 4;
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Location = new System.Drawing.Point(16, 118);
            this.lblNomeGrupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(101, 16);
            this.lblNomeGrupo.TabIndex = 7;
            this.lblNomeGrupo.Text = "Nome do grupo";
            this.lblNomeGrupo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeGrupo.Location = new System.Drawing.Point(16, 138);
            this.txtNomeGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.ReadOnly = true;
            this.txtNomeGrupo.Size = new System.Drawing.Size(133, 22);
            this.txtNomeGrupo.TabIndex = 6;
            this.txtNomeGrupo.Text = "Alfaiates de Paris";
            // 
            // lblInputIdPartida
            // 
            this.lblInputIdPartida.AutoSize = true;
            this.lblInputIdPartida.Location = new System.Drawing.Point(16, 177);
            this.lblInputIdPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputIdPartida.Name = "lblInputIdPartida";
            this.lblInputIdPartida.Size = new System.Drawing.Size(84, 16);
            this.lblInputIdPartida.TabIndex = 9;
            this.lblInputIdPartida.Text = "ID da partida";
            this.lblInputIdPartida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdPartida.Location = new System.Drawing.Point(16, 197);
            this.txtIdPartida.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(133, 22);
            this.txtIdPartida.TabIndex = 8;
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(185, 263);
            this.btnListarPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(133, 28);
            this.btnListarPartidas.TabIndex = 11;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Todas",
            "Aberta",
            "Jogando",
            "Encerrada"});
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Todas",
            "Aberta",
            "Jogando",
            "Encerrada"});
            this.cboStatus.Location = new System.Drawing.Point(16, 263);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(160, 24);
            this.cboStatus.TabIndex = 12;
            this.cboStatus.Tag = "";
            // 
            // txtPartidas
            // 
            this.txtPartidas.Location = new System.Drawing.Point(16, 299);
            this.txtPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartidas.Name = "txtPartidas";
            this.txtPartidas.Size = new System.Drawing.Size(301, 117);
            this.txtPartidas.TabIndex = 13;
            this.txtPartidas.Text = "";
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(16, 432);
            this.lblNomeJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(117, 16);
            this.lblNomeJogador.TabIndex = 15;
            this.lblNomeJogador.Text = "Nome do Jogador";
            this.lblNomeJogador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeJogador.Location = new System.Drawing.Point(20, 452);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(133, 22);
            this.txtNomeJogador.TabIndex = 16;
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(185, 448);
            this.btnEntrarPartida.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(133, 28);
            this.btnEntrarPartida.TabIndex = 17;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // txtJogadores
            // 
            this.txtJogadores.Location = new System.Drawing.Point(20, 535);
            this.txtJogadores.Margin = new System.Windows.Forms.Padding(4);
            this.txtJogadores.Name = "txtJogadores";
            this.txtJogadores.Size = new System.Drawing.Size(301, 117);
            this.txtJogadores.TabIndex = 18;
            this.txtJogadores.Text = "";
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.Location = new System.Drawing.Point(104, 661);
            this.btnListarJogadores.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(133, 28);
            this.btnListarJogadores.TabIndex = 19;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = true;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Location = new System.Drawing.Point(47, 480);
            this.lblIdJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(72, 16);
            this.lblIdJogador.TabIndex = 20;
            this.lblIdJogador.Text = "Id Jogador";
            this.lblIdJogador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Location = new System.Drawing.Point(32, 496);
            this.lblSenhaJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(100, 16);
            this.lblSenhaJogador.TabIndex = 21;
            this.lblSenhaJogador.Text = "Senha Jogador";
            this.lblSenhaJogador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIdJogadorInput
            // 
            this.lblIdJogadorInput.AutoSize = true;
            this.lblIdJogadorInput.Location = new System.Drawing.Point(405, 11);
            this.lblIdJogadorInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdJogadorInput.Name = "lblIdJogadorInput";
            this.lblIdJogadorInput.Size = new System.Drawing.Size(72, 16);
            this.lblIdJogadorInput.TabIndex = 23;
            this.lblIdJogadorInput.Text = "Id Jogador";
            this.lblIdJogadorInput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdJogador.Location = new System.Drawing.Point(405, 31);
            this.txtIdJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(133, 22);
            this.txtIdJogador.TabIndex = 22;
            // 
            // lblSenhaJogadorInput
            // 
            this.lblSenhaJogadorInput.AutoSize = true;
            this.lblSenhaJogadorInput.Location = new System.Drawing.Point(401, 64);
            this.lblSenhaJogadorInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaJogadorInput.Name = "lblSenhaJogadorInput";
            this.lblSenhaJogadorInput.Size = new System.Drawing.Size(100, 16);
            this.lblSenhaJogadorInput.TabIndex = 25;
            this.lblSenhaJogadorInput.Text = "Senha Jogador";
            this.lblSenhaJogadorInput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaJogador.Location = new System.Drawing.Point(405, 84);
            this.txtSenhaJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(133, 22);
            this.txtSenhaJogador.TabIndex = 24;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(185, 31);
            this.btnCriarPartida.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(133, 28);
            this.btnCriarPartida.TabIndex = 26;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(240, 63);
            this.lblIdPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(20, 16);
            this.lblIdPartida.TabIndex = 27;
            this.lblIdPartida.Text = "ID";
            this.lblIdPartida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPersonagensFav
            // 
            this.txtPersonagensFav.Location = new System.Drawing.Point(405, 233);
            this.txtPersonagensFav.Multiline = true;
            this.txtPersonagensFav.Name = "txtPersonagensFav";
            this.txtPersonagensFav.Size = new System.Drawing.Size(145, 134);
            this.txtPersonagensFav.TabIndex = 29;
            // 
            // lblPersonagensFav
            // 
            this.lblPersonagensFav.AutoSize = true;
            this.lblPersonagensFav.Location = new System.Drawing.Point(401, 203);
            this.lblPersonagensFav.Name = "lblPersonagensFav";
            this.lblPersonagensFav.Size = new System.Drawing.Size(147, 16);
            this.lblPersonagensFav.TabIndex = 30;
            this.lblPersonagensFav.Text = "Personagens Favoritos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 31;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(404, 136);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(134, 41);
            this.btnIniciarPartida.TabIndex = 32;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // KingMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 700);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPersonagensFav);
            this.Controls.Add(this.txtPersonagensFav);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.lblSenhaJogadorInput);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.lblIdJogadorInput);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.lblIdJogador);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.txtJogadores);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.txtPartidas);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.btnListarPartidas);
            this.Controls.Add(this.lblInputIdPartida);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.txtNomeGrupo);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.infoGame);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KingMe";
            this.Text = "Alfaiates de Paris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoGame;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.Label lblInputIdPartida;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.RichTextBox txtPartidas;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.RichTextBox txtJogadores;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.Label lblIdJogadorInput;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.Label lblSenhaJogadorInput;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.TextBox txtPersonagensFav;
        private System.Windows.Forms.Label lblPersonagensFav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciarPartida;
    }
}

