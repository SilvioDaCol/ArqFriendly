using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameLearning
{
    class Usuario
    {
        private string resultado;

        public Usuario()
        {
            resultado = "";
        }

        public string cadastraUsuario(string nome, string email, string senha, string ConfirmaSenha)
        {
            Conexao banco = new Conexao();
            if (senha == ConfirmaSenha)
            {
                resultado = banco.cadastraUsuario(nome, email, senha);
            }
            return resultado;
        }

        public string deletaUsuario(string email)
        {
            Conexao banco = new Conexao();
            return banco.deletaUsuario(email);
        }
    }
}
