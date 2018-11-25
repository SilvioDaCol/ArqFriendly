using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameLearning
{
    class Aluno : Usuario
    {
        private string resultado;
        private Usuario usuario;

        public Aluno()
        {
            resultado = "";
            usuario = new Usuario();
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
                //BUSCA NO BANCO O ID DO USUARIO CADASTRADO (UTILIZANDO PARAMETRO EMAIL COMO FILTRO) OBS** O CAMPO EMAIL É UNICO NO BANCO.
                string cod_user = banco.getIDUsuario(email);
                //CHAMA FUNCAO DO BANCO QUE CADASTRA O ALUNO, RELACIONADO AO USUARIO QUE FOI CRIADO PARA ESTE.
                resultado = banco.cadastraAluno(cod_user, ra_aluno, curso, semestre);
            }
            //SE HOUVE ERRO NO CADASTRO DO ALUNO, DELETA USUARIO CRIADO 
            else
            {
                usuario.deletaUsuario(email);
            }

            //RETORNA PARA A INTERFACE SE O CADASTRO FOI BEM SUCEDIDO OU O ERRO OCORRIDO
            return resultado;
        }
    }
}
