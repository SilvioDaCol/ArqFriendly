using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameLearning
{
    class Professor
    {
        private string resultado; //VARIAVEL QUE RECEBE RESULTADO DA OPERACAO NO BANCO
        private Usuario usuario; //INSTANCIA UM USUARIO PARA ESTE PROFESSOR

        public Professor() {
            resultado = "";
            usuario = new Usuario();
        }

        public string cadastraProfessor(string nome, string matricula, string email, string senha, string ConfirmaSenha)
        {     
            //SOLICITA A CLASSE USUARIO PARA REGISTRAR NO BANCO OS DADOS REFERENTES AO USUARIO E ARMAZERNA RESPOSTA(SUCESSO OU ERRO DO BANCO) NA VARIAVEL RESULTADO
            resultado = usuario.cadastraUsuario(nome, email, senha, ConfirmaSenha);
            //SE USUARIO FOI CADASTRADO COM SUCESSO NO BANCO
            if(resultado == "Operacao realizada com sucesso")
            {
                //INSTANCIA A CLASSE CONEXAO
                Conexao banco = new Conexao();
                //BUSCA NO BANCO O ID DO USUARIO CADASTRADO (UTILIZANDO PARAMETRO EMAIL COMO FILTRO) OBS** O CAMPU EMAIL É UNICO NO BANCO.
                string cod_user = banco.getIDUsuario(email);
                //CHAMA FUNCAO DO BANCO QUE CADASTRA O PROFESSOR, RELACIONADO AO USUARIO QUE FOI CRIADO PARA ESTE.
                resultado = banco.cadastraProfessor(cod_user, matricula);
            }
            
            //SE HOUVE ERRO NO CADASTRO DO PROFESSOR, DELETA USUARIO CRIADO 
            if(resultado != "Operacao realizada com sucesso")
            {
                //LIMPA REGISTRO DESTE USUARIO
                usuario.deletaUsuario(email);
            }

            //RETORNA PARA A INTERFACE SE O CADASTRO FOI BEM SUCEDIDO OU O ERRO OCORRIDO
            return resultado;
        }        
        
    }
}
