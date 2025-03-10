using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace king_me
{
    public partial class KingMe : Form
    {
        public KingMe()
        {
            InitializeComponent();

            cboStatus.SelectedIndex = 0;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            btnListarPartidas_Click(null, null);
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string status = cboStatus.Text.Substring(0, 1);
            string partidas = string.Empty;

            partidas = KingMeServer.Jogo.ListarPartidas(status);

            if (partidas == string.Empty) { MessageBox.Show("Nenhuma partida encontrada."); return; }

            txtPartidas.Text = partidas;
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            string id = txtIdPartida.Text;
            string jogador = txtNomeJogador.Text;
            string senha = txtSenhaPartida.Text;

            if (id == string.Empty) { MessageBox.Show("Informe o ID da partida."); return; }
            if (jogador == string.Empty) { MessageBox.Show("Informe o nome do jogador."); return; }
            if (senha == string.Empty) { MessageBox.Show("Informe a senha da partida."); return; }

            string infoJogador = KingMeServer.Jogo.Entrar(int.Parse(id), jogador, senha);

            string idJogador = infoJogador.Split(',')[0];
            string senhaJogador = infoJogador.Split(',')[1];

            txtIdJogador.Text = idJogador;
            lblIdJogador.Text = $"ID: {idJogador}";
            txtSenhaJogador.Text = senhaJogador;
            lblSenhaJogador.Text = $"Senha: {senhaJogador}";

            btnListarJogadores_Click(null, null);

        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string nome = txtNomePartida.Text;
            string senha = txtSenhaPartida.Text;
            string grupo = txtNomeGrupo.Text;

            if (nome == string.Empty) { MessageBox.Show("Informe o nome da partida."); return; }
            if (senha == string.Empty) { MessageBox.Show("Informe a senha da partida."); return; }
            if (grupo == string.Empty) { MessageBox.Show("Informe o grupo da partida."); return; }

            string id = KingMeServer.Jogo.CriarPartida(nome, senha, grupo);

            txtIdPartida.Text = id;
            lblIdPartida.Text = id;
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            string id = txtIdPartida.Text;
            if (id == string.Empty) { MessageBox.Show("Informe o ID da partida."); return; }

            txtJogadores.Text = KingMeServer.Jogo.ListarJogadores(int.Parse(id));
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            int idJogador = int.Parse(txtIdJogador.Text);
            string senhaJogador = txtSenhaJogador.Text;
            int id = int.Parse(txtIdPartida.Text);
            string senha = txtSenhaPartida.Text;
            
            KingMeServer.Jogo.Iniciar(idJogador, senhaJogador);

            txtPersonagensFav.Text = KingMeServer.Jogo.ListarCartas(idJogador, senhaJogador);

        }

     
    }
}
