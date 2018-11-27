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
    public partial class telaManterExercicios : Form
    {
        private string cod_user;
        private string cod_prof;

        public telaManterExercicios(string cod_user)
        {
            InitializeComponent();
            this.cod_user = cod_user;
        }

        private void telaManterExercicios_Load(object sender, EventArgs e)
        {
            Exercicio exercicio = new Exercicio();
            Conexao banco = new Conexao();
            cod_prof = banco.getIDProfessor(cod_user);
            gvAtividadesProfessor.DataSource = exercicio.carregaAtividadesProfessor(cod_prof);

            Usuario user = new Usuario();
            lbNOME.Text = "Professor "+ user.getNomeUsuario(cod_user);
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaCriarExercicio CriarExercicio = new telaCriarExercicio("CRIAR NOVO EXERCICIO", cod_user);
            CriarExercicio.Closed += (s, args) => this.Close();
            CriarExercicio.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaCriarExercicio CriarExercicio = new telaCriarExercicio("ALTERAR EXERCÍCIO EXISTENTE", cod_user);
            CriarExercicio.Closed += (s, args) => this.Close();
            CriarExercicio.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Rotina para excluir exercicio
            //Rotina para atualizar GridView
        }

        private void btnPontuacaoPorAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaPontuacao PontuacaoPorAluno = new telaPontuacao(cod_user);
            PontuacaoPorAluno.Closed += (s, args) => this.Close();
            PontuacaoPorAluno.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaLogadoProfessor VoltaTelaProfessor = new telaLogadoProfessor(cod_user);
            VoltaTelaProfessor.Closed += (s, args) => this.Close();
            VoltaTelaProfessor.Show();
        }
    }
}
