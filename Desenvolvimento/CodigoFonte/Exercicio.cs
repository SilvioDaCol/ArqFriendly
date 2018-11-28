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

        public DataTable carregaAtividadesAluno(string cod_aluno)
        {
            Conexao banco = new Conexao();
            resposta = banco.carregaAtividadesAluno(cod_aluno);
            DataTable dt = new DataTable();
            if (resposta == "Operacao realizada com sucesso")
            {
                dt = banco.getDataTable();
            }
            return dt;
        }

        public string cadastraAtividade(string dataPrazo, string dataInicio, string cod_professor, string cod_jogo)
        {
            Conexao banco = new Conexao();
            //Cadastra a atividade
            resposta = banco.cadastraAtividade(dataPrazo, dataInicio, cod_professor, cod_jogo);
            //Se a atividade foi cadastrada com sucesso...
            if(resposta == "Operacao realizada com sucesso")
            {
                //Recupera tabeladas atividades cadastradas
                resposta = banco.getAtividades();
                DataTable dtAtividades = banco.getDataTable();
                //Lê o codigo da última atividade da lista e armazena em variavel resposta
                resposta = dtAtividades.Rows[dtAtividades.Rows.Count - 1]["cod_atividade"].ToString();
            }            

            return resposta;
        }

        public DataTable getAlunosAtividade(string cod_atividade)
        {
            Conexao banco = new Conexao();
            resposta = banco.getAlunosAtividade(cod_atividade);

            return banco.getDataTable();
        }

        public string cadastraAlunosAtividade(string cod_aluno, string cod_atividade)
        {
            Conexao banco = new Conexao();
            resposta = banco.cadastraAlunosAtividade(cod_aluno, cod_atividade);

            return resposta;
        }

        public string excluiAtividade(string cod_atividade)
        {
            Conexao banco = new Conexao();
            return banco.deletaAtividade(cod_atividade);
        }

    }
}
