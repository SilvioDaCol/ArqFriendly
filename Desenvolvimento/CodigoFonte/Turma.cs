using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace gameLearning
{
    class Turma
    {
        public string cod_turma;
        public string curso;
        public string semestre;
        public string professor;
        public List<Aluno> alunos;
        public string nomeTurma;         
        
        public Turma()
        {

        }

        public Turma(DataRow drTurma) 
        {
            cod_turma = drTurma["cod_turma"].ToString();
            curso = drTurma["curso"].ToString();
            semestre = drTurma["semestre"].ToString();
            professor = drTurma["prof"].ToString();
            nomeTurma = curso + " - " + semestre + "º SEMESTRE";

            alunos = new List<Aluno>();
            DataTable tbAlunosTurma = new DataTable();
            tbAlunosTurma = getAlunosTurma(cod_turma);

            for(int i = 0; i<tbAlunosTurma.Rows.Count; i++)
            {
                alunos.Add(new Aluno(tbAlunosTurma.Rows[i]));
            }           

        }

        public string cadastrarTurma(string curso, string semestre, string cod_professor)
        {
            Conexao banco = new Conexao();            
            string resposta = banco.cadastrarTurma(curso, semestre, cod_professor);
            return resposta;
        }

        public DataTable getTurmas()
        {
            Conexao banco = new Conexao();
            banco.getListaTurmas();

            return banco.getDataTable();
        }

        public DataTable getAlunosTurma(string cod_turma)
        {
            Conexao banco = new Conexao();
            banco.getAlunosTurma(cod_turma);

            return banco.getDataTable();
        }

        public string deletaTurma(string cod_turma)
        {
            Conexao banco = new Conexao();
            string resposta = banco.deletaTurma(cod_turma);
            if(resposta.StartsWith("ERRO: "))
            {
                resposta = "Não foi possível deletar turma, pois há alunos matriculados";
            }
            return resposta;
        }
    }
}
