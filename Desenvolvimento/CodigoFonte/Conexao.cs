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
            //chave = "Server=localhost;Port=5432;UserId=postgres;Password=Sophia20;Database=gamelearning_db";           
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


        private string conectarUpdateTabelaDesconectar()
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
                //Diz que iremos utilizar "colchetes" para especificar objetos 
                //de banco de dados (tabelas, colunas...)cujos nomes contenham caracteres 
                //como espaços ou símbolos reservados;
                cmdBuilder.QuotePrefix = "[";
                cmdBuilder.QuoteSuffix = "]";

                //Atualiza banco com oas dados da tabela
                data_adapter.Update(data_table);

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
            //PEGA ID USUSÁRIO
            CRUD = "select cod_user from usuario where email_user = '" + email + "';";
            resposta = conectarConsultarDesconectar();
            return resposta;
        }

        public string getNomeUsuario(string cod_user)
        {
            //PEGA NOME USUSÁRIO
            CRUD = "select nome_user from usuario where cod_user = '" + cod_user + "';";
            resposta = conectarConsultarDesconectar();
            return resposta;
        }

        //CRUD RESPONSAVEL PELAS CONSULTA

        public string getSenhaUsuario(string email)
        {
            //PEGA SENHA DO USUARIO
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

        public string deletaUsuario(string email)
        {
            CRUD = "delete FROM usuario where email_user = '" + email + "';";
            resposta = conectarInserirDesconectar();

            return resposta;
        }


        public string cadastraProfessor(string cod_user, string matricula)
        {
            CRUD = "insert into professor (registro, usuario) values ('" + matricula + "', '" + cod_user + "');";
            resposta = conectarInserirDesconectar();
            return resposta;
        }

        public string getIDProfessor(string cod_user)
        {
            CRUD = "select cod_professor from professor where usuario = '" + cod_user + "';";
            resposta = conectarConsultarDesconectar();
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

        public string getListaTurmas() {
            CRUD = "SELECT * from turma";
            resposta = conectarTabelaDesconectar();
            return resposta;
        }

        public string getAlunosTurma(string cod_turma)
        {
            CRUD = "select u.cod_user, u.nome_user, u.email_user, a.cod_aluno, a.ra_aluno from usuario u " +
                "inner join aluno a on u.cod_user = a.usuario " +
                "inner join matricula m on m.aluno = a.cod_aluno " +
                "where m.turma = "+ cod_turma;
            resposta = conectarTabelaDesconectar();
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

        public string getIDJogo(string nome_jogo)
        {
            CRUD = "select cod_jogo from jogo where nome_jogo = '" + nome_jogo + "';";
            return resposta;
        }

        public string carregaAtividadesProfessor(string cod_professor)
        {
            CRUD = "SELECT a.cod_atividade, a.inicio_atividade, a.prazo_atividade, jogo.nome_jogo from atividade a " +
                "inner join jogo on a.jogo = jogo.cod_jogo " +
                "where a.prof = " + cod_professor;
            resposta = conectarTabelaDesconectar();
            return resposta;
        }

        public string carregaAtividadesAluno(string cod_aluno)
        {
            CRUD = "select a.cod_atividade, a.inicio_atividade, a.prazo_atividade, u.nome_user, j.nome_jogo from atividade a " +
                "inner join professor p on p.cod_professor = a.prof " +
                "inner join usuario u on p.usuario = u.cod_user " +
                "inner join jogo j on j.cod_jogo = a.Jogo " +
                "inner join inscreve i on i.atividade = a.cod_atividade " +
                "where i.aluno = " + cod_aluno + " and i.pontuacao = -1 ";
            resposta = conectarTabelaDesconectar();
            return resposta;
        }

        public string deletaAtividade(string cod_atividade)
        {
            //DELETA AS  INSCRICOES RELACIONADAS
            CRUD = "delete from inscreve where atividade = '" + cod_atividade + "';";
            resposta = conectarInserirDesconectar();
            if(resposta == "Operacao realizada com sucesso")
            {
                //DELETA A ATIVIDADE
                CRUD = "delete FROM atividade where cod_atividade = '" + cod_atividade + "';";
                resposta = conectarInserirDesconectar();
            }
            
            return resposta;
        }

        public string cadastraAtividade(string dataPrazo, string dataInicio, string cod_professor, string cod_jogo)
        {
            CRUD = "insert into atividade (prazo_atividade, inicio_atividade, prof, jogo) values ('" + dataPrazo + "', '" + dataInicio + "', '" + cod_professor + "', '" + cod_jogo + "');";
            resposta = conectarInserirDesconectar();
            return resposta;
        }

        public string getAtividades()
        {
            CRUD = "SELECT * from atividade";
            resposta = conectarTabelaDesconectar();
            return resposta;
        }

        public string getAlunosAtividade(string cod_atividade)
        {
            CRUD = "select u.nome_user, a.ra_aluno, i.pontuacao, u.email_user from usuario u " +
                "inner join aluno a on u.cod_user = a.usuario " +
                "inner join inscreve i on a.cod_aluno = i.aluno " +
                "where i.atividade = "+cod_atividade;
            resposta = conectarTabelaDesconectar();
            return resposta;
        }

        public string cadastraAlunosAtividade(string cod_aluno, string cod_atividade)
        {
            CRUD = "INSERT INTO inscreve (aluno, atividade) values ('"+ cod_aluno +"', '"+ cod_atividade +"');";
            resposta = resposta = conectarInserirDesconectar();
            return resposta;
        }

        public string salvaPontuacaoAluno(string cod_atividade, string cod_aluno, string pontuacao)
        {
            CRUD = "UPDATE inscreve SET pontuacao = '"+ pontuacao +"'" +
                "WHERE atividade = '" + cod_atividade + "' and aluno = '" + cod_aluno + "';";
            resposta = conectarInserirDesconectar();
            return resposta;
        }

        public DataTable getDataTable()
        {
            return data_table;
        }
    }
}
