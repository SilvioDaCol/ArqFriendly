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
            
            //VALIDA SE OS CAMPOS ESTÃO PREENCHIDOS

            if ((((campoNome.Text == "") || (campoMatriculaRa.Text == "") || (campoEmail.Text == "") || (campoSenha.Text == ""))))
            {
                MessageBox.Show("Existem campos não preenchidos!!!");
            }

            //SE ESTIVER OK... ENVIA PARA O BANCO PARA EXECUTAR O SCRIPT DE CRUD
            if ((((campoNome.Text != "") && (campoMatriculaRa.Text != "") && (campoEmail.Text != "") && (campoSenha.Text != ""))))
            {

                string incluirNovoUsuario; //string usada para informar qual será o CRUD, referenciado na classe Conexão

                if(campoOpcaoAlunoProfessor.SelectedIndex == 0)
                {
                    incluirNovoUsuario = campoNome.Text + "," + campoMatriculaRa.Text + "," + campoEmail.Text + "," + campoSenha.Text;
                    Conexao novaconexao = new Conexao(incluirNovoUsuario);
                    Console.WriteLine(incluirNovoUsuario);
                }
                if (campoOpcaoAlunoProfessor.SelectedIndex == 1)
                {
                    incluirNovoUsuario = campoNome.Text + "," + campoMatriculaRa.Text + "," + campoEmail.Text + "," + campoSenha.Text + "," + campoCurso.SelectedItem + "," + campoSemestre.SelectedIndex;
                    Conexao novaconexao = new Conexao(incluirNovoUsuario);
                    Console.WriteLine(incluirNovoUsuario);

                }


                MessageBox.Show("Dados Enviados com Sucesso!");

                this.Hide();
                telaInicial voltarInicio = new telaInicial();
                voltarInicio.Closed += (s, args) => this.Close();
                voltarInicio.Show();
               

            }

        }
    }
}
