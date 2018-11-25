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

        public string deletaUsuario(string email)
        {
            //INSTANCIA A CLASSE CONEXAO
            Conexao banco = new Conexao();
            //SOLICITA A CLASSE BANCO PARA DELETAR USUARIO (UTILIZANDO COMO REFERENCIA O EMAIL)
            return banco.deletaUsuario(email);
        }
    }
}
