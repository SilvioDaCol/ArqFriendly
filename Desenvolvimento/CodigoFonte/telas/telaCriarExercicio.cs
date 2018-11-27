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
    public partial class telaCriarExercicio : Form
    {
        private string cod_user;
        private string tituloJanela;

        public telaCriarExercicio(string tituloJanela,  string cod_user)
        {
            InitializeComponent();
            this.cod_user = cod_user;
            this.tituloJanela = tituloJanela;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void telaCriarExercicio_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = tituloJanela;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaManterExercicios telaExercicios = new telaManterExercicios(cod_user);
            telaExercicios.Closed += (s, args) => this.Close();
            telaExercicios.Show();
        }
    }
}
