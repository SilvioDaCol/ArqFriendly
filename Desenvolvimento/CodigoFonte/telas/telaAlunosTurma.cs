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
    public partial class telaAlunosTurma : Form
    {
        private string cod_user;
        string cod_turma;

        public telaAlunosTurma(string cod_user, string cod_turma)
        {
            InitializeComponent();
            this.cod_user = cod_user;
            this.cod_turma = cod_turma;
        }

        private void telaAlunosTurma_Load(object sender, EventArgs e)
        {
            Turma turma = new Turma();
            gvAlunos.DataSource = turma.getAlunosTurma(cod_turma);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            telaManterTurma voltaTelaManterTurma = new telaManterTurma(cod_user);
            voltaTelaManterTurma.Closed += (s, args) => this.Close();
            voltaTelaManterTurma.Show();
        }

        
    }
}
