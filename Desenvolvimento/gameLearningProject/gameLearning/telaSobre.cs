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
    public partial class telaSobre : Form
    {
        public telaSobre()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaInicial iniciaNovamente = new telaInicial();
            iniciaNovamente.FormClosed += (s, args) => this.Close();
            iniciaNovamente.Show();
        }

        private void gameLogoMenor_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaInicial iniciaNovamente = new telaInicial();
            iniciaNovamente.FormClosed += (s, args) => this.Close();
            iniciaNovamente.Show();
        }
    }
}
