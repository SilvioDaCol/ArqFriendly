using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Npgsql;


namespace gameLearning
{
    class Conexao
    {
        private string chave;//chave de conexao com banco
        private string CRUD;//Qualquer alteração que sera feita no banco CRUD
        private string resposta; //Retorna mensagem de erro ou sucesso
        private DataTable data_table; //Armazena tabelas consultadas a partir do banco

        public Conexao()
        {
            //chave = "Server=localhost;Port=5432;UserId=postgres;Password=Sophia20;Database=BDprojetoInterDisciplinar";           
            chave = "Server=localhost;Port=5432;UserId=postgres;Password=dustcloth;Database=gamelearning_db";
            resposta = "";
        }

        //ESTA FUNCAO SE CONECTA AO BANCO PARA ***SETAR*** DADOS
        private string conectarInserirDesconectar()
        {
            try
            {
                //CHAMA NOVA CONEXAO E PASSA A CHAVE DO BANCO
                NpgsqlConnection novaConexao = new NpgsqlConnection(chave);
                //ABRE CONEXAO
                novaConexao.Open();

                //INSTANCIA OS COMANDOS(DE ALTERACAO) DO POSTGRES E PASSA O CRUD E A CONEXAO
                NpgsqlCommand inserenobanco = new NpgsqlCommand(CRUD, novaConexao);
                //REALIZA A INSERCAO DE DADOS OU DELETE  (CRUD)
                inserenobanco.ExecuteNonQuery();
                //MessageBox.Show("entrou na conexão");
                novaConexao.Close();
                return "Operacao realizada com sucesso";
            }
            catch (Exception erro)
            {
                return "ERRO: " + erro.Message;
            }
        }

        //ESTA FUNCAO SE CONECTA AO BANCO PARA ***CONSULTAR*** DADOS
        private string conectarConsultarDesconectar()
        {
            try
            {
                //CHAMA NOVA CONEXAO E PASSA A CHAVE DO BANCO
                NpgsqlConnection novaConexao = new NpgsqlConnection(chave);
                //ABRE CONEXAO
                novaConexao.Open();
                //INSTANCIA OS COMANDOS(DE LEITURA) DO POSTGRES E PASSA O CRUD E A CONEXAO
                NpgsqlCommand consultanobanco = new NpgsqlCommand(CRUD, novaConexao);
                //REALIZA A QUERY(BUSCA) SOLICITADA  (CRUD)
                NpgsqlDataReader leitor = consultanobanco.ExecuteReader();
                resposta = "";
                //RETORNA O CONTEUDO DO CAMPO SOLICITADO COMO STRING
                while (leitor.Read())
                {
                    resposta = leitor[0].ToString();
                }
                novaConexao.Close();
                return resposta;
            }
            catch (Exception erro)
            {
                return "ERRO: " + erro.Message;
            }
        }


        private string conectarTabelaDesconectar()
        {
            NpgsqlDataAdapter data_adapter;            

            try
            {
                //CHAMA NOVA CONEXAO E PASSA A CHAVE DO BANCO
                NpgsqlConnection novaConexao = new NpgsqlConnection(chave);
                //ABRE CONEXAO
                novaConexao.Open();
                
                //Cria um novo adaptador para os dados na tabela
                data_adapter = new NpgsqlDataAdapter();
                data_adapter.SelectCommand = new NpgsqlCommand(CRUD, novaConexao);              

                //cria os comandos insert update e delete
                NpgsqlCommandBuilder cmdBuilder = new NpgsqlCommandBuilder(data_adapter);

                //cria e prenche uma tabela com os dados do banco usando o adaptador
                data_table = new DataTable();
                data_adapter.Fill(data_table);
                resposta = "Operacao realizada com sucesso";
            }
            //monitora possíveis erros
            catch (NpgsqlException ex)
            {
                resposta = "ERRO: " + ex.Message + ex.StackTrace;
            }

            return resposta;
        }

        public string cadastraUsuario(string nome, string email, string senha)
        {
            //CADASTRO DE NOVO USARIO NO BANCO
            CRUD = "insert into usuario (nome_user, email_user, senha_user) values ('" + nome + "', '" + email + "', '" + senha + "');";
            resposta = conectarInserirDesconectar();
            return resposta;
        }

        public string getIDUsuario(string email)
        {
            CRUD = "select cod_user from usuario where email_user = '" + email + "';";
            resposta = conectarConsultarDesconectar();
            return resposta;
        }

        public string getSenhaUsuario(string email)
        {
            CRUD = "select senha_user from usuario where email_user = '" + email + "';";
            resposta = conectarConsultarDesconectar();
            return resposta;
        }
        public string alunoOuProfessor(string cod_user)
        {
            CRUD = "select cod_professor from professor where usuario = '" + cod_user + "';";
            resposta = conectarConsultarDesconectar();
            if (resposta.StartsWith("ERRO:"))
            {
                return resposta;
            }
            else if (resposta != "")
            {
                resposta = "PROFESSOR";
            }
            else
            {
                CRUD = "select cod_aluno from aluno where usuario = '" + cod_user + "';";
                resposta = conectarConsultarDesconectar();
                if ((resposta != "") && (!resposta.StartsWith("ERRO"))) resposta = "ALUNO";
            }
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

        public string getIDAluno(string cod_user)
        {
            CRUD = "select cod_aluno from aluno where usuario = '" + cod_user + "';";
            resposta = conectarConsultarDesconectar();
            return resposta;
        }

        public void deletaAluno(string cod_user)
        {
            CRUD = "delete FROM aluno where usuario = '" + cod_user + "';";
            resposta = conectarInserirDesconectar();
        }

        public string getTurmaID(string curso, string semestre)
        {
            CRUD = "select * from turma where curso = '" + curso + "' and semestre = '" + semestre + "';";
            resposta = conectarConsultarDesconectar();
            return resposta;
        }


        public string matriculaAlunoTurma(string IDTurma, string cod_aluno)
        {
            CRUD = "insert into matricula (turma, aluno) values ('" + IDTurma + "', '" + cod_aluno + "');";
            resposta = conectarInserirDesconectar();
            return resposta;
        }


        public string salvaRankingGeral(string cod_jogo, string cod_user, string pontuacao)
        {
            CRUD = "delete FROM ranking_geral where jogo = '" + cod_jogo + "' and usuario = '" + cod_user + "';";
            resposta = conectarInserirDesconectar();


            CRUD = "insert into ranking_geral (jogo, usuario, pontuacao) values ('" + cod_jogo + "', '" + cod_user + "', '" + pontuacao + "');";
            resposta = conectarInserirDesconectar();

            return resposta;
        }

        public string carregaRankingGeral(string cod_jogo)
        {
            CRUD = "SELECT usuario.nome_user, ranking_geral.pontuacao from usuario " +
                "inner join ranking_geral on usuario.cod_user = ranking_geral.usuario " +
                "where ranking_geral.jogo = " + cod_jogo;         
            resposta = conectarTabelaDesconectar();
            return resposta;
        }

        public string getDescricaoJogo(string cod_jogo)
        {
            CRUD = "select descricao_jogo from jogo where cod_jogo = '" + cod_jogo + "';";
            resposta = conectarConsultarDesconectar();
            return resposta;
        }
        public string getNomeJogo(string cod_jogo)
        {
            CRUD = "select nome_jogo from jogo where cod_jogo = '" + cod_jogo + "';";
            resposta = conectarConsultarDesconectar();
            return resposta;
        }

        public DataTable getDataTable()
        {
            return data_table;
        }
    }
}
