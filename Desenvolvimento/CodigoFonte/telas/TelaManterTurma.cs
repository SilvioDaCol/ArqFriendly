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
    public partial class telaManterTurma : Form
    {
        private string cod_user;
        private string cod_turma;
        private DataTable dtTurmas;

        public telaManterTurma(string cod_user)
        {
            InitializeComponent();
            this.cod_user = cod_user;
        }

        private void telaManterTurma_Load(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            lbNOME.Text = "Professor " + user.getNomeUsuario(cod_user);

            gpbDadosTurma.Visible = false;
            Turma turma = new Turma();
            dtTurmas = turma.getTurmas();
            gvTurmasCriadas.DataSource = dtTurmas;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaLogadoProfessor VoltaTelaProfessor = new telaLogadoProfessor(cod_user);
            VoltaTelaProfessor.Closed += (s, args) => this.Close();
            VoltaTelaProfessor.Show();
        }

        private void btnListaAlunos_Click(object sender, EventArgs e)
        {
            try
            {
                //Identifica a linha selecionada no GridView, extrai o codigo da turma e o armazena na variavel
                DataGridViewRow item = gvTurmasCriadas.SelectedRows[0];
                cod_turma = dtTurmas.Rows[item.Index]["cod_turma"].ToString();

                telaAlunosTurma RelacaoDeAlunos = new telaAlunosTurma(cod_user, cod_turma);
                RelacaoDeAlunos.Closed += (s, args) => this.Close();
                RelacaoDeAlunos.Show();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Selecione uma Turma acima.");
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gpbDadosTurma.Visible = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Obtem codigo do professor
            Professor p = new Professor();
            string cod_professor = p.getIDProfessor(cod_user);
            //Cadastra a turma
            Turma turma = new Turma();
            string resposta = turma.cadastrarTurma(campoCurso.Text, campoSemestre.Text, cod_professor);
            //Atualiza gridview
            dtTurmas = turma.getTurmas();
            gvTurmasCriadas.DataSource = dtTurmas;
            //Mostra resultadoda operação e volta a tela ManterTurmas
            MessageBox.Show(resposta);
            gpbDadosTurma.Visible = false;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            gpbDadosTurma.Visible = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Identifica a linha selecionada no GridView, extrai o codigo da turma e o armazena na variavel
                DataGridViewRow item = gvTurmasCriadas.SelectedRows[0];
                cod_turma = dtTurmas.Rows[item.Index]["cod_turma"].ToString();
                //Exclui turma e mostra resultado
                Turma turma = new Turma();
                string resposta = turma.deletaTurma(cod_turma);
                MessageBox.Show(resposta);

                //Atualiza gridview
                dtTurmas = turma.getTurmas();
                gvTurmasCriadas.DataSource = dtTurmas;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Selecione uma Turma acima.");
            }
        }
    }
}
