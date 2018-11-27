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

        public telaManterExercicios(string cod_user)
        {
            InitializeComponent();
            this.cod_user = cod_user;
        }



        private void pictureBox5_Click(object sender, EventArgs e)
        {     
            
        }

        private void telaManterExercicios_Load(object sender, EventArgs e)
        {
            Exercicio exercicio = new Exercicio();
            Conexao banco = new Conexao();
            cod_prof = banco.getIDProfessor(cod_user);
            gvAtividadesProfessor.DataSource = exercicio.carregaAtividadesProfessor(cod_prof);
        }
    }
}
