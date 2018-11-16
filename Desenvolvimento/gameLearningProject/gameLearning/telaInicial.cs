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
    public partial class telaInicial : Form
    {
        private int botaoApertado;

        public telaInicial()
        {
            InitializeComponent();
        }

        private void telaInicial_Load(object sender, EventArgs e)
        {
            
        }

        private void logoMaior_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();

        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
           
        }

        public int getBotaoApertado()
        {
            return botaoApertado;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            botaoApertado = 1;
            Close();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaCadastro cadastro = new telaCadastro();
            cadastro.FormClosed += (s, args) => this.Close();
            cadastro.Show();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaLogin login = new telaLogin();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaSobre sobre = new telaSobre();
            sobre.FormClosed += (s, args) => this.Close();
            sobre.Show();
        }
    }
}
