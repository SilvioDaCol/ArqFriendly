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


        public telaPreviaJogo(string cod_jogo)
        {
            InitializeComponent();
            this.cod_jogo = cod_jogo;
        }

        private void telaPreviaJogo_Load(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo();
            gvRankingGeral.DataSource = jogo.carregaRankingGeral(cod_jogo);
            nomeJogo.Text = jogo.getNomeJogo(cod_jogo);
            descricaoJogo.Text = jogo.getDescricaoJogo(cod_jogo);
        }
    }
}
