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
    public partial class telaLogadoAluno : Form
    {
        public telaLogadoAluno()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaInicial voltarInicio = new telaInicial();
            voltarInicio.Closed += (s, args) => this.Close();
            voltarInicio.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaJogos jogos = new telaJogos();
            jogos.Closed += (s, args) => this.Close();
            jogos.Show();
        }
    }
}
