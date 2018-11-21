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
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

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
    }
}
