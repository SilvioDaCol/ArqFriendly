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
    public partial class telaPontuacao : Form
    {
        private string cod_user;
        private string cod_atividade;

        public telaPontuacao(string cod_user, string cod_atividade)
        {
            InitializeComponent();
            this.cod_user = cod_user;
            this.cod_atividade = cod_atividade;
        }

        private void telaPontuacao_Load(object sender, EventArgs e)
        {
            lbExercicio.Text = "Exercício nº " + cod_atividade;
            Exercicio exercicio = new Exercicio();
            gvPontuacaoPorAluno.DataSource = exercicio.getAlunosAtividade(cod_atividade);
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            telaManterExercicios manterExercicio = new telaManterExercicios(cod_user);
            manterExercicio.Closed += (s, args) => this.Close();
            manterExercicio.Show();
        }        
    }
}
