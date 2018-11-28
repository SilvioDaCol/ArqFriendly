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
        private DataTable dtExecicios;

        public telaManterExercicios(string cod_user)
        {
            InitializeComponent();
            this.cod_user = cod_user;
        }

        private void telaManterExercicios_Load(object sender, EventArgs e)
        {
            Exercicio exercicio = new Exercicio();          
            Professor p = new Professor();
            cod_prof = p.getIDProfessor(cod_user);
            dtExecicios = exercicio.carregaAtividadesProfessor(cod_prof);
            gvAtividadesProfessor.DataSource = dtExecicios;

            Usuario user = new Usuario();
            lbNOME.Text = "Professor "+ user.getNomeUsuario(cod_user);
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string cod_atividade = "NOVA";

            this.Hide();
            telaCriarExercicio CriarExercicio = new telaCriarExercicio("CRIAR NOVO EXERCICIO", cod_user, cod_atividade);
            CriarExercicio.Closed += (s, args) => this.Close();
            CriarExercicio.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //PEGA PRIMEIRA LINHA E COLUNA DA TABELA = COD_ATIVIDADE
            string cod_atividade = dtExecicios.Rows[0][0].ToString();

            this.Hide();
            telaCriarExercicio CriarExercicio = new telaCriarExercicio("ALTERAR EXERCÍCIO", cod_user, cod_atividade);
            CriarExercicio.Closed += (s, args) => this.Close();
            CriarExercicio.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Rotina para excluir exercicio:
                //Identifica a linha selecionada no GridView, extrai o codigo da atividade e o armazena na variavel
                DataGridViewRow item = gvAtividadesProfessor.SelectedRows[0];
                string cod_atividade = dtExecicios.Rows[item.Index]["cod_atividade"].ToString();

                //Exclui Atividade
                Exercicio exercicio = new Exercicio();
                MessageBox.Show(exercicio.excluiAtividade(cod_atividade));

                /* ATUALIZA DATAGRID */
                Professor p = new Professor();
                cod_prof = p.getIDProfessor(cod_user);
                dtExecicios = exercicio.carregaAtividadesProfessor(cod_prof);
                gvAtividadesProfessor.DataSource = dtExecicios;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("SELECIONE UM EXERCICIO NA LISTA ACIMA");
            }            
        }

        private void btnPontuacaoPorAluno_Click(object sender, EventArgs e)
        {
            try
            {             
                //Identifica a linha selecionada no GridView, extrai o codigo da atividade e o armazena na variavel
                DataGridViewRow item = gvAtividadesProfessor.SelectedRows[0];
                string cod_atividade = dtExecicios.Rows[item.Index]["cod_atividade"].ToString();

                //Mostra tela de pontuacao
                this.Hide();
                telaPontuacao PontuacaoPorAluno = new telaPontuacao(cod_user, cod_atividade);
                PontuacaoPorAluno.Closed += (s, args) => this.Close();
                PontuacaoPorAluno.Show();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("SELECIONE UM EXERCICIO NA LISTA ACIMA");
            }
            
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
