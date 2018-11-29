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
                //Identifica a linha selecionada no GridView, extrai o codigo da atividade e o armazena na variavel
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

        
    }
}
