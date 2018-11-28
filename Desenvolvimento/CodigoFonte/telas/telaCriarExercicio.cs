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
        private string cod_atividade;
        private string cod_turma = "";
        private string cod_jogo;
        private List<Turma> turmas;

        public telaCriarExercicio(string tituloJanela,  string cod_user, string cod_atividade)
        {
            InitializeComponent();
            this.cod_user = cod_user;
            this.tituloJanela = tituloJanela;
            this.cod_atividade = cod_atividade;
            turmas = new List<Turma>();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cod_jogo = "1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cod_jogo = "2";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cod_jogo = "3";
        }

        private void telaCriarExercicio_Load(object sender, EventArgs e)
        {
            /* CARREGA TITULO DA JANELA NA LABEL */
            lbTitulo.Text = tituloJanela;

            //Configura Calendario de prazo para não antes da data atual
            dtpPrazo.MinDate = DateTime.Now.AddDays(1.0);

            /* CAREGA TURMAS NO COMBO BOX */            
            Turma turmaAux = new Turma(); // Instacia um objeto turma         
            DataTable dtTurmas = new DataTable(); //  cria uma tabela para armazenar as turmas
            dtTurmas = turmaAux.getTurmas(); // preenche a tabela com as turmas do Banco

            for (int i = 0; i < dtTurmas.Rows.Count; i++) // Preenche a lista de turmas
            {             
                turmas.Add(new Turma(dtTurmas.Rows[i]));
                cbRelacaoTurmas.Items.Add(turmas[i].nomeTurma);
            }
            


            if (cod_atividade == "NOVA") // Nova atividade: não preenche os campos
            {

            }else // Alterar atividade: preenche os campos com os dados da atividade a ser alterada
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaManterExercicios telaExercicios = new telaManterExercicios(cod_user);
            telaExercicios.Closed += (s, args) => this.Close();
            telaExercicios.Show();
        }

        //SE UMA TURMA FOR SELECIONADA 
        private void cbRelacaoTurmas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lIMPA A LISTBOX
            lsAlunosAtividade.Items.Clear();

            //CARREGA A LISTBOX COM OS ALUNOS DA NOVA TURMA
            for (int i = 0; i < turmas[cbRelacaoTurmas.SelectedIndex].alunos.Count; i++)
            {
                lsAlunosAtividade.Items.Add(turmas[cbRelacaoTurmas.SelectedIndex].alunos[i].nome_raAluno);
            }
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lsAlunosAtividade.Items.Count>0)
            {
                Professor p = new Professor();
                string cod_professor = p.getIDProfessor(cod_user);

                try
                {
                    cod_turma = turmas[cbRelacaoTurmas.SelectedIndex].cod_turma;
                }
                catch (ArgumentException)
                {
                }

                //CADASTRA A NOVA ATIVIDADE NO BANCO
                Exercicio exercicio = new Exercicio();
                string cod_atividade = exercicio.cadastraAtividade(dtpPrazo.Value.ToShortDateString(), DateTime.Now.ToShortDateString(), cod_professor, cod_jogo);

                //SE NOVA ATIVIDADE FOI CADASTRADA COM SUCESSO, VINCULA LISTA DE ALUNOS A ATIVIDADE
                if (!cod_atividade.StartsWith("ERRO:"))
                {
                    string resposta = "";
                    //CARREGA A LISTBOX COM OS ALUNOS E O CODIGO DA ATIVIDADE CRIADA
                    for (int i = 0; i < turmas[cbRelacaoTurmas.SelectedIndex].alunos.Count; i++)
                    {
                        resposta = exercicio.cadastraAlunosAtividade(turmas[cbRelacaoTurmas.SelectedIndex].alunos[i].cod_aluno, cod_atividade);
                    }

                    MessageBox.Show(resposta);
                    this.Hide();
                    telaManterExercicios manterExercicio = new telaManterExercicios(cod_user);
                    manterExercicio.Closed += (s, args) => this.Close();
                    manterExercicio.Show();
                }
            }
            else
            {
                MessageBox.Show("Turma sem alunos. Não foi possível criar exercício");
            }
         
        }
    }
}
