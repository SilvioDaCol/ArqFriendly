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
    public partial class telaJogos : Form
    {
        private string telaAnterior = "";
        private string cod_user = "";

        public telaJogos(string telaAnterior, string cod_user)
        {
            InitializeComponent();
            this.telaAnterior = telaAnterior;
            this.cod_user = cod_user;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Jogo Jogos = new Jogo();
            string pontuacao = Jogos.jogarStarWarsLC();
            Jogos.salvaRankingGeral("1", cod_user, pontuacao);
            MessageBox.Show("PONTUACAO OBTIDA: " + pontuacao);            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Jogo Jogos = new Jogo();
            string pontuacao = Jogos.jogarAlgoRace();
            Jogos.salvaRankingGeral("2", cod_user, pontuacao);
            MessageBox.Show("PONTUACAO OBTIDA: " + pontuacao);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaPreviaJogo previaJogo = new telaPreviaJogo("1");
            previaJogo.Closed += (s, args) => this.Close();
            previaJogo.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaPreviaJogo previaJogo = new telaPreviaJogo("2");
            previaJogo.Closed += (s, args) => this.Close();
            previaJogo.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaPreviaJogo previaJogo = new telaPreviaJogo("3");
            previaJogo.Closed += (s, args) => this.Close();
            previaJogo.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaPreviaJogo previaJogo = new telaPreviaJogo("1");
            previaJogo.Closed += (s, args) => this.Close();
            previaJogo.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaPreviaJogo previaJogo = new telaPreviaJogo("2");
            previaJogo.Closed += (s, args) => this.Close();
            previaJogo.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaPreviaJogo previaJogo = new telaPreviaJogo("3");
            previaJogo.Closed += (s, args) => this.Close();
            previaJogo.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Jogo Jogos = new Jogo();
            string pontuacao = Jogos.jogarCTIGame();
            Jogos.salvaRankingGeral("3", cod_user, pontuacao);
            MessageBox.Show("PONTUACAO OBTIDA: " + pontuacao);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if(telaAnterior == "PROFESSOR")
            {
                this.Hide();
                telaLogadoProfessor voltarProfessor = new telaLogadoProfessor(cod_user);
                voltarProfessor.Closed += (s, args) => this.Close();
                voltarProfessor.Show();
            }
            else if(telaAnterior == "ALUNO")
            {
                this.Hide();
                telaLogadoAluno voltarAluno = new telaLogadoAluno(cod_user);
                voltarAluno.Closed += (s, args) => this.Close();
                voltarAluno.Show();
            }
            else
            {
                this.Hide();
                telaInicial voltarInicio = new telaInicial();
                voltarInicio.Closed += (s, args) => this.Close();
                voltarInicio.Show();
            }
        }
    }
}
