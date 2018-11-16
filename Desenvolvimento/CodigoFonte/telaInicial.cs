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
        public telaInicial()
        {
            InitializeComponent();
        }

        private void logoMaior_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaInicial voltarInicio = new telaInicial();
            voltarInicio.Closed += (s, args) => this.Close();
            voltarInicio.Show();
        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaCadastro cadastro = new telaCadastro();
            cadastro.Closed += (s, args) => this.Close();
            cadastro.Show();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaLogin login = new telaLogin();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaSobre sobre = new telaSobre();
            sobre.Closed += (s, args) => this.Close();
            sobre.Show();
        }

        private void btnCadastro_MouseHover(object sender, EventArgs e)
        {
            btnCadastro.BackgroundImage = Image.FromFile(@"C:\Users\phbel\Desktop\ADS-2018-IFSP\2_SEMESTRE\PROJETO INTERDISCIPLINAR\ArqFriendly\Desenvolvimento\CodigoFonte\Resources\btnInversoCadastro.png");
            btnCadastro.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnCadastro_MouseLeave(object sender, EventArgs e)
        {
            btnCadastro.BackgroundImage = Image.FromFile(@"C:\Users\phbel\Desktop\ADS-2018-IFSP\2_SEMESTRE\PROJETO INTERDISCIPLINAR\ArqFriendly\Desenvolvimento\CodigoFonte\Resources\btnCadastro.png");
            btnCadastro.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Image.FromFile(@"C:\Users\phbel\Desktop\ADS-2018-IFSP\2_SEMESTRE\PROJETO INTERDISCIPLINAR\ArqFriendly\Desenvolvimento\CodigoFonte\Resources\btnInversoLogin.png");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Image.FromFile(@"C:\Users\phbel\Desktop\ADS-2018-IFSP\2_SEMESTRE\PROJETO INTERDISCIPLINAR\ArqFriendly\Desenvolvimento\CodigoFonte\Resources\btnLogin.png");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnSobre_MouseHover(object sender, EventArgs e)
        {
            btnSobre.BackgroundImage = Image.FromFile(@"C:\Users\phbel\Desktop\ADS-2018-IFSP\2_SEMESTRE\PROJETO INTERDISCIPLINAR\ArqFriendly\Desenvolvimento\CodigoFonte\Resources\btnInversoSobre.png");
            btnSobre.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnSobre_MouseLeave(object sender, EventArgs e)
        {
            btnSobre.BackgroundImage = Image.FromFile(@"C:\Users\phbel\Desktop\ADS-2018-IFSP\2_SEMESTRE\PROJETO INTERDISCIPLINAR\ArqFriendly\Desenvolvimento\CodigoFonte\Resources\btnSobre.png");
            btnSobre.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
