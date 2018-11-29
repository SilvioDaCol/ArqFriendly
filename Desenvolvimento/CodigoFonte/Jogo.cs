using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace gameLearning
{
    class Jogo
    {
        private string pontuacao;
        private string resposta;

        public Jogo()
        {
            pontuacao = "0";
            resposta = "";
        }

        private string executaJogo(string path, string exe)
        {
            string resultado = "";
            System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo("CMD.exe");
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;
            System.Diagnostics.Process process = System.Diagnostics.Process.Start(processStartInfo);

            process.StandardInput.WriteLine(@""+path);
            process.StandardInput.WriteLine(@""+exe);

            // line added to stop process from hanging on ReadToEnd()
            process.StandardInput.Close();

            resultado = process.StandardOutput.ReadToEnd();            

            /*
             * >>>AQUI<<<
             * PROCESSAR DADOS DEVOLVIDOS PELO JOGO E VALIDAR RESULTADO
             * ARMAZAENAR VALOR OBTIDO NA STRING RESULTADO
             */
            if (resultado.Contains("PONTO-INICIO") && resultado.Contains("PONTO-FIM"))
            {
                int pontuacaoIndex = resultado.IndexOf("PONTO-INICIO")+12;
                int pontuacaoLenght = resultado.IndexOf("PONTO-FIM") - pontuacaoIndex;
                pontuacao = resultado.Substring(pontuacaoIndex, pontuacaoLenght);    
            }

            return pontuacao;
        }

        public string jogarStarWarsLC()
        {
            return executaJogo("cd StarWarsLC\\", "StarWars_LowCost.exe");
        }

        public string jogarAlgoRace()
        {
            return executaJogo("cd AlgoRace\\", "AlgoRace.exe");
        }

        public string jogarCTIGame()
        {
            return executaJogo("cd CTI_GAME\\", "CTI_Game.exe");
        }

        public string salvaRankingGeral(string cod_jogo, string cod_user, string pontuacao)
        {
            Conexao banco = new Conexao();
            resposta = banco.salvaRankingGeral(cod_jogo, cod_user, pontuacao);
            return resposta;
        }

        public DataTable carregaRankingGeral(string cod_jogo)
        {
            Conexao banco = new Conexao();
            resposta = banco.carregaRankingGeral(cod_jogo);
            return banco.getDataTable();
        }

        public string getNomeJogo(string cod_jogo)
        {
            Conexao banco = new Conexao();
            resposta = banco.getNomeJogo(cod_jogo);
            return resposta;
        }
        public string getDescricaoJogo(string cod_jogo)
        {
            Conexao banco = new Conexao();
            resposta = banco.getDescricaoJogo(cod_jogo);
            return resposta;
        }

        public string getIDJogo(string nome_jogo)
        {
            Conexao banco = new Conexao();
            resposta = banco.getIDJogo(nome_jogo);
            return resposta;
        }
    }
}
