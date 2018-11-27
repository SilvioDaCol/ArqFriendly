using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameLearning
{
    public partial class telaPreviaJogo : Form
    {
        private string cod_jogo;
        private string cod_user;
        private string telaAnterior;

        public telaPreviaJogo(string telaAnterior, string cod_jogo, string cod_user)
        {
            InitializeComponent();
            this.cod_jogo = cod_jogo;
            this.cod_user = cod_user;
            this.telaAnterior = telaAnterior;
        }

        private void telaPreviaJogo_Load(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo();
            gvRankingGeral.DataSource = jogo.carregaRankingGeral(cod_jogo);
            nomeJogo.Text = jogo.getNomeJogo(cod_jogo);
            descricaoJogo.Text = jogo.getDescricaoJogo(cod_jogo);

            //Switch-case para carregar Imagens da tela
            switch (cod_jogo)
            {
                case "1":
                    imagemPrevia1.BackgroundImage = Properties.Resources.starWarsLow;
                    imagemPrevia1.BackgroundImageLayout = ImageLayout.Stretch;
                    imagemPrevia2.BackgroundImage = Properties.Resources.telaPause;
                    imagemPrevia2.BackgroundImageLayout = ImageLayout.Stretch;
                    logoJogo.BackgroundImage = Properties.Resources.starWarsIcon;
                    logoJogo.BackgroundImageLayout = ImageLayout.Stretch;
                    logoJogo.BackColor = Color.Transparent;
                    break;
                case "2":
                    imagemPrevia1.BackgroundImage = Properties.Resources.starWarsIcon;
                    imagemPrevia1.BackgroundImageLayout = ImageLayout.Stretch;
                    imagemPrevia2.BackgroundImage = Properties.Resources.algoRace;
                    imagemPrevia2.BackgroundImageLayout = ImageLayout.Stretch;
                    logoJogo.BackgroundImage = Properties.Resources.starWarsIcon;
                    logoJogo.BackgroundImageLayout = ImageLayout.Stretch;
                    logoJogo.BackColor = Color.Transparent;
                    break;
                case "3":
                    imagemPrevia1.BackgroundImage = Properties.Resources.introProgIcon;
                    imagemPrevia2.BackgroundImage = Properties.Resources.introProgIcon;
                    logoJogo.BackgroundImage = Properties.Resources.introProgIcon;
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Jogo Jogos = new Jogo();
            string pontuacao = Jogos.jogarStarWarsLC();
            Jogos.salvaRankingGeral(cod_jogo, cod_user, pontuacao);
            Jogo jogo = new Jogo();
            gvRankingGeral.DataSource = jogo.carregaRankingGeral(cod_jogo);
            MessageBox.Show("PONTUACAO OBTIDA: " + pontuacao);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaJogos telaJogo = new telaJogos(telaAnterior, cod_user);
            telaJogo.Closed += (s, args) => this.Close();
            telaJogo.Show();
        }
    }
}
