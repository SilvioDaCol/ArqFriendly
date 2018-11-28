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

            Exercicio exercicio = new Exercicio();
            Aluno a = new Aluno();
            cod_aluno = a.getIDAluno(cod_user);
            dtExercicios = exercicio.carregaAtividadesAluno(cod_aluno);
            gvAtividadesAluno.DataSource = dtExercicios;
        }

        private void telaLogadoAluno_Load(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            lbNOME.Text = user.getNomeUsuario(cod_user);


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


    }
}
