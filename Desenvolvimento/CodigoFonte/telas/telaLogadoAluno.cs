using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace gameLearning
{
    public partial class telaLogadoAluno : Form
    {
        string cod_user = "";
        string cod_aluno;
        DataTable dtExercicios;

        public telaLogadoAluno(string cod_user)
        {
            InitializeComponent();
            this.cod_user = cod_user;            
        }

        private void telaLogadoAluno_Load(object sender, EventArgs e)
        {
            //CArrega NOme do usuario logado
            Usuario user = new Usuario();
            lbNOME.Text = user.getNomeUsuario(cod_user);

            //Carrega Datagrid
            Exercicio exercicio = new Exercicio();
            Aluno a = new Aluno();
            cod_aluno = a.getIDAluno(cod_user);
            dtExercicios = exercicio.carregaAtividadesAluno(cod_aluno);
            gvAtividadesAluno.DataSource = dtExercicios;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaInicial voltarInicio = new telaInicial();
            voltarInicio.Closed += (s, args) => this.Close();
            voltarInicio.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaJogos jogos = new telaJogos("ALUNO", cod_user);
            jogos.Closed += (s, args) => this.Close();
            jogos.Show();
        }

        private void btnIniciarExercicio_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtem codigo do exercicio selecionado no GridView
                DataGridViewRow item = gvAtividadesAluno.SelectedRows[0];
                string cod_atividade = dtExercicios.Rows[item.Index]["codigo"].ToString();
                //Obtem codigo do jogo selecionado no GridView
                string nome_jogo = dtExercicios.Rows[item.Index]["jogo"].ToString();

                Jogo Jogos = new Jogo();
                string cod_jogo = Jogos.getIDJogo(nome_jogo);

                //Caso nao houve erro ao consultar codigo do jogo no banco: 
                if (!cod_jogo.StartsWith("ERRO:"))
                {
                    //Roda o jogo, pega a pontuacao ao final e armazena na variavel pontuacao
                    string pontuacao = Jogos.jogarStarWarsLC();                    
                    //Salva pontuacao no ranking geral
                    Jogos.salvaRankingGeral(cod_jogo, cod_user, pontuacao);               
                    //Vincula a pontuacao obtida ao aluno e ao exercicio e salva no Banco
                    Exercicio exercicio = new Exercicio();
                    string resposta = exercicio.salvaPontuacaoAluno(cod_atividade, cod_aluno, pontuacao);
                    //Atualiza lista de exercicios
                    dtExercicios = exercicio.carregaAtividadesAluno(cod_aluno);
                    gvAtividadesAluno.DataSource = dtExercicios;
                    //Exibe pontuacao obtida
                    if (!resposta.StartsWith("ERRO:")) resposta = "Atividade concluída!! Sua pontuação foi: "+ pontuacao;
                    MessageBox.Show(resposta);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Seleciona uma Atividade na lista acima!");
            }
     
        }
    }
}

