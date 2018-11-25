using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameLearning
{
    class Professor
    {
        private string resultado;
        private Usuario usuario;

        public Professor() {
            resultado = "";
            usuario = new Usuario();
        }

        public string cadastraProfessor(string nome, string matricula, string email, string senha, string ConfirmaSenha)
        {            
            resultado = usuario.cadastraUsuario(nome, email, senha, ConfirmaSenha);
            if(resultado == "Operacao realizada com sucesso")
            {
                Conexao banco = new Conexao();
                string cod_user = banco.getIDUsuario(email);
                resultado = banco.cadastraProfessor(cod_user, matricula);
            }
            else
            {
                usuario.deletaUsuario(email);
            }
            return resultado;
        }

    }
}
