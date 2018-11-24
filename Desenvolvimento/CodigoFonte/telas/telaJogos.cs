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
        public telaJogos()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Jogo Jogos = new Jogo();
            MessageBox.Show("PONTUACAO OBTIDA: " + Jogos.jogarStarWarsLC());            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Jogo Jogos = new Jogo();
            MessageBox.Show("PONTUACAO OBTIDA: "+Jogos.jogarAlgoRace());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaPreviaJogo previaJogo = new telaPreviaJogo();
            previaJogo.Closed += (s, args) => this.Close();
            previaJogo.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaPreviaJogo previaJogo = new telaPreviaJogo();
            previaJogo.Closed += (s, args) => this.Close();
            previaJogo.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaPreviaJogo previaJogo = new telaPreviaJogo();
            previaJogo.Closed += (s, args) => this.Close();
            previaJogo.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaPreviaJogo previaJogo = new telaPreviaJogo();
            previaJogo.Closed += (s, args) => this.Close();
            previaJogo.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaPreviaJogo previaJogo = new telaPreviaJogo();
            previaJogo.Closed += (s, args) => this.Close();
            previaJogo.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaPreviaJogo previaJogo = new telaPreviaJogo();
            previaJogo.Closed += (s, args) => this.Close();
            previaJogo.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Jogo Jogos = new Jogo();            
            MessageBox.Show("PONTUACAO OBTIDA: " + Jogos.jogarCTIGame());
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaInicial voltarInicio = new telaInicial();
            voltarInicio.Closed += (s, args) => this.Close();
            voltarInicio.Show();
        }
    }
}
