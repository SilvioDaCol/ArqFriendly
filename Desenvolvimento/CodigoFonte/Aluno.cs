using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace gameLearning
{
    class Aluno : Usuario
    {
        private string resultado;
        private Usuario usuario;

        public string cod_user;
        public string nome_user;
        public string email_user;
        public string cod_aluno;
        public string ra_aluno;
        public string nome_raAluno;

        public Aluno()
        {
            resultado = "";
            usuario = new Usuario();
        }
        public Aluno(DataRow drAluno)
        {
            cod_user = drAluno["cod_user"].ToString();            
            nome_user = drAluno["nome_user"].ToString();
            email_user = drAluno["email_user"].ToString();
            cod_aluno = drAluno["cod_aluno"].ToString();
            ra_aluno = drAluno["ra_aluno"].ToString();
            nome_raAluno = nome_user + " - RA: " + ra_aluno;
        }

            public string cadastraAluno(string nome, string ra_aluno, string email, string senha, string ConfirmaSenha, string curso, string semestre)
        {
            //SOLICITA A CLASSE USUARIO PARA REGISTRAR NO BANCO OS DADOS REFERENTES AO USUARIO E ARMAZERNA RESPOSTA(SUCESSO OU ERRO DO BANCO) NA VARIAVEL RESULTADO
            resultado = usuario.cadastraUsuario(nome, email, senha, ConfirmaSenha);
            //SE USUARIO FOI CADASTRADO COM SUCESSO NO BANCO
            if (resultado == "Operacao realizada com sucesso")
            {
                //INSTANCIA A CLASSE CONEXAO
                Conexao banco = new Conexao();
                //VERIFICA SE HÁ TURMA CADASTRADA PARA CURSO E SEMESTRE INFORMADOS
                string IDTurma = banco.getTurmaID(curso, semestre);
                //SE NÃO RETORNAR UM ERRO  E TURMA CONSTAR NO BANCO
                if (!IDTurma.StartsWith("ERRO:") && (IDTurma != ""))
                {
                    //BUSCA NO BANCO O ID DO USUARIO CADASTRADO (UTILIZANDO PARAMETRO EMAIL COMO FILTRO) OBS** O CAMPO EMAIL É UNICO NO BANCO.
                    string cod_user = banco.getIDUsuario(email);
                    //CHAMA FUNCAO DO BANCO QUE CADASTRA O ALUNO, RELACIONADO AO USUARIO QUE FOI CRIADO PARA ESTE.
                    resultado = banco.cadastraAluno(cod_user, ra_aluno, curso, semestre);
                    //SE ALUNO FOI CADASTRADO NO BANCO... 
                    if (resultado == "Operacao realizada com sucesso")
                    {
                        //CONSULTA CODIGO DO ALUNO CRIADO UTILIZANDO COMO PARÂMETRO O CODIGO DO USUÁRIO E ARMAZENA EM COD_ALUNO
                        string cod_aluno = banco.getIDAluno(cod_user);
                        //REALIZA MATRICULA -> VINCULA ALUNO E TURMA
                        resultado = banco.matriculaAlunoTurma(IDTurma, cod_aluno);
                        //Se ocorreu erro ao realizar matricula, deleta aluno do banco
                        if (resultado != "Operacao realizada com sucesso") banco.deletaAluno(cod_user);
                    }                    
                }
                //SE HOUVE ERRO AO PESQUISAR TURMA
                else
                {
                    resultado = "Não há turma cadastrada para este Curso/Semestre";
                }
                
            }
            //SE USUARIO NAO FOI CADASTRADO COM SUCESSO NO BANCO, RETORNA O ERRO OCORRIDO
            else return resultado;
            
            //SE HOUVE ERRO NO CADASTRO DO ALUNO, DELETA USUARIO CRIADO 
            if(resultado != "Operacao realizada com sucesso")
            {
                usuario.deletaUsuario(email);
            }

            //RETORNA PARA A INTERFACE SE O CADASTRO FOI BEM SUCEDIDO OU O ERRO OCORRIDO
            return resultado;
        }

        public string getIDAluno(string cod_user)
        {
            Conexao banco = new Conexao();
            return banco.getIDAluno(cod_user);
        }
    }
}
