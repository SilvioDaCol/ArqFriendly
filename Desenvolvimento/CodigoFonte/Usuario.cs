using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameLearning
{
    class Usuario
    {
        private string resultado; //VARIAVEL QUE RECEBE RESULTADO DA OPERACAO NO BANCO

        public Usuario()
        {
            resultado = "";
        }

        //
        public string cadastraUsuario(string nome, string email, string senha, string ConfirmaSenha)
        {
            //INSTANCIA A CLASSE CONEXAO
            Conexao banco = new Conexao();
            //SOLICITA A CLASSE BANCO PARA CADASTRAR USUARIO 
            resultado = banco.cadastraUsuario(nome, email, senha);
            //RETORNA RESULTADO (SUCESSO OU ERRO OCORRIDO)
            return resultado;
        }

        public string getIDUsuario(string email)
        {
            Conexao banco = new Conexao();
            return banco.getIDUsuario(email);
        }

        public string alunoOuProfessor(string cod_user)
        {
            Conexao banco = new Conexao();
            return banco.alunoOuProfessor(cod_user);
        }

        public string getSenhaUsuario(string email)
        {
            Conexao banco = new Conexao();
            return banco.getSenhaUsuario(email); 
        }

        public string deletaUsuario(string email)
        {
            //INSTANCIA A CLASSE CONEXAO
            Conexao banco = new Conexao();
            //SOLICITA A CLASSE BANCO PARA DELETAR USUARIO (UTILIZANDO COMO REFERENCIA O EMAIL)
            return banco.deletaUsuario(email);
        }

        public string logarUsuario(string email, string senha)
        {
            string cod_user = getIDUsuario(email);
            if (cod_user.StartsWith("ERRO:"))
            {
                return resultado;
            }else if(cod_user == "")
            {
                return "Usuário não cadastrado no sistema";
            }
            else if(getSenhaUsuario(email) != senha)
            {                
                return "Senha não confere.";
            }
            
            return alunoOuProfessor(cod_user);
        }
    }
}
