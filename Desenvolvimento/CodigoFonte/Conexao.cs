using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace gameLearning
{
    class Conexao
    {
        private string chave = "Server=localhost;Port=5432;UserId=postgres;Password=Sophia20;Database=BDprojetoInterDisciplinar";
        private string CRUD;//Qualquer alteração que sera feita no banco CRUD

        public Conexao(string CRUD)
        {

            conectarExecutarAcaoDesconetar(chave,CRUD);
            this.CRUD = CRUD;
            
        }

        public void conectarExecutarAcaoDesconetar(string chave,string CRUD)
        {
            this.chave = chave;
            this.CRUD = CRUD;

            try
            {
                
                
                NpgsqlConnection novaConexao = new NpgsqlConnection(chave);
                novaConexao.Open();

                //executa a Query
                NpgsqlCommand inserenobanco = new NpgsqlCommand("INSERT INTO alunos (nome, matricula) values ('Ricardo','MBS2123');", novaConexao);
                inserenobanco.ExecuteNonQuery();

                //MessageBox.Show("entrou na conexão");
                novaConexao.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
            
        }
    }
}
