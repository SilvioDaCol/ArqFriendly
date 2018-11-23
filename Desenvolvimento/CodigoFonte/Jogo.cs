using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameLearning
{
    class Jogo
    {
        private string pontuacao;

        public Jogo()
        {
            pontuacao = "0";
        }

        private string executaJogo(string path, string exe)
        {
            string resultado;
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
            pontuacao = resultado;

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
    }
}
