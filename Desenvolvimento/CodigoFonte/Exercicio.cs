using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace gameLearning
{
    class Exercicio
    {
        string resposta;

        public DataTable carregaAtividadesProfessor(string cod_professor)
        {
            Conexao banco = new Conexao();
            resposta = banco.carregaAtividadesProfessor(cod_professor);
            DataTable dt = new DataTable();
            if (resposta == "Operacao realizada com sucesso")
            {
                dt = banco.getDataTable();
            }
            return dt;
        }
    }
}
