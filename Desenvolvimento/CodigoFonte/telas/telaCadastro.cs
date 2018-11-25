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
    public partial class telaCadastro : Form
    {
        public telaCadastro()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            telaInicial voltarInicio = new telaInicial();
            voltarInicio.Closed += (s, args) => this.Close();
            voltarInicio.Show();
        }

        private void gameLearningLogoMenor_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaInicial voltarInicio = new telaInicial();
            voltarInicio.Closed += (s, args) => this.Close();
            voltarInicio.Show();
        }

        private void campoNome_TextChanged(object sender, EventArgs e)
        {
            campoMatriculaRa.MaxLength = 7;
            
        }


        private void radioProf_CheckedChanged(object sender, EventArgs e)
        {
            labelCurso.Visible = false;
            labelSemestre.Visible = false;
            campoCurso.Visible = false;
            campoSemestre.Visible = false;
        }

        private void radioAluno_CheckedChanged(object sender, EventArgs e)
        {
            labelCurso.Visible = true;
            labelSemestre.Visible = true;
            campoCurso.Visible = true;
            campoSemestre.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (campoOpcaoAlunoProfessor.SelectedIndex == 0)//professor
            {
                campoCurso.Visible = !true;
                campoSemestre.Visible = !true;
                labelCurso.Visible = !true;
                labelSemestre.Visible = !true;

            }
            if (campoOpcaoAlunoProfessor.SelectedIndex == 1)//aluno
            {
                campoCurso.Visible = true;
                campoSemestre.Visible = true;
                labelCurso.Visible = true;
                labelSemestre.Visible = true;
                
            }
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string respostaBanco = ""; //Variavel que recebe resposta das operacoes no banco

            //SE DADOS ESTAO PREENCHIDOS...
            if ((campoNome.Text != "") && (campoMatriculaRa.Text != "") && (campoEmail.Text != "") && (campoSenha.Text != ""))
            {
                //SE SENHA CONFERE...
                if (campoSenha.Text == campoConfirmaSenha.Text)
                {
                    //SE ESTIVER SELECIONADO PROFESSOR, ENVIA OS DADOS DE CADASTRO PARA A CLASSE PROFESSOR
                    if (campoOpcaoAlunoProfessor.Text == "PROFESSOR")
                    {
                        Professor prof = new Professor();
                        //CHAMA O METODO DE CADASTRO DA CLASSE PROFESSOR, ESTA RETORNA SE FOI REALIZADO COM SUCESSO, OU O ERRO OCORRIDO NO BANCO DE DADOS
                        respostaBanco =  prof.cadastraProfessor(campoNome.Text, campoMatriculaRa.Text, campoEmail.Text, campoSenha.Text, campoConfirmaSenha.Text);
                    }
                    //SE ESTIVER SELECIONADO ALUNO, ENVIA OS DADOS DE CADASTRO PARA A CLASSE ALUNO
                    else if (campoOpcaoAlunoProfessor.Text == "ALUNO")
                    {
                        //CHAMA O METODO DE CADASTRO DA CLASSE ALUNO, ESTA RETORNA SE FOI REALIZADO COM SUCESSO, OU O ERRO OCORRIDO NO BANCO DE DADOS
                        Aluno aluno = new Aluno();
                        respostaBanco = aluno.cadastraAluno(campoNome.Text, campoMatriculaRa.Text, campoEmail.Text, campoSenha.Text, campoConfirmaSenha.Text, campoCurso.Text, campoSemestre.Text);
                    }
                    else
                    {
                        MessageBox.Show("Escolha Aluno ou Professor");
                    }
                }
                else
                {
                    MessageBox.Show("Senha não confere !!!");
                }
            }
            else
            {
                MessageBox.Show("Existem campos não preenchidos!!!");
            }

            //SE A OPERACAO FOI REALIZADA COM SUCESSO, EXIBE MENSAGEM E VOLTA A TELA INICIO
            if (respostaBanco == "Operacao realizada com sucesso")
            {
                MessageBox.Show(respostaBanco);
                this.Hide();
                telaInicial voltarInicio = new telaInicial();
                voltarInicio.Closed += (s, args) => this.Close();
                voltarInicio.Show();
            }
            //SE HOUVE ERRO NA OPERAÇÃO DE CADASTRO DO BANCO EXIBE O ERRO OCORRIDO
            else
            {
                MessageBox.Show(respostaBanco);
            }
        }
    }
}
