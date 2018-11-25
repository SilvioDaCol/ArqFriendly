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
            resultado = usuario.cadastraUsuario(nome, email, senha, ConfirmaSenha);
            if (resultado == "Operacao realizada com sucesso")
            {
                Conexao banco = new Conexao();
                string cod_user = banco.getIDUsuario(email);
                resultado = banco.cadastraAluno(cod_user, ra_aluno, curso, semestre);
            }
            else
            {
                usuario.deletaUsuario(email);
            }
            return resultado;
        }
    }
}
