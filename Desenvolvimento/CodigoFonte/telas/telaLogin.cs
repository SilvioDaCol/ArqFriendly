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
    public partial class telaLogin : Form
    {
        public int contador;
        public telaLogin()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void telaLogin_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            
        }

        private void gameLogoMenor_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                     
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
      

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void gameLogoMenor_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            telaInicial voltarInicio = new telaInicial();
            voltarInicio.Closed += (s, args) => this.Close();
            voltarInicio.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            telaInicial voltarInicio = new telaInicial();
            voltarInicio.Closed += (s, args) => this.Close();
            voltarInicio.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if ((campoEmail.Text == "") || (campoSenha.Text == ""))
            {
                MessageBox.Show("Existem campos não preenchidos!!!");
            }
            else
            {
                Usuario usuario = new Usuario();
                string login = usuario.logarUsuario(campoEmail.Text, campoSenha.Text);
                if (login == "PROFESSOR")
                {
                    this.Hide();
                    telaLogadoProfessor professorLogado = new telaLogadoProfessor();
                    professorLogado.Closed += (s, args) => this.Close();
                    professorLogado.Show();
                }
                else if(login == "ALUNO")
                {
                    this.Hide();
                    telaLogadoAluno alunoLogado = new telaLogadoAluno();
                    alunoLogado.Closed += (s, args) => this.Close();
                    alunoLogado.Show();
                }
                else
                {
                    MessageBox.Show(login);
                }
            }
            
        }
    }
}
