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

        private string chave;//chave de conexao com banco
        private string CRUD;//Qualquer alteração que sera feita no banco CRUD
        private string resposta; //Retorna mensagem de erro ou sucesso
        private NpgsqlDataReader leitor;

        public Conexao()
        {
            //chave = "Server=localhost;Port=5432;UserId=postgres;Password=Sophia20;Database=BDprojetoInterDisciplinar";
            chave = "Server=localhost;Port=5432;UserId=postgres;Password=dustcloth;Database=gamelearning_db";
            resposta = "";
        }

        private string conectarInserirDesconectar()
        {
            //this.CRUD = CRUD;

            try
            {                          
                NpgsqlConnection novaConexao = new NpgsqlConnection(chave);
                novaConexao.Open();

                //executa a Query
                NpgsqlCommand inserenobanco = new NpgsqlCommand(CRUD, novaConexao);
                inserenobanco.ExecuteNonQuery();                
                //MessageBox.Show("entrou na conexão");
                novaConexao.Close();
                return "Operacao realizada com sucesso";
            }
            catch(Exception erro)
            {
                return erro.Message;
            }                 
        }

        private string conectarConsultarDesconectar()
        {
            //this.CRUD = CRUD;

            try
            {
                NpgsqlConnection novaConexao = new NpgsqlConnection(chave);
                novaConexao.Open();

                //executa a Query
                NpgsqlCommand consultanobanco = new NpgsqlCommand(CRUD, novaConexao);                
                leitor = consultanobanco.ExecuteReader();

                resposta = "";
                while (leitor.Read())
                {
                    resposta = leitor[0].ToString();
                }
                novaConexao.Close();
                return resposta;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }


        public string cadastraUsuario(string nome, string email, string senha)
        {
            CRUD = "insert into usuario (nome_user, email_user, senha_user) values ('" + nome + "', '" + email + "', '" + senha + "');";
            resposta = conectarInserirDesconectar();
            return resposta;
        }

        public string getIDUsuario(string email)
        {
            CRUD = "select * from usuario where email_user = '" + email + "';";
            resposta = conectarConsultarDesconectar();
            
            return resposta;           
        }

        public string cadastraProfessor(string cod_user, string matricula)
        {
            CRUD = "insert into professor (registro, usuario) values ('" + matricula + "', '" + cod_user + "');";
            resposta = conectarInserirDesconectar();
            return resposta;
        }

        public string deletaUsuario(string email)
        {
            CRUD = "delete FROM usuario where email_user = '" + email + "';";
            resposta = conectarInserirDesconectar();

            return resposta;
        }

        public string cadastraAluno(string cod_user, string ra_aluno, string curso, string semestre)
        {
            CRUD = "insert into aluno (ra_aluno, usuario, curso, semestre) values ('" + ra_aluno + "', '" + cod_user + "', '" + curso + "', '" + semestre + "');";
            resposta = conectarInserirDesconectar();
            return resposta;
        }
        
    }
}
