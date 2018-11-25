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
            string respostaBanco = "";
            //SE ESTIVER OK... ENVIA PARA O BANCO PARA EXECUTAR O SCRIPT DE CRUD
            if ((campoNome.Text != "") && (campoMatriculaRa.Text != "") && (campoEmail.Text != "") && (campoSenha.Text != ""))
            {

                if (campoSenha.Text == campoConfirmaSenha.Text)
                {
                    if (campoOpcaoAlunoProfessor.Text == "PROFESSOR")
                    {
                        Professor prof = new Professor();
                        respostaBanco =  prof.cadastraProfessor(campoNome.Text, campoMatriculaRa.Text, campoEmail.Text, campoSenha.Text, campoConfirmaSenha.Text);
                    }
                    else if (campoOpcaoAlunoProfessor.Text == "ALUNO")
                    {
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
         
            if(respostaBanco == "Operacao realizada com sucesso")
            {
                MessageBox.Show(respostaBanco);
                this.Hide();
                telaInicial voltarInicio = new telaInicial();
                voltarInicio.Closed += (s, args) => this.Close();
                voltarInicio.Show();
            }
            else
            {
                MessageBox.Show(respostaBanco);
            }
        }
    }
}
