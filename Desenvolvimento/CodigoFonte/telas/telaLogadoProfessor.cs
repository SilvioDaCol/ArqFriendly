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
    public partial class telaLogadoProfessor : Form
    {
        private string cod_user = "";

        public telaLogadoProfessor(string cod_user)
        {
            InitializeComponent();
            this.cod_user = cod_user;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaJogos jogos = new telaJogos("PROFESSOR", cod_user);
            jogos.Closed += (s, args) => this.Close();
            jogos.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaLogin fazerlogin = new telaLogin();
            fazerlogin.Closed += (s, args) => this.Close();
            fazerlogin.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
